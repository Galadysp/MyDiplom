using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApp.Forms
{
    public partial class AddEditEmloyeesVacation : Form
    {
        string Flag;
        public AddEditEmloyeesVacation(string flag = null)
        {
            this.Flag = flag;
            InitializeComponent();
        }

        private void employeesVacationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesVacationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRAppDBDataSet);

        }

        private void AddEditEmloyeesVacation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.VacationsType". При необходимости она может быть перемещена или удалена.
            this.vacationsTypeTableAdapter.Fill(this.hRAppDBDataSet.VacationsType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.EmployeesVacations". При необходимости она может быть перемещена или удалена.
            this.employeesVacationsTableAdapter.Fill(this.hRAppDBDataSet.EmployeesVacations);

            if (Flag != null)
            {
                employeesVacationsBindingSource.Filter = $"ID_Vacation='{Flag}'";
                iD_VacationTextBox.Visible = true;
                ID_VacationLabel.Visible = true;

                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(1);
                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(-1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(-1);
                dateOfTheOrderDateTimePicker.Value = dateOfTheOrderDateTimePicker.Value.AddDays(1);
                dateOfTheOrderDateTimePicker.Value = dateOfTheOrderDateTimePicker.Value.AddDays(-1);

                TopLabel.Text = "Редактирование записи";
            }
            else
            {
                employeesVacationsBindingSource.AddNew();

                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(1);
                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(-1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(-1);
                dateOfTheOrderDateTimePicker.Value = System.DateTime.Today.AddDays(1);
                dateOfTheOrderDateTimePicker.Value = System.DateTime.Today.AddDays(-1);
                vacationTypeComboBox.SelectedIndex = -1;

                TopLabel.Text = "Добавление записи";

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (iD_EmployerTextBox.Text != "" && vacationTypeComboBox.Text != "" && dateOfLeavingDateTimePicker.Text != "" && dateOfReturningDateTimePicker.Text != "" && dateOfTheOrderDateTimePicker.Text != "")
            {
                try
                {
                    this.Validate();
                    this.employeesVacationsBindingSource.EndEdit();
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
