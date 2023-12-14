using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNhaHangPizza.Model
{
    public partial class frmTableAdd : Form
    {
        public int idTable;
		public event EventHandler OnDataUpdated;
		DAO.DataProvider dtBase = new DAO.DataProvider();
		
		public frmTableAdd(int id)
        {
            InitializeComponent();
			idTable = id;
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			string query = "";

			if (idTable==0)
			{
				query = "Insert into tTable (nameTable) Values(N'"+txtName.Text+"')";
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
			if(idTable>0)
			{
				query = "UPDATE tTable SET nameTable = N'" + txtName.Text + "' WHERE idTable = " + idTable;

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
        public void FillDataFromGrid(int id)
        {
            string query = "SELECT * FROM tTable where idTable = " + id.ToString();
            DataTable data = dtBase.DocBang(query);

            if (data.Rows.Count > 0)
            {
                txtName.Text = data.Rows[0]["nameTable"].ToString();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
