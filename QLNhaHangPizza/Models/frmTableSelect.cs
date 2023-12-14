using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyNhaHangPizza.Model
{
    public partial class frmTableSelect : Form
    {
        QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
        public string tableName ;
        public frmTableSelect()
        {
            InitializeComponent();
        }

        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            DataTable dt = dtBase.DocBang("select*from dbo.tTable");
            DataTable dt2 = dtBase.DocBang("select*from dbo.tblMain as m inner join dbo.tTable as t on t.idTable = m.idTable where m.status = 'pending' or m.status = 'complete'   ");
            foreach (DataRow row in dt.Rows)
            {
                    Button b = new Button();
                b.Text = row["nameTable"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.BackColor = Color.FromArgb(0xC8, 0x50, 0xF2);
                b.ForeColor = Color.White;
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
                foreach (DataRow row2 in dt2.Rows)
                {
                    if(b.Text == row2["nameTable"].ToString())
                    {
                        b.Enabled = false;
                    }
                    
                }
            }
            
        }
        private void b_Click(object sender, EventArgs e)
        {
            tableName = (sender as Button).Text.ToString();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
