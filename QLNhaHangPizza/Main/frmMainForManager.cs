using FontAwesome.Sharp;
using QLNhaHangPizza.DAO;
using QLNhaHangPizza.View;
using QlyNhaHangPizza;
using QlyNhaHangPizza.Model;
using QlyNhaHangPizza.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNhaHangPizza.Main
{
    public partial class frmMainForManager : Form
    {
        private IconButton curentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static string userName;
		public static string displayName;
		string fileAnh;
        DataProvider dtBase = new DataProvider();
        public frmMainForManager()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            sidebar.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

		}
		

		private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                curentBtn = (IconButton)sender;
                curentBtn.BackColor = Color.FromArgb(37, 36, 81);
                curentBtn.ForeColor = color;
                curentBtn.TextAlign = ContentAlignment.MiddleLeft;
                curentBtn.IconColor = color;
                curentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                curentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, curentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = curentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (curentBtn != null)
            {
                curentBtn.BackColor = Color.FromArgb(28, 26, 36);
                curentBtn.ForeColor = Color.Gainsboro;
                curentBtn.TextAlign = ContentAlignment.MiddleLeft;
                curentBtn.IconColor = Color.Gainsboro;
                curentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = curentBtn.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static Color color = Color.FromArgb(200, 80, 242);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender, color);
			Reset();
			if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmCategoryView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmProductView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmStaffView());
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmPOS());
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmKitchenView());
        
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new frmReportView());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
          
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool isMaximized = false;
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
		private void frmMainForManager_Load(object sender, EventArgs e)
		{
			UserName.Text = displayName;
			string query = "Select * from dbo.tAccount where username = '" + userName + "'";
			DataTable result = dtBase.DocBang(query);
			if (result.Rows.Count > 0)
			{
				string fileAnh = result.Rows[0]["avtAccount"].ToString();
				try
				{
					picAnh.Image = Image.FromFile(Application.StartupPath + "\\ImagesIcon\\" + fileAnh);
				}
				catch (Exception ex)
				{
                    picAnh.Image = null;
					// Handle exceptions (e.g., file not found) gracefully
				}
				try
				{
					int userType = int.Parse(result.Rows[0]["type"].ToString());

					if (userType == 0)
					{
                        btnCategories.Visible = false;
                        btnProducts.Visible = false;
                        btnTables.Visible = false;
                        btnStaff.Visible = false;

					}
				}
				catch (FormatException ex)
				{
					// Handle the exception if parsing fails (e.g., log it, display an error message)
					Console.WriteLine("Error parsing user type: " + ex.Message);
				}
			}
			else
			{
				picAnh.Image = null;
			}
		}
        private bool isHidden = false;
        private void frmMainForManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

		private void circularPictureBox1_Click(object sender, EventArgs e)
		{
			string[] image;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All files|*.*|JPEG Images|*.jpg|PNG Images|*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.InitialDirectory = Application.StartupPath;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				picAnh.Image = Image.FromFile(openFileDialog.FileName);
				image = openFileDialog.FileName.ToString().Split('\\');
				fileAnh = image[image.Length - 1];
			}
			string sqlInsert = "UPDATE dbo.tAccount SET avtAccount = '" + fileAnh + "' WHERE username = '" + userName + "'";
			dtBase.CapNhatDuLieu(sqlInsert);
		}

		private void iconButton4_Click(object sender, EventArgs e)
		{
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
		}

		private void iconButton5_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, color);
			OpenChildForm(new frmDashboard());
		}
	}
}
