using QLNhaHangPizza.DAO;
using QLNhaHangPizza.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNhaHangPizza
{
    public partial class frmLogin : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        public frmLogin()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            if (Properties.Settings.Default.UserName != "" && Properties.Settings.Default.PassWord != "")
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.PassWord;
            }
        }


        private void lblSignUp_Click(object sender, EventArgs e)
        {
        
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if(txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            if (Login(userName, passWord))
            {
                this.Hide();
                Main.frmMainForManager frmMainForManager = new Main.frmMainForManager();
                frmMainForManager.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
			bool Login(string username, string password)
			{
                //string query = "Select * from dbo.tAccount where username = N'" + username + "' and password = N'" + password + "'";
                string query = "Select * from dbo.tAccount where username = @username and password = @password";
               
                DataTable result = dtBase.DocBang(query, new object[] {username, password});
				if (result.Rows.Count > 0)
				{
					frmMainForManager.displayName = result.Rows[0]["displayname"].ToString();
					frmMainForManager.userName = result.Rows[0]["username"].ToString();
				}
				return result.Rows.Count > 0;
			}
		}

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void cbrmb_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbrmb.Checked)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Save();
                
            }
            else
            {
                String username = txtUsername.Text;
                String passWord = txtPassword.Text;
                Properties.Settings.Default.UserName = username;
                Properties.Settings.Default.PassWord = passWord;

            }
            Properties.Settings.Default.Save(); 
        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
        }
    }
}
