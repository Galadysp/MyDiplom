namespace HRApp.Forms
{
    partial class LeavesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeavesForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.StudyButton = new System.Windows.Forms.Button();
            this.BTButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.DOLCheckBox = new System.Windows.Forms.CheckBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.RComboBox = new System.Windows.Forms.ComboBox();
            this.reasonsOfLeavingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.FRLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PervButton = new System.Windows.Forms.Button();
            this.LeavesGridView = new System.Windows.Forms.DataGridView();
            this.VacationsButton = new System.Windows.Forms.Button();
            this.reasonsOfLeavingTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.ReasonsOfLeavingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reasonsOfLeavingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeavesGridView)).BeginInit();
            this.SuspendLayout();
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
            this.ExitButton.TabIndex = 41;
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
            this.LogoBox.TabIndex = 40;
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
            this.StudyButton.TabIndex = 39;
            this.StudyButton.Text = "Обучение";
            this.StudyButton.UseVisualStyleBackColor = false;
            this.StudyButton.Click += new System.EventHandler(this.StudyButton_Click);
            // 
            // BTButton
            // 
            this.BTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.BTButton.FlatAppearance.BorderSize = 0;
            this.BTButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.BTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTButton.ForeColor = System.Drawing.Color.White;
            this.BTButton.Location = new System.Drawing.Point(692, 226);
            this.BTButton.Name = "BTButton";
            this.BTButton.Size = new System.Drawing.Size(156, 84);
            this.BTButton.TabIndex = 37;
            this.BTButton.Text = "Командировки";
            this.BTButton.UseVisualStyleBackColor = false;
            this.BTButton.Click += new System.EventHandler(this.BTButton_Click);
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
            this.EmployeeButton.TabIndex = 36;
            this.EmployeeButton.Text = "Работники";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReloadButton);
            this.groupBox2.Controls.Add(this.DOLCheckBox);
            this.groupBox2.Controls.Add(this.IDTextBox);
            this.groupBox2.Controls.Add(this.RComboBox);
            this.groupBox2.Controls.Add(this.FRLabel);
            this.groupBox2.Controls.Add(this.IDLabel);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 111);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Увольнения";
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadButton.BackgroundImage")));
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(485, 16);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(54, 54);
            this.ReloadButton.TabIndex = 44;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // DOLCheckBox
            // 
            this.DOLCheckBox.AutoSize = true;
            this.DOLCheckBox.Location = new System.Drawing.Point(471, 80);
            this.DOLCheckBox.Name = "DOLCheckBox";
            this.DOLCheckBox.Size = new System.Drawing.Size(196, 22);
            this.DOLCheckBox.TabIndex = 43;
            this.DOLCheckBox.Text = "По дате увольнения";
            this.DOLCheckBox.UseVisualStyleBackColor = true;
            this.DOLCheckBox.CheckedChanged += new System.EventHandler(this.DOLCheckBox_CheckedChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(3, 78);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(116, 27);
            this.IDTextBox.TabIndex = 27;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // RComboBox
            // 
            this.RComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.RComboBox.DataSource = this.reasonsOfLeavingBindingSource;
            this.RComboBox.DisplayMember = "Reason";
            this.RComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RComboBox.FormattingEnabled = true;
            this.RComboBox.Location = new System.Drawing.Point(125, 79);
            this.RComboBox.Name = "RComboBox";
            this.RComboBox.Size = new System.Drawing.Size(340, 26);
            this.RComboBox.TabIndex = 26;
            this.RComboBox.ValueMember = "ID_Reason";
            this.RComboBox.SelectedIndexChanged += new System.EventHandler(this.RComboBox_SelectedIndexChanged);
            // 
            // reasonsOfLeavingBindingSource
            // 
            this.reasonsOfLeavingBindingSource.DataMember = "ReasonsOfLeaving";
            this.reasonsOfLeavingBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FRLabel
            // 
            this.FRLabel.AutoSize = true;
            this.FRLabel.Location = new System.Drawing.Point(122, 57);
            this.FRLabel.Name = "FRLabel";
            this.FRLabel.Size = new System.Drawing.Size(191, 18);
            this.FRLabel.TabIndex = 25;
            this.FRLabel.Text = "Причина увольнения:\r\n";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(-1, 39);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(105, 36);
            this.IDLabel.TabIndex = 24;
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
            this.ClearButton.Location = new System.Drawing.Point(545, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 54);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить фильтр";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.PageLabel);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PervButton);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 63);
            this.groupBox1.TabIndex = 34;
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
            this.PrintButton.Location = new System.Drawing.Point(290, 9);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(123, 54);
            this.PrintButton.TabIndex = 14;
            this.PrintButton.Text = "Печать документа";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(548, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 54);
            this.DeleteButton.TabIndex = 12;
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
            this.AddButton.Location = new System.Drawing.Point(419, 9);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 54);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(156, 27);
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
            this.NextButton.Location = new System.Drawing.Point(61, 9);
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
            this.PervButton.Location = new System.Drawing.Point(1, 9);
            this.PervButton.Name = "PervButton";
            this.PervButton.Size = new System.Drawing.Size(54, 54);
            this.PervButton.TabIndex = 0;
            this.PervButton.Text = "<";
            this.PervButton.UseVisualStyleBackColor = false;
            this.PervButton.Click += new System.EventHandler(this.PervButton_Click);
            // 
            // LeavesGridView
            // 
            this.LeavesGridView.AllowUserToAddRows = false;
            this.LeavesGridView.AllowUserToDeleteRows = false;
            this.LeavesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.LeavesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeavesGridView.Location = new System.Drawing.Point(15, 130);
            this.LeavesGridView.Name = "LeavesGridView";
            this.LeavesGridView.ReadOnly = true;
            this.LeavesGridView.Size = new System.Drawing.Size(671, 372);
            this.LeavesGridView.TabIndex = 33;
            this.LeavesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeavesGridView_CellDoubleClick);
            this.LeavesGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.LeavesGridView_DataError);
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
            this.VacationsButton.TabIndex = 42;
            this.VacationsButton.Text = "Отпуска";
            this.VacationsButton.UseVisualStyleBackColor = false;
            this.VacationsButton.Click += new System.EventHandler(this.VacationsButton_Click);
            // 
            // reasonsOfLeavingTableAdapter
            // 
            this.reasonsOfLeavingTableAdapter.ClearBeforeFill = true;
            // 
            // LeavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.VacationsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.StudyButton);
            this.Controls.Add(this.BTButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LeavesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeavesForm";
            this.Text = " Агентство недвижимости ООО \"МегаМир\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeavesForm_FormClosed);
            this.Load += new System.EventHandler(this.LeavesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reasonsOfLeavingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeavesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button StudyButton;
        private System.Windows.Forms.Button BTButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PervButton;
        private System.Windows.Forms.DataGridView LeavesGridView;
        private System.Windows.Forms.Button VacationsButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ComboBox RComboBox;
        private System.Windows.Forms.Label FRLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.CheckBox DOLCheckBox;
        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource reasonsOfLeavingBindingSource;
        private HRAppDBDataSetTableAdapters.ReasonsOfLeavingTableAdapter reasonsOfLeavingTableAdapter;
        private System.Windows.Forms.Button ReloadButton;
    }
}