namespace HRApp.Forms
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonAuth = new System.Windows.Forms.Button();
            this.AuthLabel3 = new System.Windows.Forms.Label();
            this.AuthLabel2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.AuthLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonAuth);
            this.groupBox1.Controls.Add(this.AuthLabel3);
            this.groupBox1.Controls.Add(this.AuthLabel2);
            this.groupBox1.Controls.Add(this.TextBoxPassword);
            this.groupBox1.Controls.Add(this.TextBoxLogin);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(359, 234);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные пользователя:";
            // 
            // ButtonAuth
            // 
            this.ButtonAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAuth.AutoEllipsis = true;
            this.ButtonAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(1)))));
            this.ButtonAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAuth.FlatAppearance.BorderSize = 0;
            this.ButtonAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(7)))));
            this.ButtonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuth.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuth.ForeColor = System.Drawing.Color.White;
            this.ButtonAuth.Location = new System.Drawing.Point(27, 173);
            this.ButtonAuth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAuth.Name = "ButtonAuth";
            this.ButtonAuth.Size = new System.Drawing.Size(304, 44);
            this.ButtonAuth.TabIndex = 3;
            this.ButtonAuth.Text = "Войти";
            this.ButtonAuth.UseVisualStyleBackColor = false;
            this.ButtonAuth.Click += new System.EventHandler(this.ButtonAuth_Click);
            // 
            // AuthLabel3
            // 
            this.AuthLabel3.AutoSize = true;
            this.AuthLabel3.Location = new System.Drawing.Point(23, 93);
            this.AuthLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthLabel3.Name = "AuthLabel3";
            this.AuthLabel3.Size = new System.Drawing.Size(76, 18);
            this.AuthLabel3.TabIndex = 3;
            this.AuthLabel3.Text = "Пароль:";
            // 
            // AuthLabel2
            // 
            this.AuthLabel2.AutoSize = true;
            this.AuthLabel2.Location = new System.Drawing.Point(23, 25);
            this.AuthLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthLabel2.Name = "AuthLabel2";
            this.AuthLabel2.Size = new System.Drawing.Size(65, 18);
            this.AuthLabel2.TabIndex = 2;
            this.AuthLabel2.Text = "Логин:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(27, 114);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(304, 27);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(26, 46);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(304, 27);
            this.TextBoxLogin.TabIndex = 0;
            // 
            // AuthLabel1
            // 
            this.AuthLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLabel1.Location = new System.Drawing.Point(14, 12);
            this.AuthLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthLabel1.Name = "AuthLabel1";
            this.AuthLabel1.Size = new System.Drawing.Size(359, 48);
            this.AuthLabel1.TabIndex = 8;
            this.AuthLabel1.Text = "Для того чтобы продолжить, необходима авторизация";
            this.AuthLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AuthLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Агентство недвижимости ООО \"МегаМир\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonAuth;
        private System.Windows.Forms.Label AuthLabel3;
        private System.Windows.Forms.Label AuthLabel2;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label AuthLabel1;
    }
}