using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HRApp.Forms
{
    
    public partial class AddEditEmloyer : Form
    {
        string Flag;
        public AddEditEmloyer(string Flag = null)
        {
            this.Flag = Flag;
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRAppDBDataSet);

        }

        private void AddEditEmloyer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Hours". При необходимости она может быть перемещена или удалена.
            this.hoursTableAdapter.Fill(this.hRAppDBDataSet.Hours);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.States". При необходимости она может быть перемещена или удалена.
            this.statesTableAdapter.Fill(this.hRAppDBDataSet.States);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.MaritalStatuses". При необходимости она может быть перемещена или удалена.
            this.maritalStatusesTableAdapter.Fill(this.hRAppDBDataSet.MaritalStatuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.hRAppDBDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.hRAppDBDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRAppDBDataSet.Employee);
            if (Flag != null)
            {
                employeeBindingSource.Filter = $"ID_Employer='{Flag}'";
                iD_EmployerTextBox.Visible = true;
                iD_EmployerLabel.Visible = true;

                dateOfBirthDateTimePicker.Value = dateOfBirthDateTimePicker.Value.AddDays(1);
                dateOfBirthDateTimePicker.Value = dateOfBirthDateTimePicker.Value.AddDays(-1);
                dateOfEmploymentDateTimePicker.Value = dateOfEmploymentDateTimePicker.Value.AddDays(1);
                dateOfEmploymentDateTimePicker.Value = dateOfEmploymentDateTimePicker.Value.AddDays(-1);

                bool curFile = File.Exists(profilePictureTextBox.Text.ToString());

                if (curFile)
                    PictureBox.Image = System.Drawing.Image.FromFile(profilePictureTextBox.Text.ToString());

                TopLabel.Text = "Редактирование работника";
            }
            else
            {
                employeeBindingSource.AddNew();

                dateOfBirthDateTimePicker.Value = dateOfBirthDateTimePicker.Value.AddDays(1);
                dateOfBirthDateTimePicker.Value = dateOfBirthDateTimePicker.Value.AddDays(-1);
                dateOfEmploymentDateTimePicker.Value = System.DateTime.Today.AddDays(1);
                dateOfEmploymentDateTimePicker.Value = System.DateTime.Today.AddDays(-1);
                genderComboBox.SelectedIndex = -1;

                TopLabel.Text = "Добавление работника";

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (s_NameTextBox.Text != "" && f_NameTextBox.Text != "" && dateOfBirthDateTimePicker.Text != "" && maritalStatusComboBox.Text != "" && positionComboBox.Text != "" && placeOfBirthComboBox.Text != "" && hourComboBox.Text != "" && salaryTextBox.Text != "")
            {
                try
                {
                    this.Validate();
                    this.employeeBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.hRAppDBDataSet);
                    MessageBox.Show("Изменения успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Обязательные поля не были заполнены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
