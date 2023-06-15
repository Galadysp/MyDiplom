using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApp.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void ButtonAuth_Click(object sender, EventArgs e)
        {
            String LoginUser = TextBoxLogin.Text;
            String PasswordUser = TextBoxPassword.Text;

            if (LoginUser != "" && PasswordUser != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"workstation id=HRAppDB.mssql.somee.com;packet size=4096;user id=galadysp_SQLLogin_4;pwd=5gephl2yz4;data source=HRAppDB.mssql.somee.com;persist security info=False;initial catalog=HRAppDB");
                    SqlDataAdapter sda = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Login = @ul AND Password = @up", con);
                    cmd.Parameters.Add("@ul", SqlDbType.VarChar).Value = LoginUser;
                    cmd.Parameters.Add("@up", SqlDbType.VarChar).Value = PasswordUser;

                    sda.SelectCommand = cmd;
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.Show();
                    }

                    else
                    {
                        MessageBox.Show("Неверный логин и/или пароль, попробуйте снова.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля. Поле «Логин»/«Пароль» не было заполнено.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
