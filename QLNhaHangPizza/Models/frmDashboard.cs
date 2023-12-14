using QLNhaHangPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangPizza
{
	public partial class frmDashboard : Form
	{
		//Fields
		private Dashboard model;
		private Button currentButton;
		//Constructor
		public frmDashboard()
		{
			InitializeComponent();
			//Default - Last 7 days
			dtpStartDate.Value = DateTime.Today.AddDays(-7);
			dtpEndDate.Value = DateTime.Now;
			btnLast7Days.Select();
			SetDateMenuButtonsUI(btnLast7Days);
			model = new Dashboard();
			LoadData();
		}
		//Private methods
		private void LoadData()
		{
			var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
			if (refreshData == true)
			{
				lblNumOrders.Text = model.NumOrders.ToString();
				lblTotalRevenue.Text = "$" + model.TotalRevenue.ToString();
				lblTotalProfit.Text = "$" + model.TotalProfit.ToString();
				lblNumCustomers.Text = model.NumCustomers.ToString();
				lblNumProducts.Text = model.NumProducts.ToString();
				chartGrossRevenue.DataSource = model.GrossRevenueList;
				chartGrossRevenue.Series[0].XValueMember = "Date";
				chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
				chartGrossRevenue.DataBind();
				chartTopProducts.DataSource = model.TopProductsList;
				chartTopProducts.Series[0].XValueMember = "Key";
				chartTopProducts.Series[0].YValueMembers = "Value";
				chartTopProducts.DataBind();

				dgvOutstandingemployee.DataSource = model.Outstandingemployee;
				dgvOutstandingemployee.Columns[0].HeaderText = "StaffName";
				dgvOutstandingemployee.Columns[1].HeaderText = "Invoicenumber";
				Console.WriteLine("Loaded view :)");
			}
			else Console.WriteLine("View not loaded, same query");
		}
		private void SetDateMenuButtonsUI(object button)
		{
			var btn = (Button)button;
			btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
			btn.ForeColor = Color.White;
			
			if(currentButton != null && currentButton!= btn) { 
				currentButton.BackColor= this.BackColor;
				currentButton.ForeColor= Color.FromArgb(124, 141, 181);
			}
			currentButton = btn;
			if (btn == btnCustomDate)
			{
				dtpStartDate.Enabled = true;
				dtpEndDate.Enabled = true;
				btnOkCustomDate.Visible = true;
				lblStartDate.Cursor = Cursors.Hand;
				lblEndDate.Cursor = Cursors.Hand;
			}
			else
			{
				dtpStartDate.Enabled = false;	
				dtpEndDate.Enabled = false;
				lblStartDate.Cursor = Cursors.Default;
				lblEndDate.Cursor = Cursors.Default;
			}
		}
		//Event methods
		private void btnToday_Click(object sender, EventArgs e)
		{
			dtpStartDate.Value = DateTime.Today;
			dtpEndDate.Value = DateTime.Now;
			LoadData();
			SetDateMenuButtonsUI(sender);
		}
		private void btnLast7Days_Click(object sender, EventArgs e)
		{
			dtpStartDate.Value = DateTime.Today.AddDays(-7);
			dtpEndDate.Value = DateTime.Now;
			LoadData();
			SetDateMenuButtonsUI(sender);
		}
		private void btnLast30Days_Click(object sender, EventArgs e)
		{
			dtpStartDate.Value = DateTime.Today.AddDays(-30);
			dtpEndDate.Value = DateTime.Now;
			LoadData();
			SetDateMenuButtonsUI(sender);
		}
		private void btnThisMonth_Click(object sender, EventArgs e)
		{
			dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			dtpEndDate.Value = DateTime.Now;
			LoadData();
			SetDateMenuButtonsUI(sender);
		}
		private void btnCustomDate_Click(object sender, EventArgs e)
		{
			
			SetDateMenuButtonsUI(sender);
		}
		private void btnOkCustomDate_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void label14_Click(object sender, EventArgs e)
		{
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

		private void label12_Click(object sender, EventArgs e)
		{
			if (currentButton == btnCustomDate)
			{
				dtpStartDate.Select();
				SendKeys.Send("%{DOWN}");
			}
		}

		private void dtpEndDate_ValueChanged(object sender, EventArgs e)
		{
			lblEndDate.Text= dtpEndDate.Text;
		}

		private void dtpStartDate_ValueChanged(object sender, EventArgs e)
		{
			lblStartDate.Text = dtpStartDate.Text;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblEndDate.Text = dtpEndDate.Text;
			lblStartDate.Text = dtpStartDate.Text;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel4_Paint_1(object sender, PaintEventArgs e)
		{

		}
	}
}
