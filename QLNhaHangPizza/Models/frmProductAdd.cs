using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangPizza.Model
{
    public partial class frmProductAdd : Form
    {
		private int idProduct;
		public event EventHandler OnDataUpdated;
		DAO.DataProvider dtBase = new DAO.DataProvider();
		DAO.CommonFunctions cf = new DAO.CommonFunctions();
		public frmProductAdd(int id)
        {
            InitializeComponent();
			idProduct = id;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (idProduct > 0)
			{
                // Update existing product
                string query = "UPDATE tFood " +
                   "SET NameFood = N'" + txtName.Text + "', " +
                   "    priceFood = N'" + txtGia.Text + "', " +
                   "    idCategory = (SELECT idCategory FROM tFoodCategory WHERE nameCategory = N'" + cbbCategory.Text + "'), " +
                   "    avtFood = " + (pbProduct.Tag != null ? "N'" + pbProduct.Tag.ToString() + "'" : "NULL") + " " +
                   "WHERE idFood = " + idProduct;
                int rowsAffected = dtBase.CapNhatDuLieu(query);

				if (rowsAffected > 0)
				{
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
				// Insert new product
				string query = "INSERT INTO dbo.tFood(NameFood, priceFood, idCategory, avtFood) " +
							   "VALUES (N'" + txtName.Text + "', N'" + txtGia.Text + "', '" + cbbCategory.SelectedValue.ToString() + "', " +
							   (pbProduct.Tag != null ? "N'" + pbProduct.Tag.ToString() + "'" : "NULL") + ")";
				int rowsAffected = dtBase.CapNhatDuLieu(query);

				if (rowsAffected > 0)
				{
					OnDataUpdated?.Invoke(this, EventArgs.Empty);

					DialogResult result = MessageBox.Show("Save successful", "Inform", MessageBoxButtons.OK);
					if (result == DialogResult.OK)
					{
						this.Close();
					}
				}
			}
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
				pbProduct.Tag = System.IO.Path.GetFileName(selectedImagePath);
				// Hiển thị ảnh lên PictureBox
				pbProduct.Image = System.Drawing.Image.FromFile(selectedImagePath);
			}
		}

		public void FillDataFromGrid(int id)
		{
			string query = "SELECT f.NameFood, f.priceFood, fc.nameCategory, f.avtFood FROM tFood as f join tFoodCategory as fc on f.idCategory = fc.idCategory  WHERE f.idFood = " + id.ToString();
			DataTable data = dtBase.DocBang(query);

			if (data.Rows.Count > 0)
			{
				txtName.Text = data.Rows[0]["NameFood"].ToString();
				txtGia.Text = data.Rows[0]["priceFood"].ToString();

				// Gán giá trị cho ComboBox danh mục sản phẩm
				string nameCategory = data.Rows[0]["nameCategory"].ToString();
                if (cbbCategory.Items.Contains(nameCategory))
                {
                    cbbCategory.SelectedItem = nameCategory;
                }
                else
                {
                    cbbCategory.Items.Add(nameCategory);
                    cbbCategory.SelectedItem = nameCategory;
                }

                // Gán giá trị cho ảnh nếu có
                if (!string.IsNullOrEmpty(data.Rows[0]["avtFood"].ToString()))
				{
					pbProduct.Tag = data.Rows[0]["avtFood"].ToString();
					pbProduct.Image = Image.FromFile(Application.StartupPath + "//ImagesProduct//" + data.Rows[0]["avtFood"].ToString());
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbCategory_Click(object sender, EventArgs e)
		{
			cf.FillComBox(cbbCategory, dtBase.DocBang("select*from tFoodCategory"), "nameCategory","idCategory");
		}

		private void frmProductAdd_Load(object sender, EventArgs e)
		{

		}
	}
}
