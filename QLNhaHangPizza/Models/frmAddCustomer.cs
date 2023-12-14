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
	public partial class frmAddCustomer : Form
	{
		QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
		DAO.CommonFunctions cf = new DAO.CommonFunctions();
		public frmAddCustomer()
		{
			InitializeComponent();
		}
		public string OderType = "";
		public int MainID = 0;
		public string cusName = "";
		public string cusAddress = "";
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAddCustomer_Load(object sender, EventArgs e)
		{
			if(OderType == "TakeAway")
			{
				lblDriver.Visible = false;
				cbDriver.Visible = false;
			
			} else {
				cbDriver_Click(this, EventArgs.Empty);
				if (cbDriver.Items.Count > 0)
				{
					cbDriver.SelectedIndex = 0;
				}
			}
		}

		private void cbDriver_Click(object sender, EventArgs e)
		{
			cf.FillComBox(cbDriver, dtBase.DocBang("select Name, idStaff from tStaff join Role on tStaff.role = Role.typeRole where Role.nameRole = N'Waiter' "), "Name", "idStaff");
		}

	}
}
