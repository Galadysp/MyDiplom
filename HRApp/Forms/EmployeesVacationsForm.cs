using HRApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApp.Forms
{
    public partial class EmployeesVacationsForm : Form
    {
        int PageSize = 10;
        int PageNumber = 0;
        int CountRows = 0;
        int CountRowsPage = 0;
        int NumRows = 0;
        private string result;
        bool Flag = false;


        SqlDataAdapter sda;
        DataSet ds;
        StringBuilder sb = new StringBuilder();
        string connectionstring = @"workstation id=HRAppDB.mssql.somee.com;packet size = 4096; user id = galadysp_SQLLogin_4; pwd=5gephl2yz4;data source = HRAppDB.mssql.somee.com; persist security info=False;initial catalog = HRAppDB";

        public EmployeesVacationsForm()
        {
            InitializeComponent();
            EmployeesVacationGridView.ClearSelection();
        }

        private string GetSql()
        {
            return $"SELECT * FROM EmployeesVacations {sb.ToString()} " + $"ORDER BY ID_Vacation OFFSET ((" + PageNumber + ") * " + PageSize + ") " + "ROWS FETCH NEXT " + PageSize + "ROWS ONLY";
        }

        private int GetSqlCount()
        {
            int numRows;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = $"SELECT count(*) FROM EmployeesVacations {sb.ToString()}";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                numRows = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return numRows;
        }


        public void UpdateFilter()
        {
            try
            {
                sb = new StringBuilder("WHERE ");

                if (IDTextBox.Text.ToString() != "")
                    sb.Append($"ID_Employer = '{IDTextBox.Text}'");
                else
                    sb.Append($"ID_Employer is not null'");

                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["EmployeesVacations"].Rows.Clear();
                    sda.Fill(ds, "EmployeesVacations");
                }

                CountRowsPage = 0;
                CountRows = EmployeesVacationGridView.Rows.Count;

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
                ds.Tables["EmployeesVacations"].Rows.Clear();
                sda.Fill(ds, "EmployeesVacations");
            }
            CountRowsPage = 0;
            CountRows = EmployeesVacationGridView.Rows.Count;

            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;
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

        private void BTButton_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessTripsForm businessTrips = new BusinessTripsForm();
                this.Hide();
                businessTrips.Show();
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

        private void PervButton_Click(object sender, EventArgs e)
        {
            if (PageNumber == 0) return;
            PageNumber--;

            CountRowsPage = EmployeesVacationGridView.Rows.Count;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["EmployeesVacations"].Rows.Clear();
                sda.Fill(ds, "EmployeesVacations");
            }
            if (EmployeesVacationGridView.Rows.Count != 0)
            {
                if (PageNumber >= 0 && Flag)
                    CountRows -= CountRowsPage;
                CountRowsPage = EmployeesVacationGridView.Rows.Count;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ds.Tables["EmployeesVacations"].Rows.Count < PageSize) return;
            PageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["EmployeesVacations"].Rows.Clear();
                sda.Fill(ds, "EmployeesVacations");
            }
            if (EmployeesVacationGridView.Rows.Count != 0 && Flag)
            {
                CountRowsPage = EmployeesVacationGridView.Rows.Count;
                CountRows += CountRowsPage;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if (EmployeesVacationGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in this.EmployeesVacationGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }
                try
                {
                    result = "ПРИКАЗ \n";
                    result += "О предоставлении отпуска работнику \n";
                    result += "Номер документа:" + EmployeesVacationGridView.CurrentRow.Cells[0].Value.ToString() + "\n";
                    result += "Табельный номер: " + EmployeesVacationGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
                    result += "Отпуск" + EmployeesVacationGridView.CurrentRow.Cells[5].Value.ToString() + "\n";
                    result += "С" + EmployeesVacationGridView.CurrentRow.Cells[4].Value.ToString();
                    result += "по" + EmployeesVacationGridView.CurrentRow.Cells[3].Value.ToString() + "\n";
                    result += "Дата подписания" + EmployeesVacationGridView.CurrentRow.Cells[2].Value.ToString() + "\n";

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
                MessageBox.Show($"Необходимо выделить только одну строку.", "Печать", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {

                AddEditEmloyeesVacation add = new AddEditEmloyeesVacation();
                add.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if (EmployeesVacationGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in this.EmployeesVacationGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }

                if (MessageBox.Show($"Вы действительно хотите безвозратно удалить выбранную запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        EmployeesVacations entry = HRAppDBEntities.GetContext().EmployeesVacations
                            .Where(o => o.ID_Vacation == ide).FirstOrDefault();
                        HRAppDBEntities.GetContext().EmployeesVacations.Remove(entry);

                        HRAppDBEntities.GetContext().SaveChanges();

                        MessageBox.Show($"Данные удалены!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PageNumber = 0;
                        using (SqlConnection connection = new SqlConnection(connectionstring))
                        {
                            sda = new SqlDataAdapter(GetSql(), connection);
                            ds.Tables["EmployeesVacations"].Rows.Clear();
                            sda.Fill(ds, "EmployeesVacations");
                        }

                        CountRowsPage = 0;
                        CountRows = EmployeesVacationGridView.Rows.Count;

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
                MessageBox.Show($"Необходимо выделить только одну строку.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeesVacationsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder("");
            IDTextBox.Text = "";
            DRCheckBox.Checked = false;
            DOOCheckBox.Checked = false;

            Clear();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void DOOCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (DOOCheckBox.Checked)
                    EmployeesVacationGridView.Sort(EmployeesVacationGridView.Columns[3], ListSortDirection.Ascending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (DRCheckBox.Checked)
                    EmployeesVacationGridView.Sort(EmployeesVacationGridView.Columns[4], ListSortDirection.Ascending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmployeesVacationGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form form = new AddEditEmloyeesVacation(EmployeesVacationGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void EmployeesVacationGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show(e.Exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeesVacationsForm_Load(object sender, EventArgs e)
        {
            EmployeesVacationGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds = new DataSet();
                sda.Fill(ds, "EmployeesVacations");
                EmployeesVacationGridView.DataSource = ds.Tables[0];
            }

            CountRows = EmployeesVacationGridView.Rows.Count;
            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;

            foreach (DataGridViewColumn item in EmployeesVacationGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            sb = new StringBuilder();
            IDTextBox.Text = "";
            DRCheckBox.Checked = false;
            DOOCheckBox.Checked = false;

            EmployeesVacationGridView.ClearSelection();
            Flag = true;
        }
    }
}