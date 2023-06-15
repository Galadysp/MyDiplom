using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HRApp.Models;
using System.Drawing.Printing;

namespace HRApp.Forms
{
    public partial class BusinessTripsForm : Form
    {
        int PageSize = 10;
        int PageNumber = 0;
        int CountRows = 0;
        int CountRowsPage = 0;
        int NumRows = 0;
        private string result;

        SqlDataAdapter sda;
        DataSet ds;
        StringBuilder sb = new StringBuilder();
        string connectionstring = @"workstation id=HRAppDB.mssql.somee.com;packet size = 4096; user id = galadysp_SQLLogin_4; pwd=5gephl2yz4;data source = HRAppDB.mssql.somee.com; persist security info=False;initial catalog = HRAppDB";

        public BusinessTripsForm()
        {
            InitializeComponent();
            BusinessTripsFormGridView.ClearSelection();
        }

        private string GetSql()
        {
            return $"SELECT * FROM BusinessTrips {sb.ToString()} " + $"ORDER BY ID_BusinessTrips OFFSET ((" + PageNumber + ") * " + PageSize + ") " + "ROWS FETCH NEXT " + PageSize + "ROWS ONLY";
        }

        private int GetSqlCount()
        {
            int numRows;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = $"SELECT count(*) FROM BusinessTrips {sb.ToString()}";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                numRows = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return numRows;
        }

        bool Flag = false;

        private void BusinessTripsForm_Load(object sender, EventArgs e)
        {

            BusinessTripsFormGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds = new DataSet();
                sda.Fill(ds, "BusinessTrips");
                BusinessTripsFormGridView.DataSource = ds.Tables[0];
            }

            CountRows = BusinessTripsFormGridView.Rows.Count;
            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;

            foreach (DataGridViewColumn item in BusinessTripsFormGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            sb = new StringBuilder();
            IDTextBox.Text = "";
            FRComboBox.Text = "";
            DRCheckBox.Checked = false;
            DOOCheckBox.Checked = false;

            BusinessTripsFormGridView.ClearSelection();
            Flag = true;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.FundingSources". При необходимости она может быть перемещена или удалена.
            this.fundingSourcesTableAdapter.Fill(this.hRAppDBDataSet.FundingSources);

        }

        public void UpdateFilter()
        {
            try
            {
                sb = new StringBuilder("WHERE ");
                if (IDTextBox.Text != "")
                    sb.Append($"ID_Employer = '{IDTextBox.Text}'");
                else
                    sb.Append($"ID_Employer is not null");

                if (FRComboBox.SelectedValue != "")
                    sb.Append($" AND FundingSource = '{FRComboBox.SelectedValue}'");
                else
                    sb.Append($" AND FundingSource is not null");

                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["BusinessTrips"].Rows.Clear();
                    sda.Fill(ds, "BusinessTrips");
                }

                CountRowsPage = 0;
                CountRows = BusinessTripsFormGridView.Rows.Count;

                NumRows = GetSqlCount();
                PageLabel.Text = CountRows + " из " + NumRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Clear()
        {
            PageNumber = 0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["BusinessTrips"].Rows.Clear();
                sda.Fill(ds, "BusinessTrips");
            }
            CountRowsPage = 0;
            CountRows = BusinessTripsFormGridView.Rows.Count;

            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;
        }


