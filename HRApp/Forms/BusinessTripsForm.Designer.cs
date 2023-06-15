namespace HRApp.Forms
{
    partial class BusinessTripsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsForm));
            this.VacationsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.StudyButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DOOCheckBox = new System.Windows.Forms.CheckBox();
            this.DRCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.fundingSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.IDLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PervButton = new System.Windows.Forms.Button();
            this.BusinessTripsFormGridView = new System.Windows.Forms.DataGridView();
            this.LeavesButton1 = new System.Windows.Forms.Button();
            this.fundingSourcesTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.FundingSourcesTableAdapter();
            this.FRLabel = new System.Windows.Forms.Label();
            this.FRComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundingSourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessTripsFormGridView)).BeginInit();
            this.SuspendLayout();
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
            this.VacationsButton.TabIndex = 51;
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
            this.ExitButton.TabIndex = 50;
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
            this.LogoBox.TabIndex = 49;
            this.LogoBox.TabStop = false;
            // 
            // StudyButton
            // 
            this.StudyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.StudyButton.FlatAppearance.BorderSize = 0;
            this.StudyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.StudyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudyButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudyButton.ForeColor = System.Drawing.Color.White;
            this.StudyButton.Location = new System.Drawing.Point(692, 418);
            this.StudyButton.Name = "StudyButton";
            this.StudyButton.Size = new System.Drawing.Size(156, 84);
            this.StudyButton.TabIndex = 48;
            this.StudyButton.Text = "Обучение";
            this.StudyButton.UseVisualStyleBackColor = false;
            this.StudyButton.Click += new System.EventHandler(this.StudyButton_Click);
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
            this.EmployeeButton.TabIndex = 46;
            this.EmployeeButton.Text = "Работники";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReloadButton);
            this.groupBox2.Controls.Add(this.IDTextBox);
            this.groupBox2.Controls.Add(this.DOOCheckBox);
            this.groupBox2.Controls.Add(this.DRCheckBox);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.FRComboBox);
            this.groupBox2.Controls.Add(this.FRLabel);
            this.groupBox2.Controls.Add(this.IDLabel);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 111);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Командировки";
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadButton.BackgroundImage")));
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(492, 16);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(54, 54);
            this.ReloadButton.TabIndex = 45;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(4, 80);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(89, 27);
            this.IDTextBox.TabIndex = 23;
            // 
            // DOOCheckBox
            // 
            this.DOOCheckBox.AutoSize = true;
            this.DOOCheckBox.Location = new System.Drawing.Point(294, 57);
            this.DOOCheckBox.Name = "DOOCheckBox";
            this.DOOCheckBox.Size = new System.Drawing.Size(197, 22);
            this.DOOCheckBox.TabIndex = 21;
            this.DOOCheckBox.Text = "По дате подписания";
            this.DOOCheckBox.UseVisualStyleBackColor = true;
            this.DOOCheckBox.CheckedChanged += new System.EventHandler(this.DOOCheckBox_CheckedChanged);
            // 
            // DRCheckBox
            // 
            this.DRCheckBox.AutoSize = true;
            this.DRCheckBox.Location = new System.Drawing.Point(294, 85);
            this.DRCheckBox.Name = "DRCheckBox";
            this.DRCheckBox.Size = new System.Drawing.Size(211, 22);
            this.DRCheckBox.TabIndex = 20;
            this.DRCheckBox.Text = "По дате возвращения";
            this.DRCheckBox.UseVisualStyleBackColor = true;
            this.DRCheckBox.CheckedChanged += new System.EventHandler(this.DRCheckBox_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(551, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 54);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить фильтр";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // fundingSourcesBindingSource
            // 
            this.fundingSourcesBindingSource.DataMember = "FundingSources";
            this.fundingSourcesBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(0, 40);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(105, 36);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "Табельный \r\nномер:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintButton);
            this.groupBox1.Controls.Add(this.PageLabel);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PervButton);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 63);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(290, 10);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(123, 54);
            this.PrintButton.TabIndex = 11;
            this.PrintButton.Text = "Печать документа";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(157, 28);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(88, 18);
            this.PageLabel.TabIndex = 10;
            this.PageLabel.Text = "Страницы";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(548, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 54);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(419, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 54);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(61, 10);
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
            this.PervButton.Location = new System.Drawing.Point(1, 10);
            this.PervButton.Name = "PervButton";
            this.PervButton.Size = new System.Drawing.Size(54, 54);
            this.PervButton.TabIndex = 0;
            this.PervButton.Text = "<";
            this.PervButton.UseVisualStyleBackColor = false;
            this.PervButton.Click += new System.EventHandler(this.PervButton_Click);
            // 
            // BusinessTripsFormGridView
            // 
            this.BusinessTripsFormGridView.AllowUserToAddRows = false;
            this.BusinessTripsFormGridView.AllowUserToDeleteRows = false;
            this.BusinessTripsFormGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.BusinessTripsFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusinessTripsFormGridView.Location = new System.Drawing.Point(15, 130);
            this.BusinessTripsFormGridView.Name = "BusinessTripsFormGridView";
            this.BusinessTripsFormGridView.ReadOnly = true;
            this.BusinessTripsFormGridView.Size = new System.Drawing.Size(671, 372);
            this.BusinessTripsFormGridView.TabIndex = 43;
            this.BusinessTripsFormGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusinessTripsFormGridView_CellDoubleClick);
            this.BusinessTripsFormGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.BusinessTripsFormGridView_DataError);
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
            this.LeavesButton1.TabIndex = 52;
            this.LeavesButton1.Text = "Увольнения";
            this.LeavesButton1.UseVisualStyleBackColor = false;
            this.LeavesButton1.Click += new System.EventHandler(this.LeavesButton1_Click);
            // 
            // fundingSourcesTableAdapter
            // 
            this.fundingSourcesTableAdapter.ClearBeforeFill = true;
            // 
            // FRLabel
            // 
            this.FRLabel.AutoSize = true;
            this.FRLabel.Location = new System.Drawing.Point(96, 41);
            this.FRLabel.Name = "FRLabel";
            this.FRLabel.Size = new System.Drawing.Size(157, 36);
            this.FRLabel.TabIndex = 14;
            this.FRLabel.Text = "Источник\r\nфинансирования:";
            // 
            // FRComboBox
            // 
            this.FRComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.FRComboBox.DataSource = this.fundingSourcesBindingSource;
            this.FRComboBox.DisplayMember = "Name_FundingSource";
            this.FRComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FRComboBox.FormattingEnabled = true;
            this.FRComboBox.Location = new System.Drawing.Point(99, 80);
            this.FRComboBox.Name = "FRComboBox";
            this.FRComboBox.Size = new System.Drawing.Size(190, 26);
            this.FRComboBox.TabIndex = 15;
            this.FRComboBox.ValueMember = "ID_FundingSource";
            this.FRComboBox.SelectedIndexChanged += new System.EventHandler(this.FRComboBox_SelectedIndexChanged);
            // 
            // BusinessTripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.LeavesButton1);
            this.Controls.Add(this.VacationsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.StudyButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BusinessTripsFormGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusinessTripsForm";
            this.Text = " Агентство недвижимости ООО \"МегаМир\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BusinessTripsForm_FormClosed);
            this.Load += new System.EventHandler(this.BusinessTripsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundingSourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessTripsFormGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VacationsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button StudyButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PervButton;
        private System.Windows.Forms.DataGridView BusinessTripsFormGridView;
        private System.Windows.Forms.Button LeavesButton1;
        private System.Windows.Forms.CheckBox DOOCheckBox;
        private System.Windows.Forms.CheckBox DRCheckBox;
        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource fundingSourcesBindingSource;
        private HRAppDBDataSetTableAdapters.FundingSourcesTableAdapter fundingSourcesTableAdapter;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.ComboBox FRComboBox;
        private System.Windows.Forms.Label FRLabel;
    }
}