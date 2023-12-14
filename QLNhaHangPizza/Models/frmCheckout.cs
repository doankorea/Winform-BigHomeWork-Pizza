using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using QlyNhaHangPizza.Model;
using System.ComponentModel.Design.Data;

namespace QLNhaHangPizza.Model
{
	public partial class frmCheckout : Form
	{
		QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
		public int mainID = 0; 

		public frmCheckout()
		{
			InitializeComponent();
		}
		public double amt;
		private void txtPaymentReceived_TextChanged(object sender, EventArgs e)
		{
			double amt = 0;
			double receipt = 0;
			double change = 0;
			double.TryParse(txtBillAmount.Text, out amt);
			double.TryParse(txtPaymentReceived.Text, out receipt);
			if(amt <= receipt)
			{
                change = receipt- amt;
            } else
			{
				change = 0;
			}
			txtChange.Text = change.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string query = @"Update tblMain set total = @total, received = @received, change = @change, status = 'Paid' where MainID = @id";
			Hashtable ht = new Hashtable();
			ht.Add("@id", mainID);
			ht.Add("@total", txtBillAmount.Text);
			ht.Add("@received", txtBillAmount.Text);
			ht.Add("@change", txtChange.Text);
			dtBase.ExecuteScalar(query, ht);
			MessageBox.Show("Saved Successfull");
			this.Close();
		}

		private void frmCheckout_Load(object sender, EventArgs e)
		{
			txtBillAmount.Text = amt.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
