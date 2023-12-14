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

namespace QLNhaHangPizza.View
{
    public partial class frmStaffView : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        public frmStaffView()
        {
            InitializeComponent();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string query = "select idStaff, Name, Diachi, phoneNumber," +
                "CASE when role = 0 then 'Waiter'" +
                "else 'Manager'" +
                "end as Role " +
                "from tStaff";
            DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();

                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idStaff"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["Name"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvAddress"].Value = row["Diachi"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvPhoneNumber"].Value = row["phoneNumber"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvRole"].Value = row["Role"];
            }
        }

        private void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string query;
            if (string.IsNullOrWhiteSpace(txtSearchStaff.Text))
            {
                query = "select idStaff, Name, Diachi, phoneNumber, " +
                        "CASE WHEN role = 0 THEN 'Waiter' ELSE 'Manager' END AS Role " +
                        "FROM tStaff";
            }
            else
            {
                query = "select idStaff, Name, Diachi, phoneNumber, " +
                        "CASE WHEN role = 0 THEN 'Waiter' ELSE 'Manager' END AS Role " +
                        "FROM tStaff WHERE Name LIKE N'%" + txtSearchStaff.Text + "%'";
            }
            DataTable data = dtBase.DocBang(query);
            dataGridViewItem.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dataGridViewItem.Rows.Add();

                dataGridViewItem.Rows[rowIndex].Cells["dgvID"].Value = row["idStaff"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvName"].Value = row["Name"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvAddress"].Value = row["Diachi"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvPhoneNumber"].Value = row["phoneNumber"];
                dataGridViewItem.Rows[rowIndex].Cells["dgvRole"].Value = row["Role"];
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmStaffAdd frm = new frmStaffAdd(selectedStaffID);
            DataProvider.BlurBackground(frm);
            LoadData();
        }
        private int selectedStaffID;
        private void dataGridViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this staff?", "Inform", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string query1 = "Delete from tStaff where idStaff = " + id.ToString();
                        dtBase.CapNhatDuLieu(query1);
                    LoadData();
                    }
            }
            if (dataGridViewItem.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                int selectedStaffID = Convert.ToInt32(dataGridViewItem.CurrentRow.Cells["dgvID"].Value);
                frmStaffAdd frm = new frmStaffAdd(selectedStaffID);
                frm.FillDataFromGrid(selectedStaffID);
                frm.OnDataUpdated += (s, args) => { LoadData(); };
                DataProvider.BlurBackground(frm);
              
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
    }

