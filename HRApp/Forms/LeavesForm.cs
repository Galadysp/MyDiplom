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
using System.Drawing.Printing;
using HRApp.Models;

namespace HRApp.Forms
{
    public partial class LeavesForm : Form
    {
        int PageSize = 10;
        int PageNumber = 0;
        int CountRows = 0;
        int CountRowsPage = 0;
        int NumRows = 0;
        bool Flag = false;
        private string result;


        SqlDataAdapter sda;
        DataSet ds;
        StringBuilder sb = new StringBuilder();
        string connectionstring = @"workstation id=HRAppDB.mssql.somee.com;packet size = 4096; user id = galadysp_SQLLogin_4; pwd=5gephl2yz4;data source = HRAppDB.mssql.somee.com; persist security info=False;initial catalog = HRAppDB";

        public LeavesForm()
        {
            InitializeComponent();
            LeavesGridView.ClearSelection();
        }

        private string GetSql()
        {
            return $"SELECT * FROM Leaves {sb.ToString()} " + $"ORDER BY ID_leave OFFSET ((" + PageNumber + ") * " + PageSize + ") " + "ROWS FETCH NEXT " + PageSize + "ROWS ONLY";
        }

        private int GetSqlCount()
        {
            int numRows;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = $"SELECT count(*) FROM Leaves {sb.ToString()}";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                numRows = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return numRows;
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

            CountRowsPage = LeavesGridView.Rows.Count;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Leaves"].Rows.Clear();
                sda.Fill(ds, "Leaves");
            }
            if (LeavesGridView.Rows.Count != 0)
            {
                if (PageNumber >= 0 && Flag)
                    CountRows -= CountRowsPage;
                CountRowsPage = LeavesGridView.Rows.Count;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Leaves"].Rows.Count < PageSize) return;
            PageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Leaves"].Rows.Clear();
                sda.Fill(ds, "Leaves");
            }
            if (LeavesGridView.Rows.Count != 0 && Flag)
            {
                CountRowsPage = LeavesGridView.Rows.Count;
                CountRows += CountRowsPage;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
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

                if (RComboBox.SelectedValue != "")
                    sb.Append($" AND Reason = '{RComboBox.SelectedValue}'");
                else
                    sb.Append($" AND Reason is not null");

                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["Leaves"].Rows.Clear();
                    sda.Fill(ds, "Leaves");
                }

                CountRowsPage = 0;
                CountRows = LeavesGridView.Rows.Count;

                NumRows = GetSqlCount();
                PageLabel.Text = CountRows + " из " + NumRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void RComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        public void Clear()
        {
            PageNumber = 0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Leaves"].Rows.Clear();
                sda.Fill(ds, "Leaves");
            }
            CountRowsPage = 0;
            CountRows = LeavesGridView.Rows.Count;

            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder("");
            IDTextBox.Text = "";
            RComboBox.Text = "";
            DOLCheckBox.Checked = false;

            Clear();
        }

        private void LeavesGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show(e.Exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DOLCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DOLCheckBox.Checked)
                LeavesGridView.Sort(LeavesGridView.Columns[3], ListSortDirection.Ascending);
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

        private void LeavesForm_Load(object sender, EventArgs e)
        {
            LeavesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds = new DataSet();
                sda.Fill(ds, "Leaves");
                LeavesGridView.DataSource = ds.Tables[0];
            }

            CountRows = LeavesGridView.Rows.Count;
            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;

            foreach (DataGridViewColumn item in LeavesGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            sb = new StringBuilder();
            IDTextBox.Text = "";
            RComboBox.Text = "";
            DOLCheckBox.Checked = false;

            LeavesGridView.ClearSelection();
            Flag = true;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.ReasonsOfLeaving". При необходимости она может быть перемещена или удалена.
            this.reasonsOfLeavingTableAdapter.Fill(this.hRAppDBDataSet.ReasonsOfLeaving);

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if (LeavesGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in this.LeavesGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }
                try
                {
                    result = "ПРИКАЗ \n";
                result += "О прекращении трудового договора с работником (увольнении) \n";
                result += "Номер документа:" + LeavesGridView.CurrentRow.Cells[0].Value.ToString() + "\n";
                result += "Табельный номер: " + LeavesGridView.CurrentRow.Cells[2].Value.ToString() + "\n";
                result += "Уволить" + LeavesGridView.CurrentRow.Cells[3].Value.ToString();
                result += "В связи с" + LeavesGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if (LeavesGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in this.LeavesGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }

                if (MessageBox.Show($"Вы действительно хотите безвозратно удалить выбранную запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Leaves entry = HRAppDBEntities.GetContext().Leaves
                            .Where(o => o.ID_leave == ide).FirstOrDefault();
                        HRAppDBEntities.GetContext().Leaves.Remove(entry);

                        HRAppDBEntities.GetContext().SaveChanges();

                        MessageBox.Show($"Данные удалены!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PageNumber = 0;
                        using (SqlConnection connection = new SqlConnection(connectionstring))
                        {
                            sda = new SqlDataAdapter(GetSql(), connection);
                            ds.Tables["Leaves"].Rows.Clear();
                            sda.Fill(ds, "Leaves");
                        }

                        CountRowsPage = 0;
                        CountRows = LeavesGridView.Rows.Count;

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

        private void LeavesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form form = new AddEditLeavesForm(LeavesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {

                AddEditLeavesForm add = new AddEditLeavesForm();
                add.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LeavesForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}