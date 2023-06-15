namespace HRApp.Forms
{
    partial class EmployeesEducationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesEducationForm));
            this.LeavesButton1 = new System.Windows.Forms.Button();
            this.VacationsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.EPGroupBox = new System.Windows.Forms.GroupBox();
            this.majorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ELComboBox = new System.Windows.Forms.ComboBox();
            this.educationLevelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.WithHonorCheckBox = new System.Windows.Forms.CheckBox();
            this.majorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PageLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PervButton = new System.Windows.Forms.Button();
            this.EmployeesEducationFormGridView = new System.Windows.Forms.DataGridView();
            this.BTButton = new System.Windows.Forms.Button();
            this.educationLevelsTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.EducationLevelsTableAdapter();
            this.majorsTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.MajorsTableAdapter();
            this.fKEmployeesEducationEducationLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesEducationTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.EmployeesEducationTableAdapter();
            this.educationPlacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationPlacesTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.EducationPlacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.EPGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesEducationFormGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesEducationEducationLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LeavesButton1
            // 
            this.LeavesButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.LeavesButton1.FlatAppearance.BorderSize = 0;
            this.LeavesButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.LeavesButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeavesButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeavesButton1.ForeColor = System.Drawing.Color.White;
            this.LeavesButton1.Location = new System.Drawing.Point(692, 226);
            this.LeavesButton1.Name = "LeavesButton1";
            this.LeavesButton1.Size = new System.Drawing.Size(156, 84);
            this.LeavesButton1.TabIndex = 61;
            this.LeavesButton1.Text = "Увольнения";
            this.LeavesButton1.UseVisualStyleBackColor = false;
            this.LeavesButton1.Click += new System.EventHandler(this.LeavesButton1_Click);
            // 
            // VacationsButton
            // 
            this.VacationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.VacationsButton.FlatAppearance.BorderSize = 0;
            this.VacationsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.VacationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VacationsButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacationsButton.ForeColor = System.Drawing.Color.White;
            this.VacationsButton.Location = new System.Drawing.Point(692, 322);
            this.VacationsButton.Name = "VacationsButton";
            this.VacationsButton.Size = new System.Drawing.Size(156, 84);
            this.VacationsButton.TabIndex = 60;
            this.VacationsButton.Text = "Отпуска";
            this.VacationsButton.UseVisualStyleBackColor = false;
            this.VacationsButton.Click += new System.EventHandler(this.VacationsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(692, 514);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(155, 53);
            this.ExitButton.TabIndex = 59;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(692, 13);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(156, 111);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 58;
            this.LogoBox.TabStop = false;
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Location = new System.Drawing.Point(692, 130);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(156, 84);
            this.EmployeeButton.TabIndex = 56;
            this.EmployeeButton.Text = "Работники";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // EPGroupBox
            // 
            this.EPGroupBox.Controls.Add(this.ReloadButton);
            this.EPGroupBox.Controls.Add(this.label1);
            this.EPGroupBox.Controls.Add(this.IDTextBox);
            this.EPGroupBox.Controls.Add(this.IDLabel);
            this.EPGroupBox.Controls.Add(this.ClearButton);
            this.EPGroupBox.Controls.Add(this.ELComboBox);
            this.EPGroupBox.Controls.Add(this.WithHonorCheckBox);
            this.EPGroupBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EPGroupBox.Location = new System.Drawing.Point(12, 13);
            this.EPGroupBox.Name = "EPGroupBox";
            this.EPGroupBox.Size = new System.Drawing.Size(674, 111);
            this.EPGroupBox.TabIndex = 55;
            this.EPGroupBox.TabStop = false;
            this.EPGroupBox.Text = "Обучение";
            // 
            // majorsBindingSource1
            // 
            this.majorsBindingSource1.DataMember = "Majors";
            this.majorsBindingSource1.DataSource = this.hRAppDBDataSet;
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadButton.BackgroundImage")));
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(492, 10);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(54, 54);
            this.ReloadButton.TabIndex = 46;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Уровень образования:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(6, 78);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(101, 27);
            this.IDTextBox.TabIndex = 49;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(2, 39);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(105, 36);
            this.IDLabel.TabIndex = 48;
            this.IDLabel.Text = "Табельный \r\nномер:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(552, 10);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 54);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить фильтр";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ELComboBox
            // 
            this.ELComboBox.DataSource = this.educationPlacesBindingSource;
            this.ELComboBox.DisplayMember = "Name_EducationPlace";
            this.ELComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ELComboBox.FormattingEnabled = true;
            this.ELComboBox.Location = new System.Drawing.Point(113, 78);
            this.ELComboBox.Name = "ELComboBox";
            this.ELComboBox.Size = new System.Drawing.Size(204, 26);
            this.ELComboBox.TabIndex = 1;
            this.ELComboBox.ValueMember = "ID_EducationPlace";
            this.ELComboBox.SelectedIndexChanged += new System.EventHandler(this.ELComboBox_SelectedIndexChanged);
            // 
            // educationLevelsBindingSource1
            // 
            this.educationLevelsBindingSource1.DataMember = "EducationLevels";
            this.educationLevelsBindingSource1.DataSource = this.hRAppDBDataSet;
            // 
            // WithHonorCheckBox
            // 
            this.WithHonorCheckBox.AutoSize = true;
            this.WithHonorCheckBox.Location = new System.Drawing.Point(323, 80);
            this.WithHonorCheckBox.Name = "WithHonorCheckBox";
            this.WithHonorCheckBox.Size = new System.Drawing.Size(122, 22);
            this.WithHonorCheckBox.TabIndex = 0;
            this.WithHonorCheckBox.Text = "С отличием";
            this.WithHonorCheckBox.UseVisualStyleBackColor = true;
            this.WithHonorCheckBox.CheckedChanged += new System.EventHandler(this.WithHonorCheckBox_CheckedChanged);
            // 
            // majorsBindingSource
            // 
            this.majorsBindingSource.DataMember = "Majors";
            this.majorsBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // educationLevelsBindingSource
            // 
            this.educationLevelsBindingSource.DataMember = "EducationLevels";
            this.educationLevelsBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PageLabel);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PervButton);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 63);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(291, 27);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(88, 18);
            this.PageLabel.TabIndex = 10;
            this.PageLabel.Text = "Страницы";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(617, 9);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(54, 54);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PervButton
            // 
            this.PervButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.PervButton.FlatAppearance.BorderSize = 0;
            this.PervButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.PervButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PervButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PervButton.ForeColor = System.Drawing.Color.White;
            this.PervButton.Location = new System.Drawing.Point(-1, 9);
            this.PervButton.Name = "PervButton";
            this.PervButton.Size = new System.Drawing.Size(54, 54);
            this.PervButton.TabIndex = 0;
            this.PervButton.Text = "<";
            this.PervButton.UseVisualStyleBackColor = false;
            this.PervButton.Click += new System.EventHandler(this.PervButton_Click);
            // 
            // EmployeesEducationFormGridView
            // 
            this.EmployeesEducationFormGridView.AllowUserToAddRows = false;
            this.EmployeesEducationFormGridView.AllowUserToDeleteRows = false;
            this.EmployeesEducationFormGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.EmployeesEducationFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesEducationFormGridView.Location = new System.Drawing.Point(15, 130);
            this.EmployeesEducationFormGridView.Name = "EmployeesEducationFormGridView";
            this.EmployeesEducationFormGridView.ReadOnly = true;
            this.EmployeesEducationFormGridView.Size = new System.Drawing.Size(671, 372);
            this.EmployeesEducationFormGridView.TabIndex = 53;
            // 
            // BTButton
            // 
            this.BTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.BTButton.FlatAppearance.BorderSize = 0;
            this.BTButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.BTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTButton.ForeColor = System.Drawing.Color.White;
            this.BTButton.Location = new System.Drawing.Point(692, 418);
            this.BTButton.Name = "BTButton";
            this.BTButton.Size = new System.Drawing.Size(156, 84);
            this.BTButton.TabIndex = 62;
            this.BTButton.Text = "Командировки";
            this.BTButton.UseVisualStyleBackColor = false;
            this.BTButton.Click += new System.EventHandler(this.BTButton_Click);
            // 
            // educationLevelsTableAdapter
            // 
            this.educationLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // majorsTableAdapter
            // 
            this.majorsTableAdapter.ClearBeforeFill = true;
            // 
            // fKEmployeesEducationEducationLevelsBindingSource
            // 
            this.fKEmployeesEducationEducationLevelsBindingSource.DataMember = "FK_Employee\'sEducation_EducationLevels";
            this.fKEmployeesEducationEducationLevelsBindingSource.DataSource = this.educationLevelsBindingSource;
            // 
            // employeesEducationTableAdapter
            // 
            this.employeesEducationTableAdapter.ClearBeforeFill = true;
            // 
            // educationPlacesBindingSource
            // 
            this.educationPlacesBindingSource.DataMember = "EducationPlaces";
            this.educationPlacesBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // educationPlacesTableAdapter
            // 
            this.educationPlacesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeesEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.BTButton);
            this.Controls.Add(this.LeavesButton1);
            this.Controls.Add(this.VacationsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.EPGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeesEducationFormGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesEducationForm";
            this.Text = " Агентство недвижимости ООО \"МегаМир\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesEducationForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeesEducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.EPGroupBox.ResumeLayout(false);
            this.EPGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesEducationFormGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesEducationEducationLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlacesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LeavesButton1;
        private System.Windows.Forms.Button VacationsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.GroupBox EPGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PervButton;
        private System.Windows.Forms.DataGridView EmployeesEducationFormGridView;
        private System.Windows.Forms.Button BTButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.ComboBox ELComboBox;
        private System.Windows.Forms.CheckBox WithHonorCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource educationLevelsBindingSource;
        private HRAppDBDataSetTableAdapters.EducationLevelsTableAdapter educationLevelsTableAdapter;
        private System.Windows.Forms.BindingSource majorsBindingSource;
        private HRAppDBDataSetTableAdapters.MajorsTableAdapter majorsTableAdapter;
        private System.Windows.Forms.BindingSource fKEmployeesEducationEducationLevelsBindingSource;
        private HRAppDBDataSetTableAdapters.EmployeesEducationTableAdapter employeesEducationTableAdapter;
        private System.Windows.Forms.BindingSource majorsBindingSource1;
        private System.Windows.Forms.BindingSource educationLevelsBindingSource1;
        private System.Windows.Forms.BindingSource educationPlacesBindingSource;
        private HRAppDBDataSetTableAdapters.EducationPlacesTableAdapter educationPlacesTableAdapter;
    }
}