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

namespace HRApp.Forms
{
    public partial class EmployeesEducationForm : Form
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

        public EmployeesEducationForm()
        {
            InitializeComponent();
            EmployeesEducationFormGridView.ClearSelection();
        }
        private string GetSql()
        {
            return $"SELECT * FROM EmployeesEducation {sb.ToString()} " + $"ORDER BY Employer OFFSET ((" + PageNumber + ") * " + PageSize + ") " + "ROWS FETCH NEXT " + PageSize + "ROWS ONLY";
        }
        private int GetSqlCount()
        {
            int numRows;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = $"SELECT count(*) FROM EmployeesEducation {sb.ToString()}";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                numRows = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return numRows;
        }

        bool Flag = false;
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ds.Tables["EmployeesEducation"].Rows.Count < PageSize) return;
            PageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["EmployeesEducation"].Rows.Clear();
                sda.Fill(ds, "EmployeesEducation");
            }
            if (EmployeesEducationFormGridView.Rows.Count != 0 && Flag)
            {
                CountRowsPage = EmployeesEducationFormGridView.Rows.Count;
                CountRows += CountRowsPage;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        private void PervButton_Click(object sender, EventArgs e)
        {
            if (PageNumber == 0) return;
            PageNumber--;

            CountRowsPage = EmployeesEducationFormGridView.Rows.Count;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["EmployeesEducation"].Rows.Clear();
                sda.Fill(ds, "EmployeesEducation");
            }
            if (EmployeesEducationFormGridView.Rows.Count != 0)
            {
                if (PageNumber >= 0 && Flag)
                    CountRows -= CountRowsPage;
                CountRowsPage = EmployeesEducationFormGridView.Rows.Count;
                NumRows = GetSqlCount();

                PageLabel.Text = CountRows + " из " + NumRows;
            }
        }

        public void Clear()
        {
            PageNumber = 0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["EmployeesEducation"].Rows.Clear();
                sda.Fill(ds, "EmployeesEducation");
            }
            CountRowsPage = 0;
            CountRows = EmployeesEducationFormGridView.Rows.Count;

            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder("");
            IDTextBox.Text = "";
            ELComboBox.Text = "";
            WithHonorCheckBox.Checked = false;

            Clear();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void EmployeesEducationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.EducationPlaces". При необходимости она может быть перемещена или удалена.
            this.educationPlacesTableAdapter.Fill(this.hRAppDBDataSet.EducationPlaces);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.EmployeesEducation". При необходимости она может быть перемещена или удалена.
            this.employeesEducationTableAdapter.Fill(this.hRAppDBDataSet.EmployeesEducation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Majors". При необходимости она может быть перемещена или удалена.
            this.majorsTableAdapter.Fill(this.hRAppDBDataSet.Majors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.EducationLevels". При необходимости она может быть перемещена или удалена.
            this.educationLevelsTableAdapter.Fill(this.hRAppDBDataSet.EducationLevels);
            EmployeesEducationFormGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                sda = new SqlDataAdapter(GetSql(), connection);
                ds = new DataSet();
                sda.Fill(ds, "EmployeesEducation");
                EmployeesEducationFormGridView.DataSource = ds.Tables[0];
            }

            CountRows = EmployeesEducationFormGridView.Rows.Count;
            NumRows = GetSqlCount();
            PageLabel.Text = CountRows + " из " + NumRows;

            foreach (DataGridViewColumn item in EmployeesEducationFormGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            sb = new StringBuilder();
            IDTextBox.Text = "";
            ELComboBox.Text = "";
            WithHonorCheckBox.Checked = false;

            EmployeesEducationFormGridView.ClearSelection();
            Flag = true;

        }

        private void EmployeesEducationForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sb = new StringBuilder("WHERE ");
                if (IDTextBox.Text != "")
                    sb.Append($"Employer = '{IDTextBox.Text}'");
                else
                    sb.Append($"Employer is not null");


                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["EmployeesEducation"].Rows.Clear();
                    sda.Fill(ds, "EmployeesEducation");
                }

                CountRowsPage = 0;
                CountRows = EmployeesEducationFormGridView.Rows.Count;

                NumRows = GetSqlCount();
                PageLabel.Text = CountRows + " из " + NumRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ELComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sb = new StringBuilder("WHERE ");
                if (ELComboBox.SelectedValue != "")
                    sb.Append($"Major = '{ELComboBox.SelectedValue}'");
                else
                    sb.Append($"Major is not null");
                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["EmployeesEducation"].Rows.Clear();
                    sda.Fill(ds, "EmployeesEducation");
                }

                CountRowsPage = 0;
                CountRows = EmployeesEducationFormGridView.Rows.Count;

                NumRows = GetSqlCount();
                PageLabel.Text = CountRows + " из " + NumRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void WithHonorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                sb = new StringBuilder("WHERE ");
                if (WithHonorCheckBox.Checked)
                sb.Append($"WithHonors = 'true'");
            else
                sb.Append($"WithHonors is not null");
                PageNumber = 0;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    sda = new SqlDataAdapter(GetSql(), connection);
                    ds.Tables["EmployeesEducation"].Rows.Clear();
                    sda.Fill(ds, "EmployeesEducation");
                }

                CountRowsPage = 0;
                CountRows = EmployeesEducationFormGridView.Rows.Count;

                NumRows = GetSqlCount();
                PageLabel.Text = CountRows + " из " + NumRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

