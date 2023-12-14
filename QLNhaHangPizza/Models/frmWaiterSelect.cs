using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangPizza.DAO;
namespace QlyNhaHangPizza.Model
{
    public partial class frmWaiterSelect : Form
    {
        QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
        public string waiterName;
        public frmWaiterSelect()
        {
            InitializeComponent();
        }
        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {
            DataTable dt = dtBase.DocBang("select*from dbo.tStaff where role = 0");
            foreach (DataRow row in dt.Rows)
            {
                Button b = new Button();
                b.Text = row["Name"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.BackColor = Color.FromArgb(0xC8, 0x50, 0xF2);
                b.ForeColor = Color.White;
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
            }

        }
        private void b_Click(object sender, EventArgs e)
        {
            waiterName = (sender as Button).Text.ToString();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
