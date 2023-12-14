using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QlyNhaHangPizza
{
	
	public partial class frmCategoryAdd : Form
    {
		private int idCategory;
		public event EventHandler OnDataUpdated;
		QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();

		public frmCategoryAdd(int id)
        {
            InitializeComponent();
			idCategory = id;
        }

		public void SetIdCategory(int categoryId)
		{
			idCategory = categoryId;
		}
		public virtual void btnClose_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click_1(object sender, EventArgs e)
		{
			string query = "";

			if (idCategory == 0)
			{
				query = "Insert into tFoodCategory (nameCategory) Values(N'" + txtName.Text + "')";
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
			if (idCategory > 0)
			{
				query = "UPDATE tFoodCategory SET nameCategory = N'" + txtName.Text + "' WHERE idCategory = " + idCategory;

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
        public void FillDataFromGrid(int id)
        {
            string query = "SELECT * FROM tFoodCategory where idCategory = " + id.ToString();
            DataTable data = dtBase.DocBang(query);

            if (data.Rows.Count > 0)
            {
                txtName.Text = data.Rows[0]["nameCategory"].ToString();             
            }
        }
    }
}
