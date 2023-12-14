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
    public partial class frmTableView : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        public frmTableView()
        {
            InitializeComponent();
        }

        private void frmTableView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string query = "select idTable, nameTable from tTable";
            DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();
                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idTable"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["nameTable"];
            }
        }

		private void btnAddTable_Click(object sender, EventArgs e)
		{
            frmTableAdd frm = new frmTableAdd(selectedTableID);
            frm.ShowDialog();
            LoadData();
		}
        private int selectedTableID;

		private void txtSearchTable_TextChanged(object sender, EventArgs e)
		{
            string query;
                if (string.IsNullOrEmpty(txtSearchTable.Text))
            {
                query = "Select idTable ,nameTable from tTable";
            }
            else
            {
                query = "Select idTable ,nameTable  from tTable WHERE nameTable LIKE N'%" + txtSearchTable.Text + "%'";

			}
            DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();
                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idTable"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["nameTable"];
            }

        }

		private void dataGridViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this table !");
                if (result == DialogResult.OK)
                {
                    string query = "delete from tTable where idTable =" + id.ToString();
                    dtBase.CapNhatDuLieu(query);
                    LoadData();
                }

            }
            
            if(dataGridViewItem.CurrentCell.OwningColumn.Name =="dgvedit")
            {
               int selectedTableID = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);

                frmTableAdd frm = new frmTableAdd(selectedTableID);

                frm.FillDataFromGrid(selectedTableID);
				frm.OnDataUpdated += (s, args) => { LoadData(); }; 
				frm.Show();

			}

		}
	}
}
