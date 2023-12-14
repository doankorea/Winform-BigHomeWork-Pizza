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

namespace QlyNhaHangPizza.View
{
    
    public partial class frmKitchenView : Form
    {
        QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOders();
        }
        private void GetOders()
        {
            frmBillList frm = new frmBillList();
            flowLayoutPanel1.Controls.Clear();
            string query = @"Select * from tblMain where status = 'pending'";
            DataTable dt = dtBase.DocBang(query);
            FlowLayoutPanel p1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10,10,10,10);
                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(64, 64, 64);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);
                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10,10,3,0);
                lb1.AutoSize = true;
                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;
                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;
                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 0);
                lb4.AutoSize = true;
                Label lb5 = new Label();
                lb5.ForeColor = Color.White;
                lb5.Margin = new Padding(10, 5, 3, 0);
                lb5.AutoSize = true;
                lb1.Text = "IDTable: " + dt.Rows[i]["idTable"].ToString();
                lb2.Text = "IDWaiter: " + dt.Rows[i]["idStaff"].ToString();
                lb3.Text = "Order Time: " + dt.Rows[i]["aTime"].ToString();
                DateTime aDate = Convert.ToDateTime(dt.Rows[i]["aDate"]);
                lb4.Text = "Order Date: " + aDate.Date.ToString("yyyy-MM-dd");
                lb5.Text = "Order Type: " + dt.Rows[i]["orderType"].ToString();
                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);
                p2.Controls.Add(lb5);
                p1.Controls.Add(p2);
                flowLayoutPanel1.Controls.Add(p1);
                int mid = 0;
                mid = Convert.ToInt32(dt.Rows[i]["MainID"].ToString());
                string query2 = @"select*from tblMain as m
                                inner join tblDetails as d on m.MainID = d.MainID
                                inner join tFood as p on p.idFood = d.proID where m.MainID = " + mid + "";
                DataTable dt2 = dtBase.DocBang(query2);
                for(int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lb6 = new Label();
                    lb6.ForeColor = Color.White;
                    lb6.Margin = new Padding(10, 5, 3, 0);
                    lb6.AutoSize = true;
                    int no = j + 1;
                    lb6.Text = "" + no + " " + dt2.Rows[j]["nameFood"].ToString() + " " + dt2.Rows[j]["qty"].ToString();
                    p1.Controls.Add(lb6);
                    p1.BackColor = Color.Gray;
                }
                Button b = new Button();
                b.Size = new Size(100, 35);
                b.BackColor = Color.FromArgb(200, 80, 242);
                b.Margin = new Padding(60,5,3,10);
                b.Text = "Complete";
                b.ForeColor = Color.White;
                b.Tag = dt.Rows[i]["MainID"].ToString();
                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);
            }
        }
        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Tag.ToString());
           DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Inform", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = @"Update tblMain set status = 'complete' where mainID = " + id;
                dtBase.CapNhatDuLieu(query);
                GetOders();
            }
        }
    }
}
