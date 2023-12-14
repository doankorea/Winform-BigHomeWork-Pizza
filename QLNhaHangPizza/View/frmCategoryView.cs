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

namespace QlyNhaHangPizza
{
    public partial class frmCategoryView : Form
    {
        QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
        public frmCategoryView()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string query = "select idCategory, nameCategory from tFoodCategory";
			DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();
                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idCategory"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["nameCategory"];
            }
        }
        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridViewItem.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewItem.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {
			

		}


		public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd(idCategory);
            
            frm.ShowDialog();
			LoadData();


		}
        private int idCategory;

		private void dataGridViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvdel")
			{
				int id = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);
				DialogResult result = MessageBox.Show("Are you sure you want to delete this table !");
				if (result == DialogResult.OK)
				{
					string query = "delete from tFoodCategory where idCategory =" + id.ToString();
					dtBase.CapNhatDuLieu(query);
					LoadData();
				}

			}

			if (dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvedit")
			{
				int  SelectedIdCategory= Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);

				frmCategoryAdd frm = new frmCategoryAdd(SelectedIdCategory);
                frm.FillDataFromGrid(SelectedIdCategory);
				frm.OnDataUpdated += (s, args) => { LoadData(); };
				frm.Show();

			}
		}

		private void txtSearchCategory_TextChanged(object sender, EventArgs e)
		{
			string query;
			if (string.IsNullOrEmpty(txtSearchCategory.Text))
			{
				query = "Select idCategory ,nameCategory  from tFoodCategory";
			}
			else
			{
				query = "Select idCategory ,nameCategory  from tFoodCategory WHERE nameCategory LIKE N'%" + txtSearchCategory.Text + "%'";

			}
            DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();
                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idCategory"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["nameCategory"];
            }
        }
	}
}
