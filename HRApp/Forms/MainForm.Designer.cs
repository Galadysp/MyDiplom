namespace HRApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.StudyButton = new System.Windows.Forms.Button();
            this.LeavesButton1 = new System.Windows.Forms.Button();
            this.BTButton = new System.Windows.Forms.Button();
            this.VacationsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.RCheckBox = new System.Windows.Forms.CheckBox();
            this.WCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRAppDBDataSet = new HRApp.HRAppDBDataSet();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenderLabel = new System.Windows.Forms.Label();
            this.PtrLabel = new System.Windows.Forms.Label();
            this.PNTextBox = new System.Windows.Forms.TextBox();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.SNTextBox = new System.Windows.Forms.TextBox();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.FNTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PageLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PervButton = new System.Windows.Forms.Button();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.positionsTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.PositionsTableAdapter();
            this.genderTableAdapter = new HRApp.HRAppDBDataSetTableAdapters.GenderTableAdapter();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(743, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(156, 111);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 22;
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
            this.StudyButton.Location = new System.Drawing.Point(743, 417);
            this.StudyButton.Name = "StudyButton";
            this.StudyButton.Size = new System.Drawing.Size(156, 84);
            this.StudyButton.TabIndex = 21;
            this.StudyButton.Text = "Обучение";
            this.StudyButton.UseVisualStyleBackColor = false;
            this.StudyButton.Click += new System.EventHandler(this.StudyButton_Click);
            // 
            // LeavesButton1
            // 
            this.LeavesButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.LeavesButton1.FlatAppearance.BorderSize = 0;
            this.LeavesButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.LeavesButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeavesButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeavesButton1.ForeColor = System.Drawing.Color.White;
            this.LeavesButton1.Location = new System.Drawing.Point(743, 321);
            this.LeavesButton1.Name = "LeavesButton1";
            this.LeavesButton1.Size = new System.Drawing.Size(156, 84);
            this.LeavesButton1.TabIndex = 20;
            this.LeavesButton1.Text = "Увольнения";
            this.LeavesButton1.UseVisualStyleBackColor = false;
            this.LeavesButton1.Click += new System.EventHandler(this.LeavesButton1_Click);
            // 
            // BTButton
            // 
            this.BTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.BTButton.FlatAppearance.BorderSize = 0;
            this.BTButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.BTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTButton.ForeColor = System.Drawing.Color.White;
            this.BTButton.Location = new System.Drawing.Point(743, 225);
            this.BTButton.Name = "BTButton";
            this.BTButton.Size = new System.Drawing.Size(156, 84);
            this.BTButton.TabIndex = 19;
            this.BTButton.Text = "Командировки";
            this.BTButton.UseVisualStyleBackColor = false;
            this.BTButton.Click += new System.EventHandler(this.BTButton_Click);
            // 
            // VacationsButton
            // 
            this.VacationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.VacationsButton.FlatAppearance.BorderSize = 0;
            this.VacationsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.VacationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VacationsButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacationsButton.ForeColor = System.Drawing.Color.White;
            this.VacationsButton.Location = new System.Drawing.Point(743, 129);
            this.VacationsButton.Name = "VacationsButton";
            this.VacationsButton.Size = new System.Drawing.Size(156, 84);
            this.VacationsButton.TabIndex = 18;
            this.VacationsButton.Text = "Отпуска";
            this.VacationsButton.UseVisualStyleBackColor = false;
            this.VacationsButton.Click += new System.EventHandler(this.VacationsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReloadButton);
            this.groupBox2.Controls.Add(this.RCheckBox);
            this.groupBox2.Controls.Add(this.WCheckBox);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.PositionComboBox);
            this.groupBox2.Controls.Add(this.PositionLabel);
            this.groupBox2.Controls.Add(this.GenderComboBox);
            this.groupBox2.Controls.Add(this.GenderLabel);
            this.groupBox2.Controls.Add(this.PtrLabel);
            this.groupBox2.Controls.Add(this.PNTextBox);
            this.groupBox2.Controls.Add(this.SNameLabel);
            this.groupBox2.Controls.Add(this.SNTextBox);
            this.groupBox2.Controls.Add(this.FNameLabel);
            this.groupBox2.Controls.Add(this.FNTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 111);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работники";
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadButton.BackgroundImage")));
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(537, 19);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(54, 54);
            this.ReloadButton.TabIndex = 45;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RCheckBox
            // 
            this.RCheckBox.AutoSize = true;
            this.RCheckBox.Location = new System.Drawing.Point(98, 26);
            this.RCheckBox.Name = "RCheckBox";
            this.RCheckBox.Size = new System.Drawing.Size(118, 22);
            this.RCheckBox.TabIndex = 18;
            this.RCheckBox.Text = "Пенсионер";
            this.RCheckBox.UseVisualStyleBackColor = true;
            this.RCheckBox.CheckedChanged += new System.EventHandler(this.RCheckBox_CheckedChanged);
            // 
            // WCheckBox
            // 
            this.WCheckBox.AutoSize = true;
            this.WCheckBox.Location = new System.Drawing.Point(4, 26);
            this.WCheckBox.Name = "WCheckBox";
            this.WCheckBox.Size = new System.Drawing.Size(88, 22);
            this.WCheckBox.TabIndex = 17;
            this.WCheckBox.Text = "Уволен";
            this.WCheckBox.UseVisualStyleBackColor = true;
            this.WCheckBox.CheckedChanged += new System.EventHandler(this.WCheckBox_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(597, 19);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 54);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить фильтр";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.PositionComboBox.DataSource = this.positionsBindingSource;
            this.PositionComboBox.DisplayMember = "Name_Position";
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(429, 79);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(291, 26);
            this.PositionComboBox.TabIndex = 15;
            this.PositionComboBox.ValueMember = "ID_Position";
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.hRAppDBDataSetBindingSource;
            // 
            // hRAppDBDataSetBindingSource
            // 
            this.hRAppDBDataSetBindingSource.DataSource = this.hRAppDBDataSet;
            this.hRAppDBDataSetBindingSource.Position = 0;
            // 
            // hRAppDBDataSet
            // 
            this.hRAppDBDataSet.DataSetName = "HRAppDBDataSet";
            this.hRAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(426, 57);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(105, 18);
            this.PositionLabel.TabIndex = 14;
            this.PositionLabel.Text = "Должность:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.GenderComboBox.DataSource = this.genderBindingSource;
            this.GenderComboBox.DisplayMember = "Gender";
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(4, 79);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(44, 26);
            this.GenderComboBox.TabIndex = 9;
            this.GenderComboBox.ValueMember = "Gender";
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.hRAppDBDataSet;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(1, 58);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(47, 18);
            this.GenderLabel.TabIndex = 8;
            this.GenderLabel.Text = "Пол:";
            // 
            // PtrLabel
            // 
            this.PtrLabel.AutoSize = true;
            this.PtrLabel.Location = new System.Drawing.Point(301, 57);
            this.PtrLabel.Name = "PtrLabel";
            this.PtrLabel.Size = new System.Drawing.Size(91, 18);
            this.PtrLabel.TabIndex = 6;
            this.PtrLabel.Text = "Отчество:";
            // 
            // PNTextBox
            // 
            this.PNTextBox.BackColor = System.Drawing.Color.White;
            this.PNTextBox.Location = new System.Drawing.Point(304, 78);
            this.PNTextBox.Name = "PNTextBox";
            this.PNTextBox.Size = new System.Drawing.Size(119, 27);
            this.PNTextBox.TabIndex = 5;
            this.PNTextBox.TextChanged += new System.EventHandler(this.PNTextBox_TextChanged);
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Location = new System.Drawing.Point(176, 57);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(89, 18);
            this.SNameLabel.TabIndex = 4;
            this.SNameLabel.Text = "Фамилия:";
            // 
            // SNTextBox
            // 
            this.SNTextBox.BackColor = System.Drawing.Color.White;
            this.SNTextBox.Location = new System.Drawing.Point(179, 78);
            this.SNTextBox.Name = "SNTextBox";
            this.SNTextBox.Size = new System.Drawing.Size(119, 27);
            this.SNTextBox.TabIndex = 3;
            this.SNTextBox.TextChanged += new System.EventHandler(this.SNTextBox_TextChanged);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(51, 57);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(48, 18);
            this.FNameLabel.TabIndex = 2;
            this.FNameLabel.Text = "Имя:";
            // 
            // FNTextBox
            // 
            this.FNTextBox.BackColor = System.Drawing.Color.White;
            this.FNTextBox.Location = new System.Drawing.Point(54, 78);
            this.FNTextBox.Name = "FNTextBox";
            this.FNTextBox.Size = new System.Drawing.Size(119, 27);
            this.FNTextBox.TabIndex = 0;
            this.FNTextBox.TabStop = false;
            this.FNTextBox.TextChanged += new System.EventHandler(this.FNTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PageLabel);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PervButton);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 63);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(243, 28);
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
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(15, 129);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.Size = new System.Drawing.Size(722, 372);
            this.EmployeeGridView.TabIndex = 15;
            this.EmployeeGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellDoubleClick);
            this.EmployeeGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.EmployeeGridView_DataError);
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(744, 513);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(155, 53);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(469, 9);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 54);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить работника";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(598, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 54);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить работника";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.StudyButton);
            this.Controls.Add(this.LeavesButton1);
            this.Controls.Add(this.BTButton);
            this.Controls.Add(this.VacationsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeeGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = " Агентство недвижимости ООО \"МегаМир\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button StudyButton;
        private System.Windows.Forms.Button LeavesButton1;
        private System.Windows.Forms.Button BTButton;
        private System.Windows.Forms.Button VacationsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox RCheckBox;
        private System.Windows.Forms.CheckBox WCheckBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label PtrLabel;
        private System.Windows.Forms.TextBox PNTextBox;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.TextBox SNTextBox;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.TextBox FNTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PervButton;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.BindingSource hRAppDBDataSetBindingSource;
        private HRAppDBDataSet hRAppDBDataSet;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private HRAppDBDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private HRAppDBDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}