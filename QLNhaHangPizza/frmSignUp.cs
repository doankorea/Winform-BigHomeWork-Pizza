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
    public partial class frmSignUp : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin= new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCre_Displayname.Text.Trim() == "")
            {
                MessageBox.Show("Displayname cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCre_Username.Focus();
                return;
            }
            if (txtCre_Username.Text.Trim() == "")
            {
                MessageBox.Show("Username cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCre_Username.Focus();
                return;
            }
            if (txtCre_Password.Text.Trim() == "")
            {
                MessageBox.Show("Confirm password cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCre_Password.Focus();
                return;
            }
            if (txtCre_Phonenumber.Text.Trim() == "")
            {
                MessageBox.Show("PhoneNumber cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCre_Phonenumber.Focus();
                return;
            }
            string query = "Select * from dbo.tAccount where username = N'" + txtCre_Username.Text + "'";
            DataTable dt = dtBase.DocBang(query);
            if (dt.Rows.Count <= 0)
            {
                dtBase.CapNhatDuLieu("INSERT INTO dbo.tAccount ( username, password,displayname, phoneNumber, type)" +
                    "VALUES ( N'" + txtCre_Username.Text + "', N'" + txtCre_Password.Text + "', N'" + txtCre_Phonenumber.Text + "',N'\" + txtCre_Displayname.Text + \"', 0)");

                DialogResult result = MessageBox.Show("Sign Up Successful !!!", "Inform", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Username already exists, please re-enter !!!", "Inform", MessageBoxButtons.OK);
                txtCre_Username.Clear();
                txtCre_Password.Clear();
                txtCre_Phonenumber.Clear();
                txtCre_Username.Focus();
            }
        }
    }
}
