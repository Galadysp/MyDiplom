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
    public partial class AddEditLeavesForm : Form
    {
        string Flag;
        public AddEditLeavesForm(string Flag = null)
        {
            this.Flag = Flag;
            InitializeComponent();
        }

        private void leavesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leavesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRAppDBDataSet);

        }

        private void AddEditLeavesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.ReasonsOfLeaving". При необходимости она может быть перемещена или удалена.
            this.reasonsOfLeavingTableAdapter.Fill(this.hRAppDBDataSet.ReasonsOfLeaving);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRAppDBDataSet.Leaves". При необходимости она может быть перемещена или удалена.
            this.leavesTableAdapter.Fill(this.hRAppDBDataSet.Leaves);

            if (Flag != null)
            {
                leavesBindingSource.Filter = $"ID_leave='{Flag}'";
                iD_LeavesLabel.Visible = true;
                iD_leaveTextBox.Visible = true;

                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(1);
                dateOfLeavingDateTimePicker.Value = dateOfLeavingDateTimePicker.Value.AddDays(-1);

                TopLabel.Text = "Редактирование записи";
            }
            else
            {
                leavesBindingSource.AddNew();

                dateOfLeavingDateTimePicker.Value = System.DateTime.Today.AddDays(1);
                dateOfLeavingDateTimePicker.Value = System.DateTime.Today.AddDays(-1);
                reasonComboBox.SelectedIndex = -1;

                TopLabel.Text = "Добавление записи";

            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (iD_EmployerTextBox.Text != "" && dateOfLeavingDateTimePicker.Text != "" && reasonComboBox.SelectedValue != "")
            {
                try
                {
                    this.Validate();
                    this.leavesBindingSource.EndEdit();
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
