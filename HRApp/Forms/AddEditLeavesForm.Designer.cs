namespace HRApp.Forms
{
    partial class AddEditLeavesForm
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
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label dateOfLeavingLabel;
            System.Windows.Forms.Label iDEmployerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditLeavesForm));
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.leavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leavesTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.LeavesTableAdapter();
            this.tableAdapterManager = new HRApp.HRAppDBDataSetTableAdapters.TableAdapterManager();
            this.reasonsOfLeavingTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.ReasonsOfLeavingTableAdapter();
            this.iD_leaveTextBox = new System.Windows.Forms.TextBox();
            this.reasonComboBox = new System.Windows.Forms.ComboBox();
            this.reasonsOfLeavingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_EmployerTextBox = new System.Windows.Forms.TextBox();
            this.dateOfLeavingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TopLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iD_LeavesLabel = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            reasonLabel = new System.Windows.Forms.Label();
            dateOfLeavingLabel = new System.Windows.Forms.Label();
            iDEmployerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonsOfLeavingBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(9, 128);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(88, 18);
            reasonLabel.TabIndex = 3;
            reasonLabel.Text = "В связи с";
            // 
            // dateOfLeavingLabel
            // 
            dateOfLeavingLabel.AutoSize = true;
            dateOfLeavingLabel.Location = new System.Drawing.Point(9, 98);
            dateOfLeavingLabel.Name = "dateOfLeavingLabel";
            dateOfLeavingLabel.Size = new System.Drawing.Size(75, 18);
            dateOfLeavingLabel.TabIndex = 7;
            dateOfLeavingLabel.Text = "Уволить";
            // 
            // iDEmployerLabel
            // 
            iDEmployerLabel.AutoSize = true;
            iDEmployerLabel.Location = new System.Drawing.Point(9, 62);
            iDEmployerLabel.Name = "iDEmployerLabel";
            iDEmployerLabel.Size = new System.Drawing.Size(255, 18);
            iDEmployerLabel.TabIndex = 3;
            iDEmployerLabel.Text = "Табельный номер работника:";
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leavesBindingSource
            // 
            this.leavesBindingSource.DataMember = "Leaves";
            this.leavesBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // leavesTableAdapter
            // 
            this.leavesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTripsTableAdapter = null;
            this.tableAdapterManager.EducationLevelsTableAdapter = null;
            this.tableAdapterManager.EducationPlacesTableAdapter = null;
            this.tableAdapterManager.EmployeesEducationTableAdapter = null;
            this.tableAdapterManager.EmployeesVacationsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FundingSourcesTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.HoursTableAdapter = null;
            this.tableAdapterManager.LeavesTableAdapter = this.leavesTableAdapter;
            this.tableAdapterManager.MajorsTableAdapter = null;
            this.tableAdapterManager.MaritalStatusesTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.ReasonsOfLeavingTableAdapter = this.reasonsOfLeavingTableAdapter;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HRApp.HRAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VacationsTypeTableAdapter = null;
            // 
            // reasonsOfLeavingTableAdapter
            // 
            this.reasonsOfLeavingTableAdapter.ClearBeforeFill = true;
            // 
            // iD_leaveTextBox
            // 
            this.iD_leaveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leavesBindingSource, "ID_leave", true));
            this.iD_leaveTextBox.Location = new System.Drawing.Point(155, 26);
            this.iD_leaveTextBox.Name = "iD_leaveTextBox";
            this.iD_leaveTextBox.ReadOnly = true;
            this.iD_leaveTextBox.Size = new System.Drawing.Size(263, 27);
            this.iD_leaveTextBox.TabIndex = 2;
            this.iD_leaveTextBox.Visible = false;
            // 
            // reasonComboBox
            // 
            this.reasonComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leavesBindingSource, "Reason", true));
            this.reasonComboBox.DataSource = this.reasonsOfLeavingBindingSource;
            this.reasonComboBox.DisplayMember = "Reason";
            this.reasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonComboBox.FormattingEnabled = true;
            this.reasonComboBox.Location = new System.Drawing.Point(103, 125);
            this.reasonComboBox.Name = "reasonComboBox";
            this.reasonComboBox.Size = new System.Drawing.Size(315, 26);
            this.reasonComboBox.TabIndex = 4;
            this.reasonComboBox.ValueMember = "ID_Reason";
            // 
            // reasonsOfLeavingBindingSource
            // 
            this.reasonsOfLeavingBindingSource.DataMember = "ReasonsOfLeaving";
            this.reasonsOfLeavingBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // iD_EmployerTextBox
            // 
            this.iD_EmployerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leavesBindingSource, "ID_Employer", true));
            this.iD_EmployerTextBox.Location = new System.Drawing.Point(268, 59);
            this.iD_EmployerTextBox.Name = "iD_EmployerTextBox";
            this.iD_EmployerTextBox.Size = new System.Drawing.Size(150, 27);
            this.iD_EmployerTextBox.TabIndex = 6;
            // 
            // dateOfLeavingDateTimePicker
            // 
            this.dateOfLeavingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leavesBindingSource, "DateOfLeaving", true));
            this.dateOfLeavingDateTimePicker.Location = new System.Drawing.Point(90, 92);
            this.dateOfLeavingDateTimePicker.Name = "dateOfLeavingDateTimePicker";
            this.dateOfLeavingDateTimePicker.Size = new System.Drawing.Size(328, 27);
            this.dateOfLeavingDateTimePicker.TabIndex = 8;
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
            this.groupBox2.Controls.Add(this.iD_LeavesLabel);
            this.groupBox2.Controls.Add(this.dateOfLeavingDateTimePicker);
            this.groupBox2.Controls.Add(reasonLabel);
            this.groupBox2.Controls.Add(dateOfLeavingLabel);
            this.groupBox2.Controls.Add(this.reasonComboBox);
            this.groupBox2.Controls.Add(this.LogoBox);
            this.groupBox2.Controls.Add(this.iD_EmployerTextBox);
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Controls.Add(this.iD_leaveTextBox);
            this.groupBox2.Controls.Add(iDEmployerLabel);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 159);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приказ об увольнении работника";
            // 
            // iD_LeavesLabel
            // 
            this.iD_LeavesLabel.AutoSize = true;
            this.iD_LeavesLabel.Location = new System.Drawing.Point(8, 29);
            this.iD_LeavesLabel.Name = "iD_LeavesLabel";
            this.iD_LeavesLabel.Size = new System.Drawing.Size(142, 18);
            this.iD_LeavesLabel.TabIndex = 56;
            this.iD_LeavesLabel.Text = "Номер приказа:";
            this.iD_LeavesLabel.Visible = false;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(424, 16);
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
            this.SaveButton.Location = new System.Drawing.Point(424, 98);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(172, 54);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddEditLeavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 214);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditLeavesForm";
            this.Text = "Агентство недвижимости ООО \"МегаМир\"";
            this.Load += new System.EventHandler(this.AddEditLeavesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonsOfLeavingBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource leavesBindingSource;
        private HRAppDBDataSetTableAdapters.LeavesTableAdapter leavesTableAdapter;
        private HRAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_leaveTextBox;
        private System.Windows.Forms.ComboBox reasonComboBox;
        private System.Windows.Forms.TextBox iD_EmployerTextBox;
        private System.Windows.Forms.DateTimePicker dateOfLeavingDateTimePicker;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label iD_LeavesLabel;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button SaveButton;
        private HRAppDBDataSetTableAdapters.ReasonsOfLeavingTableAdapter reasonsOfLeavingTableAdapter;
        private System.Windows.Forms.BindingSource reasonsOfLeavingBindingSource;
    }
}