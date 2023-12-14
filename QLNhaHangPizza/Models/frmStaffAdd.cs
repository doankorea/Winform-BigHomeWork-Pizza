using QLNhaHangPizza.DAO;
using QLNhaHangPizza.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace QLNhaHangPizza.Model
{

    public partial class frmStaffAdd : Form
    {
        private int staffID;
        public event EventHandler OnDataUpdated;
        DAO.DataProvider dtBase = new DAO.DataProvider();
        DAO.CommonFunctions cf = new DAO.CommonFunctions();
        public frmStaffAdd(int id)
        {
            InitializeComponent();
            staffID = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (staffID > 0)
            {
                string query = "UPDATE tStaff " +
                "SET Name = N'" + txtAddName.Text + "', " +
                "    Diachi = N'" + txtAddAddress.Text + "', " +
                "    phoneNumber = N'" + txtPhoneNumber.Text + "', " +
                "    role = (SELECT typeRole FROM Role WHERE nameRole = N'" + cbRole.Text + "'), " +
                "    avtStaff = " + (pbImage.Tag != null ? "N'" + pbImage.Tag.ToString() + "'" : "NULL") + " " +
                "WHERE idStaff = " + staffID;

                int rowsAffected = dtBase.CapNhatDuLieu(query);

                if (rowsAffected > 0)
                {
                    // Nếu cập nhật thành công, kích hoạt sự kiện để thông báo cho frmStaffView cập nhật dữ liệu
                    OnDataUpdated?.Invoke(this, EventArgs.Empty);

                    DialogResult result = MessageBox.Show("Update successful", "Inform", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                string query = "INSERT INTO dbo.tStaff(Name, Diachi, phoneNumber, role, avtStaff) " +
                               "VALUES (N'" + txtAddName.Text + "', N'" + txtAddAddress.Text + "', N'" + txtPhoneNumber.Text + "', " +
                               "'" + cbRole.SelectedValue.ToString() + "', " +
                               (pbImage.Tag != null ? "N'" + pbImage.Tag.ToString() + "'" : "NULL") + ")";
                int rowsAffected = dtBase.CapNhatDuLieu(query);

                if (rowsAffected > 0)
                {
                    // Nếu INSERT thành công, kích hoạt sự kiện để thông báo cho frmStaffView cập nhật dữ liệu
                    OnDataUpdated?.Invoke(this, EventArgs.Empty);

                    DialogResult result = MessageBox.Show("Save successful", "Inform", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }
        private void cbCategory_Click(object sender, EventArgs e)
        {
            cf.FillComBox(cbRole, dtBase.DocBang("select*from Role"), "nameRole", "typeRole");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến tệp ảnh đã chọn
                string selectedImagePath = openFileDialog1.FileName;
                pbImage.Tag = System.IO.Path.GetFileName(selectedImagePath);
                // Hiển thị ảnh lên PictureBox
                pbImage.Image = System.Drawing.Image.FromFile(selectedImagePath);
            }
        }
        public void FillDataFromGrid(int id)
        {
            string query = "SELECT st.Name, st.Diachi, st.phoneNumber, r.nameRole, st.avtStaff FROM tStaff as st join Role as r on st.role = r.typeRole WHERE idStaff = " + id.ToString();
            DataTable data = dtBase.DocBang(query);

            if (data.Rows.Count > 0)
            {
                txtAddName.Text = data.Rows[0]["Name"].ToString();
                txtAddAddress.Text = data.Rows[0]["Diachi"].ToString();
                txtPhoneNumber.Text = data.Rows[0]["phoneNumber"].ToString();
                // Gán giá trị cho combobox
                string nameRole = data.Rows[0]["nameRole"].ToString();
                if (cbRole.Items.Contains(nameRole))
                {
                    cbRole.SelectedItem = nameRole;
                }
                else
                {
                    cbRole.Items.Add(nameRole);
                    cbRole.SelectedItem = nameRole;
                }

                // Gán giá trị cho ảnh nếu có
                if (!string.IsNullOrEmpty(data.Rows[0]["avtStaff"].ToString()))
                {
                    pbImage.Tag = data.Rows[0]["avtStaff"].ToString();
                    pbImage.Image = Image.FromFile(Application.StartupPath + "//ImagesIcon//" + data.Rows[0]["avtStaff"].ToString());
                }
            }
        }

		private void frmStaffAdd_Load(object sender, EventArgs e)
		{

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{

		}
	}
    }
