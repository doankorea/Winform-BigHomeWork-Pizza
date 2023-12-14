using QLNhaHangPizza.DAO;
using QLNhaHangPizza.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace QLNhaHangPizza.View
{
    public partial class frmProductView : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string query = "select f.idFood, f.nameFood, c.nameCategory, f.priceFood from tFood as f join tFoodCategory as c on f.idCategory = c.idCategory";
			DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();

                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idFood"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["nameFood"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvCategory"].Value = row["nameCategory"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvPrice"].Value = row["priceFood"];
            }
        }

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
            frmProductAdd frm = new frmProductAdd(Productid);
            DataProvider.BlurBackground(frm);
            LoadData();
		}

        private int Productid;
		private void txtSearchProduct_TextChanged(object sender, EventArgs e)
		{
			string query;
			if (string.IsNullOrWhiteSpace(txtSearchProduct.Text))
			{
				// Nếu ô tìm kiếm rỗng, thực hiện truy vấn để lấy toàn bộ dữ liệu
				query = "select f.idFood, f.nameFood, c.nameCategory, f.priceFood " +
						"from tFood as f join tFoodCategory as c on f.idCategory = c.idCategory";
			}
			else
			{
				// Nếu có nội dung trong ô tìm kiếm, thực hiện truy vấn tìm kiếm
				query = "select f.idFood, f.nameFood, c.nameCategory, f.priceFood " +
						"from tFood as f join tFoodCategory as c on f.idCategory = c.idCategory " +
						"WHERE f.nameFood LIKE N'%" + txtSearchProduct.Text + "%'";
			}

            DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();

                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idFood"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["nameFood"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvCategory"].Value = row["nameCategory"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvPrice"].Value = row["priceFood"];
            }
        }

		private void dataGridViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvdel")
			{
				int id = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);
				DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Inform", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string query1 = "Delete from tFood where idFood = " + id.ToString();
					dtBase.CapNhatDuLieu(query1);
					LoadData();
				}
			}
			if (dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvedit")
			{
				int selectedProductID = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);

				frmProductAdd frm = new frmProductAdd(selectedProductID);
				frm.FillDataFromGrid(selectedProductID);
				frm.OnDataUpdated += (s, args) => { LoadData(); };
				DataProvider.BlurBackground(frm);

			}
		}
	}
}
