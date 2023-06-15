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
    public partial class AddEditBusinessTrip : Form
    {
        string Flag;
        public AddEditBusinessTrip(string flag = null)
        {
            this.Flag = flag;
            InitializeComponent();
        }

        private void businessTripsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessTripsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRAppDBDataSet);

        }

        private void AddEditBusinessTrip_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.FundingSources". При необходимости она может быть перемещена или удалена.
            this.fundingSourcesTableAdapter.Fill(this.hRAppDBDataSet.FundingSources);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.BusinessTrips". При необходимости она может быть перемещена или удалена.
            this.businessTripsTableAdapter.Fill(this.hRAppDBDataSet.BusinessTrips);

            if (Flag != null)
            {
                businessTripsBindingSource.Filter = $"ID_BusinessTrips='{Flag}'";
                iD_BusinessTripsTextBox.Visible = true;
                iD_BusinessTripsLabel.Visible = true;

                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(1);
                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(-1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(-1);
                dateOfTheOrderDateTimePicker1.Value = dateOfTheOrderDateTimePicker1.Value.AddDays(1);
                dateOfTheOrderDateTimePicker1.Value = dateOfTheOrderDateTimePicker1.Value.AddDays(-1);

                TopLabel.Text = "Редактирование записи";
            }
            else
            {
                businessTripsBindingSource.AddNew();

                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(1);
                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(-1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(1);
                dateOfReturningDateTimePicker.Value = dateOfReturningDateTimePicker.Value.AddDays(-1);
                dateOfTheOrderDateTimePicker1.Value = System.DateTime.Today.AddDays(1);
                dateOfTheOrderDateTimePicker1.Value = System.DateTime.Today.AddDays(-1);
                fundingSourceComboBox.SelectedIndex = -1;

                TopLabel.Text = "Добавление записи";

            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (iD_EmployerTextBox.Text != "" && reasonOfBusinessTripTextBox.Text != "" && fundingSourceComboBox.Text != "" && dateOfLeavingDateTimePicker.Text != "" && dateOfReturningDateTimePicker.Text != "" && dateOfTheOrderDateTimePicker1.Text != "")
            {
                try
                {
                    this.Validate();
                    this.businessTripsBindingSource.EndEdit();
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
