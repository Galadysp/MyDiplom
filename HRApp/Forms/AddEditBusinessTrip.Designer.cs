namespace HRApp.Forms
{
    partial class AddEditBusinessTrip
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
            System.Windows.Forms.Label dateOfReturningLabel;
            System.Windows.Forms.Label dateOfLeavingLabel;
            System.Windows.Forms.Label reasonOfBusinessTripLabel;
            System.Windows.Forms.Label fundingSourceLabel;
            System.Windows.Forms.Label dateOfTheOrderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditBusinessTrip));
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.businessTripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessTripsTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.BusinessTripsTableAdapter();
            this.iD_BusinessTripsTextBox = new System.Windows.Forms.TextBox();
            this.iD_EmployerTextBox = new System.Windows.Forms.TextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateOfReturningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfLeavingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfTheOrderDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reasonOfBusinessTripTextBox = new System.Windows.Forms.TextBox();
            this.iD_BusinessTripsLabel = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.fundingSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HRApp.HRAppDBDataSetTableAdapters.TableAdapterManager();
            this.fundingSourcesTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.FundingSourcesTableAdapter();
            this.fundingSourceComboBox = new System.Windows.Forms.ComboBox();
            iD_EmployerLabel = new System.Windows.Forms.Label();
            dateOfReturningLabel = new System.Windows.Forms.Label();
            dateOfLeavingLabel = new System.Windows.Forms.Label();
            reasonOfBusinessTripLabel = new System.Windows.Forms.Label();
            fundingSourceLabel = new System.Windows.Forms.Label();
            dateOfTheOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundingSourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_EmployerLabel
            // 
            iD_EmployerLabel.AutoSize = true;
            iD_EmployerLabel.Location = new System.Drawing.Point(7, 62);
            iD_EmployerLabel.Name = "iD_EmployerLabel";
            iD_EmployerLabel.Size = new System.Drawing.Size(255, 18);
            iD_EmployerLabel.TabIndex = 3;
            iD_EmployerLabel.Text = "Табельный номер работника:";
            // 
            // dateOfReturningLabel
            // 
            dateOfReturningLabel.AutoSize = true;
            dateOfReturningLabel.Location = new System.Drawing.Point(227, 164);
            dateOfReturningLabel.Name = "dateOfReturningLabel";
            dateOfReturningLabel.Size = new System.Drawing.Size(28, 18);
            dateOfReturningLabel.TabIndex = 5;
            dateOfReturningLabel.Text = "по";
            // 
            // dateOfLeavingLabel
            // 
            dateOfLeavingLabel.AutoSize = true;
            dateOfLeavingLabel.Location = new System.Drawing.Point(8, 164);
            dateOfLeavingLabel.Name = "dateOfLeavingLabel";
            dateOfLeavingLabel.Size = new System.Drawing.Size(19, 18);
            dateOfLeavingLabel.TabIndex = 7;
            dateOfLeavingLabel.Text = "С";
            // 
            // reasonOfBusinessTripLabel
            // 
            reasonOfBusinessTripLabel.AutoSize = true;
            reasonOfBusinessTripLabel.Location = new System.Drawing.Point(8, 95);
            reasonOfBusinessTripLabel.Name = "reasonOfBusinessTripLabel";
            reasonOfBusinessTripLabel.Size = new System.Drawing.Size(84, 18);
            reasonOfBusinessTripLabel.TabIndex = 9;
            reasonOfBusinessTripLabel.Text = "С целью:";
            // 
            // fundingSourceLabel
            // 
            fundingSourceLabel.AutoSize = true;
            fundingSourceLabel.Location = new System.Drawing.Point(8, 128);
            fundingSourceLabel.Name = "fundingSourceLabel";
            fundingSourceLabel.Size = new System.Drawing.Size(274, 18);
            fundingSourceLabel.TabIndex = 11;
            fundingSourceLabel.Text = "Командировка за счет средств:";
            // 
            // dateOfTheOrderLabel
            // 
            dateOfTheOrderLabel.AutoSize = true;
            dateOfTheOrderLabel.Location = new System.Drawing.Point(9, 197);
            dateOfTheOrderLabel.Name = "dateOfTheOrderLabel";
            dateOfTheOrderLabel.Size = new System.Drawing.Size(165, 18);
            dateOfTheOrderLabel.TabIndex = 13;
            dateOfTheOrderLabel.Text = "Дата составления:";
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessTripsBindingSource
            // 
            this.businessTripsBindingSource.DataMember = "BusinessTrips";
            this.businessTripsBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // businessTripsTableAdapter
            // 
            this.businessTripsTableAdapter.ClearBeforeFill = true;
            // 
            // iD_BusinessTripsTextBox
            // 
            this.iD_BusinessTripsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessTripsBindingSource, "ID_BusinessTrips", true));
            this.iD_BusinessTripsTextBox.Location = new System.Drawing.Point(156, 26);
            this.iD_BusinessTripsTextBox.Name = "iD_BusinessTripsTextBox";
            this.iD_BusinessTripsTextBox.ReadOnly = true;
            this.iD_BusinessTripsTextBox.Size = new System.Drawing.Size(248, 27);
            this.iD_BusinessTripsTextBox.TabIndex = 1;
            this.iD_BusinessTripsTextBox.Visible = false;
            // 
            // iD_EmployerTextBox
            // 
            this.iD_EmployerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessTripsBindingSource, "ID_Employer", true));
            this.iD_EmployerTextBox.Location = new System.Drawing.Point(268, 59);
            this.iD_EmployerTextBox.Name = "iD_EmployerTextBox";
            this.iD_EmployerTextBox.Size = new System.Drawing.Size(136, 27);
            this.iD_EmployerTextBox.TabIndex = 2;
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
            this.TopLabel.TabIndex = 50;
            this.TopLabel.Text = "Заголовок";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fundingSourceComboBox);
            this.groupBox2.Controls.Add(this.dateOfReturningDateTimePicker);
            this.groupBox2.Controls.Add(this.dateOfLeavingDateTimePicker);
            this.groupBox2.Controls.Add(this.dateOfTheOrderDateTimePicker1);
            this.groupBox2.Controls.Add(this.reasonOfBusinessTripTextBox);
            this.groupBox2.Controls.Add(this.iD_BusinessTripsLabel);
            this.groupBox2.Controls.Add(this.LogoBox);
            this.groupBox2.Controls.Add(dateOfTheOrderLabel);
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Controls.Add(this.iD_BusinessTripsTextBox);
            this.groupBox2.Controls.Add(fundingSourceLabel);
            this.groupBox2.Controls.Add(this.iD_EmployerTextBox);
            this.groupBox2.Controls.Add(reasonOfBusinessTripLabel);
            this.groupBox2.Controls.Add(iD_EmployerLabel);
            this.groupBox2.Controls.Add(dateOfLeavingLabel);
            this.groupBox2.Controls.Add(dateOfReturningLabel);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 278);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приказ об направлении работника в командировку";
            // 
            // dateOfReturningDateTimePicker
            // 
            this.dateOfReturningDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessTripsBindingSource, "DateOfReturning", true));
            this.dateOfReturningDateTimePicker.Location = new System.Drawing.Point(261, 158);
            this.dateOfReturningDateTimePicker.Name = "dateOfReturningDateTimePicker";
            this.dateOfReturningDateTimePicker.Size = new System.Drawing.Size(188, 27);
            this.dateOfReturningDateTimePicker.TabIndex = 6;
            // 
            // dateOfLeavingDateTimePicker
            // 
            this.dateOfLeavingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessTripsBindingSource, "DateOfLeaving", true));
            this.dateOfLeavingDateTimePicker.Location = new System.Drawing.Point(33, 158);
            this.dateOfLeavingDateTimePicker.Name = "dateOfLeavingDateTimePicker";
            this.dateOfLeavingDateTimePicker.Size = new System.Drawing.Size(188, 27);
            this.dateOfLeavingDateTimePicker.TabIndex = 5;
            // 
            // dateOfTheOrderDateTimePicker1
            // 
            this.dateOfTheOrderDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessTripsBindingSource, "DateOfTheOrder", true));
            this.dateOfTheOrderDateTimePicker1.Location = new System.Drawing.Point(180, 191);
            this.dateOfTheOrderDateTimePicker1.Name = "dateOfTheOrderDateTimePicker1";
            this.dateOfTheOrderDateTimePicker1.Size = new System.Drawing.Size(190, 27);
            this.dateOfTheOrderDateTimePicker1.TabIndex = 8;
            // 
            // reasonOfBusinessTripTextBox
            // 
            this.reasonOfBusinessTripTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessTripsBindingSource, "ReasonOfBusinessTrip", true));
            this.reasonOfBusinessTripTextBox.Location = new System.Drawing.Point(98, 92);
            this.reasonOfBusinessTripTextBox.Name = "reasonOfBusinessTripTextBox";
            this.reasonOfBusinessTripTextBox.Size = new System.Drawing.Size(484, 27);
            this.reasonOfBusinessTripTextBox.TabIndex = 3;
            // 
            // iD_BusinessTripsLabel
            // 
            this.iD_BusinessTripsLabel.AutoSize = true;
            this.iD_BusinessTripsLabel.Location = new System.Drawing.Point(8, 29);
            this.iD_BusinessTripsLabel.Name = "iD_BusinessTripsLabel";
            this.iD_BusinessTripsLabel.Size = new System.Drawing.Size(142, 18);
            this.iD_BusinessTripsLabel.TabIndex = 56;
            this.iD_BusinessTripsLabel.Text = "Номер приказа:";
            this.iD_BusinessTripsLabel.Visible = false;
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
            this.SaveButton.Location = new System.Drawing.Point(399, 197);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(183, 54);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // fundingSourcesBindingSource
            // 
            this.fundingSourcesBindingSource.DataMember = "FundingSources";
            this.fundingSourcesBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTripsTableAdapter = this.businessTripsTableAdapter;
            this.tableAdapterManager.EducationLevelsTableAdapter = null;
            this.tableAdapterManager.EducationPlacesTableAdapter = null;
            this.tableAdapterManager.EmployeesEducationTableAdapter = null;
            this.tableAdapterManager.EmployeesVacationsTableAdapter = null;
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
            // fundingSourcesTableAdapter
            // 
            this.fundingSourcesTableAdapter.ClearBeforeFill = true;
            // 
            // fundingSourceComboBox
            // 
            this.fundingSourceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessTripsBindingSource, "FundingSource", true));
            this.fundingSourceComboBox.DataSource = this.fundingSourcesBindingSource;
            this.fundingSourceComboBox.DisplayMember = "ID_FundingSource";
            this.fundingSourceComboBox.FormattingEnabled = true;
            this.fundingSourceComboBox.Location = new System.Drawing.Point(288, 125);
            this.fundingSourceComboBox.Name = "fundingSourceComboBox";
            this.fundingSourceComboBox.Size = new System.Drawing.Size(294, 26);
            this.fundingSourceComboBox.TabIndex = 4;
            this.fundingSourceComboBox.ValueMember = "ID_FundingSource";
            // 
            // AddEditBusinessTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 326);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditBusinessTrip";
            this.Text = "Агентство недвижимости ООО \"МегаМир\"";
            this.Load += new System.EventHandler(this.AddEditBusinessTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundingSourcesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource businessTripsBindingSource;
        private HRAppDBDataSetTableAdapters.BusinessTripsTableAdapter businessTripsTableAdapter;
        private System.Windows.Forms.TextBox iD_BusinessTripsTextBox;
        private System.Windows.Forms.TextBox iD_EmployerTextBox;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button SaveButton;
        private HRAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource fundingSourcesBindingSource;
        private HRAppDBDataSetTableAdapters.FundingSourcesTableAdapter fundingSourcesTableAdapter;
        private System.Windows.Forms.Label iD_BusinessTripsLabel;
        private System.Windows.Forms.TextBox reasonOfBusinessTripTextBox;
        private System.Windows.Forms.DateTimePicker dateOfTheOrderDateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateOfReturningDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfLeavingDateTimePicker;
        private System.Windows.Forms.ComboBox fundingSourceComboBox;
    }
}