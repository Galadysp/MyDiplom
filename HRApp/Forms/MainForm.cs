using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using HRApp.Models;
using System.Data.Entity;
using System.IO;

namespace HRApp.Forms
{
    public partial class MainForm : Form
    {
        int PageSize = 10;
        int PageNumber = 0;
        int CountRows = 0;
        int CountRowsPage = 0;
        int NumRows = 0;


        SqlDataAdapter sda;
        DataSet ds;
        StringBuilder sb = new StringBuilder();
        string connectionstring = @"workstation id=HRAppDB.mssql.somee.com;packet size = 4096; user id = galadysp_SQLLogin_4; pwd=5gephl2yz4;data source = HRAppDB.mssql.somee.com; persist security info=False;initial catalog = HRAppDB";

        public MainForm()
        {
            InitializeComponent();
            EmployeeGridView.ClearSelection();
        }
        private string GetSql()
        {
            return $"SELECT * FROM Employee {sb.ToString()} " + $"ORDER BY ID_Employer OFFSET ((" + PageNumber + ") * " + PageSize + ") " + "ROWS FETCH NEXT " + PageSize + "ROWS ONLY";
        }
        private int GetSqlCount()
        {
            int numRows;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = $"SELECT count(*) FROM Employee {sb.ToString()}";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                numRows = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return numRows;
        }

        bool Flag = false;

        public void UpdateFilter()
        {
            try
            {
                sb = new StringBuilder("WHERE ");
                if (GenderComboBox.Text != "")
                    sb.Append($"Gender = '{GenderComboBox.Text}'");
                else
                    sb.Append($"Gender is not null");

                if (FNTextBox.Text != "")
                    sb.Append($" AND F_Name = '{FNTextBox.Text}'");
                else
                    sb.Append($" AND F_Name is not null");

                if (SNTextBox.Text != "")
                    sb.Append($" AND S_Name = '{SNTextBox.Text}'");
                else
                    sb.Append($" AND S_Name is not null");

                if (PNTextBox.Text != "")
                    sb.Append($" AND Patronymic = '{PNTextBox.Text}'");
                else
                    sb.Append($" AND Patronymic is not null");

                if (PositionComboBox.SelectedValue != "")
                    sb.Append($" AND Position = '{PositionComboBox.SelectedValue}'");
                else
                    sb.Append($" AND Position is not null");

                if (WCheckBox.Checked)
                    sb.Append($" AND IsWorker = '0'");
                else
                    sb.Append($" AND IsWorker is not null");

                if (RCheckBox.Checked)
                    sb.Append($" AND IsRetiree = '1'");
                else
                    sb.Append($" AND IsRetiree is not null");

                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["Employee"].Rows.Clear();
                    sda.Fill(ds, "Employee");
                }

                CountRowsPage = 0;
                CountRows = EmployeeGridView.Rows.Count;

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
                ds.Tables["Employee"].Rows.Clear();
                sda.Fill(ds, "Employee");
            }
            CountRowsPage = 0;
            CountRows = EmployeeGridView.Rows.Count;

            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EmployeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds = new DataSet();
                sda.Fill(ds, "Employee");
                EmployeeGridView.DataSource = ds.Tables[0];
            }

            CountRows = EmployeeGridView.Rows.Count;
            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;

            foreach (DataGridViewColumn item in EmployeeGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.hRAppDBDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.hRAppDBDataSet.Positions);
            sb = new StringBuilder();
            FNTextBox.Text = "";
            SNTextBox.Text = "";
            PNTextBox.Text = "";
            GenderComboBox.Text = "";
            PositionComboBox.Text = "";
            WCheckBox.Checked = false;
            RCheckBox.Checked = false;

            EmployeeGridView.ClearSelection();
            Flag = true;

        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void FNTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void SNTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void PNTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder("");
            FNTextBox.Text = "";
            SNTextBox.Text = "";
            PNTextBox.Text = "";
            GenderComboBox.Text = "";
            PositionComboBox.Text = "";
            WCheckBox.Checked = false;
            RCheckBox.Checked = false;

            Clear();
        }

        private void PervButton_Click(object sender, EventArgs e)
        {
            if (PageNumber == 0) return;
            PageNumber--;

            CountRowsPage = EmployeeGridView.Rows.Count;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Employee"].Rows.Clear();
                sda.Fill(ds, "Employee");
            }
            if (EmployeeGridView.Rows.Count != 0)
            {
                if (PageNumber >= 0 && Flag)
                    CountRows -= CountRowsPage;
                CountRowsPage = EmployeeGridView.Rows.Count;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Employee"].Rows.Count < PageSize) return;
            PageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Employee"].Rows.Clear();
                sda.Fill(ds, "Employee");
            }
            if (EmployeeGridView.Rows.Count != 0 && Flag)
            {
                CountRowsPage = EmployeeGridView.Rows.Count;
                CountRows += CountRowsPage;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void EmployeeGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show(e.Exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilter();

        }

        private void RCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ide = 0;
            if(EmployeeGridView.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow item in this.EmployeeGridView.SelectedRows)
                {
                    ide = Convert.ToInt32(item.Cells[0].Value);
                }

                if(MessageBox.Show($"Вы действительно хотите безвозратно удалить выбранную запись?", "Удаление",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Employee entry = HRAppDBEntities.GetContext().Employee
                            .Where(o => o.ID_Employer == ide).FirstOrDefault();
                        HRAppDBEntities.GetContext().Employee.Remove(entry);

                        HRAppDBEntities.GetContext().SaveChanges();

                        MessageBox.Show($"Данные удаелны!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PageNumber = 0;
                        using (SqlConnection connection = new SqlConnection(connectionstring))
                        {
                            sda = new SqlDataAdapter(GetSql(), connection);
                            ds.Tables["Employee"].Rows.Clear();
                            sda.Fill(ds, "Employee");
                        }

                        CountRowsPage = 0;
                        CountRows = EmployeeGridView.Rows.Count;

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

        private void EmployeeGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form form = new AddEditEmloyer(EmployeeGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.ShowDialog();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {

                AddEditEmloyer add = new AddEditEmloyer();
                add.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
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