        private void PervButton_Click(object sender, EventArgs e)
        {
            if (PageNumber == 0) return;
            PageNumber--;

            CountRowsPage = BusinessTripsFormGridView.Rows.Count;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["BusinessTrips"].Rows.Clear();
                sda.Fill(ds, "BusinessTrips");
            }
            if (BusinessTripsFormGridView.Rows.Count != 0)
            {
                if (PageNumber >= 0 && Flag)
                    CountRows -= CountRowsPage;
                CountRowsPage = BusinessTripsFormGridView.Rows.Count;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ds.Tables["BusinessTrips"].Rows.Count < PageSize) return;
            PageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["BusinessTrips"].Rows.Clear();
                sda.Fill(ds, "BusinessTrips");
            }
            if (BusinessTripsFormGridView.Rows.Count != 0 && Flag)
            {
                CountRowsPage = BusinessTripsFormGridView.Rows.Count;
                CountRows += CountRowsPage;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void BusinessTripsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите выйти из учетной записи?", "Предупреждение",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                try
                {
                    AuthForm authForm = new AuthForm();
                    this.Hide();
                    authForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LeavesButton1_Click(object sender, EventArgs e)
        {
            try
            {
                LeavesForm leaves = new LeavesForm();
                this.Hide();
                leaves.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StudyButton_Click(object sender, EventArgs e)
        {
            try
            {

                EmployeesEducationForm employeesEducation = new EmployeesEducationForm();
                this.Hide();
                employeesEducation.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VacationsButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesVacationsForm employeesVacation = new EmployeesVacationsForm();
                this.Hide();
                employeesVacation.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder("");
            IDTextBox.Text = "";
            FRComboBox.Text = "";
            DRCheckBox.Checked = false;
            DOOCheckBox.Checked = false;

            BusinessTripsFormGridView.Sort(BusinessTripsFormGridView.Columns[0], ListSortDirection.Ascending);

            Clear();
        }

        private void BusinessTripsFormGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show(e.Exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void IDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void DRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            if (DRCheckBox.Checked)
            BusinessTripsFormGridView.Sort(BusinessTripsFormGridView.Columns[2], ListSortDirection.Ascending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BusinessTripsFormGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form form = new AddEditBusinessTrip(BusinessTripsFormGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if (BusinessTripsFormGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in this.BusinessTripsFormGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }

                if (MessageBox.Show($"Вы действительно хотите безвозратно удалить выбранную запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        BusinessTrips entry = HRAppDBEntities.GetContext().BusinessTrips
                            .Where(o => o.ID_BusinessTrips == ide).FirstOrDefault();
                        HRAppDBEntities.GetContext().BusinessTrips.Remove(entry);

                        HRAppDBEntities.GetContext().SaveChanges();

                        MessageBox.Show($"Данные удалены!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PageNumber = 0;
                        using (SqlConnection connection = new SqlConnection(connectionstring))
                        {
                            sda = new SqlDataAdapter(GetSql(), connection);
                            ds.Tables["BusinessTrips"].Rows.Clear();
                            sda.Fill(ds, "BusinessTrips");
                        }

                        CountRowsPage = 0;
                        CountRows = BusinessTripsFormGridView.Rows.Count;

                        NumRows = GetSqlCount();
                        PageLabel.Text = CountRows + " из " + NumRows;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show($"Необходимо выделить только одну строку", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {

                AddEditBusinessTrip add = new AddEditBusinessTrip();
                add.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(result, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if (BusinessTripsFormGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in this.BusinessTripsFormGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }
                try
                {
                    result = "ПРИКАЗ \n";
                    result += "О направлении работника в командировку \n";
                    result += "Номер документа:" + BusinessTripsFormGridView.CurrentRow.Cells[0].Value.ToString() + "\n";
                    result += "Табельный номер: " + BusinessTripsFormGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
                    result += "с" + BusinessTripsFormGridView.CurrentRow.Cells[3].Value.ToString();
                    result += "по" + BusinessTripsFormGridView.CurrentRow.Cells[2].Value.ToString() + "\n";
                    result += "С целью" + BusinessTripsFormGridView.CurrentRow.Cells[4].Value.ToString() + "\n";
                    result += "Командировка за счет средств" + BusinessTripsFormGridView.CurrentRow.Cells[5].Value.ToString() + "\n";
                    result += "Дата подписания" + BusinessTripsFormGridView.CurrentRow.Cells[6].Value.ToString() + "\n";
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += PrintPageHandler;
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument;
                    if (printDialog.ShowDialog() == DialogResult.OK)
                        printDialog.Document.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show($"Необходимо выделить только одну строку", "Печать", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DOOCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (DOOCheckBox.Checked)
                BusinessTripsFormGridView.Sort(BusinessTripsFormGridView.Columns[6], ListSortDirection.Ascending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
    

