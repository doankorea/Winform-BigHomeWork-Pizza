using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangPizza
{
    public partial class ForgotPassword : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnrcv_Click(object sender, EventArgs e)
        {
            if (txtRe_Phone.Text.Trim() == "")
            {
                MessageBox.Show("Username cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRe_Phone.Focus();
                return;
            }
            if (txtRe_Password.Text.Trim() == "")
            {
                MessageBox.Show("Password cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRe_Password.Focus();
                return;
            }
            if (lblcheck.Text.Trim() == "")
            {
                MessageBox.Show("Confirm password cannot be left blank", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblcheck.Focus();
                return;
            }
            string query = "Select * from dbo.tAccount where phoneNumber = N'" + txtRe_Phone.Text + "'";
            DataTable dt = dtBase.DocBang(query);
            if (dt.Rows.Count > 0)
            {
                if (txtRe_Password.Text == txtRe_CheckPassword.Text)
                {
                    dtBase.CapNhatDuLieu("Update dbo.tAccount set password = N'" + txtRe_Password.Text + "'");

                    DialogResult result = MessageBox.Show("Reset Password Successful !!!", "Inform", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Re-entered password is incorrect, please re-enter !!!", "Inform", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Phone number does not exist, please re-enter !!!", "Inform", MessageBoxButtons.OK);
                txtRe_Phone.Clear();
                txtRe_Password.Clear();
                txtRe_CheckPassword.Clear();
                txtRe_Phone.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin= new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
    }
}
