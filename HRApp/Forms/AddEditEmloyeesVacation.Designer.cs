namespace HRApp.Forms
{
    partial class AddEditEmloyeesVacation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_EmployerLabel;
            System.Windows.Forms.Label dateOfTheOrderLabel;
            System.Windows.Forms.Label dateOfReturningLabel;
            System.Windows.Forms.Label dateOfLeavingLabel;
            System.Windows.Forms.Label vacationTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditEmloyeesVacation));
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.employeesVacationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesVacationsTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.EmployeesVacationsTableAdapter();
            this.tableAdapterManager = new HRApp.HRAppDBDataSetTableAdapters.TableAdapterManager();
            this.iD_EmployerTextBox = new System.Windows.Forms.TextBox();
            this.dateOfTheOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfReturningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfLeavingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vacationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.vacationsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TopLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ID_VacationLabel = new System.Windows.Forms.Label();
            this.iD_VacationTextBox = new System.Windows.Forms.TextBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.vacationsTypeTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.VacationsTypeTableAdapter();
            iD_EmployerLabel = new System.Windows.Forms.Label();
            dateOfTheOrderLabel = new System.Windows.Forms.Label();
            dateOfReturningLabel = new System.Windows.Forms.Label();
            dateOfLeavingLabel = new System.Windows.Forms.Label();
            vacationTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesVacationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationsTypeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_EmployerLabel
            // 
            iD_EmployerLabel.AutoSize = true;
            iD_EmployerLabel.Location = new System.Drawing.Point(8, 62);
            iD_EmployerLabel.Name = "iD_EmployerLabel";
            iD_EmployerLabel.Size = new System.Drawing.Size(255, 18);
            iD_EmployerLabel.TabIndex = 3;
            iD_EmployerLabel.Text = "Табельный номер работника:";
            // 
            // dateOfTheOrderLabel
            // 
            dateOfTheOrderLabel.AutoSize = true;
            dateOfTheOrderLabel.Location = new System.Drawing.Point(9, 163);
            dateOfTheOrderLabel.Name = "dateOfTheOrderLabel";
            dateOfTheOrderLabel.Size = new System.Drawing.Size(165, 18);
            dateOfTheOrderLabel.TabIndex = 5;
            dateOfTheOrderLabel.Text = "Дата составления:";
            // 
            // dateOfReturningLabel
            // 
            dateOfReturningLabel.AutoSize = true;
            dateOfReturningLabel.Location = new System.Drawing.Point(227, 130);
            dateOfReturningLabel.Name = "dateOfReturningLabel";
            dateOfReturningLabel.Size = new System.Drawing.Size(28, 18);
            dateOfReturningLabel.TabIndex = 7;
            dateOfReturningLabel.Text = "по";
            // 
            // dateOfLeavingLabel
            // 
            dateOfLeavingLabel.AutoSize = true;
            dateOfLeavingLabel.Location = new System.Drawing.Point(9, 130);
            dateOfLeavingLabel.Name = "dateOfLeavingLabel";
            dateOfLeavingLabel.Size = new System.Drawing.Size(19, 18);
            dateOfLeavingLabel.TabIndex = 9;
            dateOfLeavingLabel.Text = "С";
            // 
            // vacationTypeLabel
            // 
            vacationTypeLabel.AutoSize = true;
            vacationTypeLabel.Location = new System.Drawing.Point(9, 95);
            vacationTypeLabel.Name = "vacationTypeLabel";
            vacationTypeLabel.Size = new System.Drawing.Size(72, 18);
            vacationTypeLabel.TabIndex = 11;
            vacationTypeLabel.Text = "Отпуск:";
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesVacationsBindingSource
            // 
            this.employeesVacationsBindingSource.DataMember = "EmployeesVacations";
            this.employeesVacationsBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // employeesVacationsTableAdapter
            // 
            this.employeesVacationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTripsTableAdapter = null;
            this.tableAdapterManager.EducationLevelsTableAdapter = null;
            this.tableAdapterManager.EducationPlacesTableAdapter = null;
            this.tableAdapterManager.EmployeesEducationTableAdapter = null;
            this.tableAdapterManager.EmployeesVacationsTableAdapter = this.employeesVacationsTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FundingSourcesTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.HoursTableAdapter = null;
            this.tableAdapterManager.LeavesTableAdapter = null;
            this.tableAdapterManager.MajorsTableAdapter = null;
            this.tableAdapterManager.MaritalStatusesTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.ReasonsOfLeavingTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HRApp.HRAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VacationsTypeTableAdapter = null;
            // 
            // iD_EmployerTextBox
            // 
            this.iD_EmployerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesVacationsBindingSource, "ID_Employer", true));
            this.iD_EmployerTextBox.Location = new System.Drawing.Point(269, 59);
            this.iD_EmployerTextBox.Name = "iD_EmployerTextBox";
            this.iD_EmployerTextBox.Size = new System.Drawing.Size(135, 27);
            this.iD_EmployerTextBox.TabIndex = 4;
            // 
            // dateOfTheOrderDateTimePicker
            // 
            this.dateOfTheOrderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesVacationsBindingSource, "ID_Vacation", true));
            this.dateOfTheOrderDateTimePicker.Location = new System.Drawing.Point(180, 157);
            this.dateOfTheOrderDateTimePicker.Name = "dateOfTheOrderDateTimePicker";
            this.dateOfTheOrderDateTimePicker.Size = new System.Drawing.Size(191, 27);
            this.dateOfTheOrderDateTimePicker.TabIndex = 6;
            // 
            // dateOfReturningDateTimePicker
            // 
            this.dateOfReturningDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesVacationsBindingSource, "DateOfReturning", true));
            this.dateOfReturningDateTimePicker.Location = new System.Drawing.Point(261, 124);
            this.dateOfReturningDateTimePicker.Name = "dateOfReturningDateTimePicker";
            this.dateOfReturningDateTimePicker.Size = new System.Drawing.Size(188, 27);
            this.dateOfReturningDateTimePicker.TabIndex = 8;
            // 
            // dateOfLeavingDateTimePicker
            // 
            this.dateOfLeavingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesVacationsBindingSource, "DateOfLeaving", true));
            this.dateOfLeavingDateTimePicker.Location = new System.Drawing.Point(34, 124);
            this.dateOfLeavingDateTimePicker.Name = "dateOfLeavingDateTimePicker";
            this.dateOfLeavingDateTimePicker.Size = new System.Drawing.Size(187, 27);
            this.dateOfLeavingDateTimePicker.TabIndex = 10;
            // 
            // vacationTypeComboBox
            // 
            this.vacationTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesVacationsBindingSource, "VacationType", true));
            this.vacationTypeComboBox.DataSource = this.vacationsTypeBindingSource;
            this.vacationTypeComboBox.DisplayMember = "ID_VacationType";
            this.vacationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vacationTypeComboBox.FormattingEnabled = true;
            this.vacationTypeComboBox.Location = new System.Drawing.Point(87, 92);
            this.vacationTypeComboBox.Name = "vacationTypeComboBox";
            this.vacationTypeComboBox.Size = new System.Drawing.Size(495, 26);
            this.vacationTypeComboBox.TabIndex = 12;
            this.vacationTypeComboBox.ValueMember = "ID_VacationType";
            // 
            // vacationsTypeBindingSource
            // 
            this.vacationsTypeBindingSource.DataMember = "VacationsType";
            this.vacationsTypeBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.TopLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TopLabel.Location = new System.Drawing.Point(12, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(150, 28);
            this.TopLabel.TabIndex = 52;
            this.TopLabel.Text = "Заголовок";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ID_VacationLabel);
            this.groupBox2.Controls.Add(this.iD_VacationTextBox);
            this.groupBox2.Controls.Add(vacationTypeLabel);
            this.groupBox2.Controls.Add(this.vacationTypeComboBox);
            this.groupBox2.Controls.Add(this.LogoBox);
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Controls.Add(this.dateOfLeavingDateTimePicker);
            this.groupBox2.Controls.Add(dateOfLeavingLabel);
            this.groupBox2.Controls.Add(this.dateOfReturningDateTimePicker);
            this.groupBox2.Controls.Add(dateOfReturningLabel);
            this.groupBox2.Controls.Add(dateOfTheOrderLabel);
            this.groupBox2.Controls.Add(this.dateOfTheOrderDateTimePicker);
            this.groupBox2.Controls.Add(iD_EmployerLabel);
            this.groupBox2.Controls.Add(this.iD_EmployerTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 225);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приказ о предоставлении отпуска работнику";
            // 
            // ID_VacationLabel
            // 
            this.ID_VacationLabel.AutoSize = true;
            this.ID_VacationLabel.Location = new System.Drawing.Point(9, 29);
            this.ID_VacationLabel.Name = "ID_VacationLabel";
            this.ID_VacationLabel.Size = new System.Drawing.Size(142, 18);
            this.ID_VacationLabel.TabIndex = 46;
            this.ID_VacationLabel.Text = "Номер приказа:";
            this.ID_VacationLabel.Visible = false;
            // 
            // iD_VacationTextBox
            // 
            this.iD_VacationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesVacationsBindingSource, "ID_Vacation", true));
            this.iD_VacationTextBox.Location = new System.Drawing.Point(156, 26);
            this.iD_VacationTextBox.Name = "iD_VacationTextBox";
            this.iD_VacationTextBox.ReadOnly = true;
            this.iD_VacationTextBox.Size = new System.Drawing.Size(248, 27);
            this.iD_VacationTextBox.TabIndex = 45;
            this.iD_VacationTextBox.Visible = false;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(410, 16);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(172, 70);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 44;
            this.LogoBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(399, 157);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(183, 54);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // vacationsTypeTableAdapter
            // 
            this.vacationsTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditEmloyeesVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 281);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditEmloyeesVacation";
            this.Text = "Агентство недвижимости ООО \"МегаМир\"";
            this.Load += new System.EventHandler(this.AddEditEmloyeesVacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesVacationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationsTypeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource employeesVacationsBindingSource;
        private HRAppDBDataSetTableAdapters.EmployeesVacationsTableAdapter employeesVacationsTableAdapter;
        private HRAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_EmployerTextBox;
        private System.Windows.Forms.DateTimePicker dateOfTheOrderDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfReturningDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfLeavingDateTimePicker;
        private System.Windows.Forms.ComboBox vacationTypeComboBox;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox iD_VacationTextBox;
        private System.Windows.Forms.Label ID_VacationLabel;
        private System.Windows.Forms.BindingSource vacationsTypeBindingSource;
        private HRAppDBDataSetTableAdapters.VacationsTypeTableAdapter vacationsTypeTableAdapter;
    }
}