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
using Excel = Microsoft.Office.Interop.Excel;

namespace QlyNhaHangPizza.Model
{
    public partial class frmBillList : Form
    {
        QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();
        public frmBillList()
        {
            InitializeComponent();
        }
		public string OderType;
		public int MainID;
		
        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string query0 = "select MainID, idTable, idStaff, orderType, status, total from tblMain";
            DataTable dt0 = dtBase.DocBang(query0);
            dataGridViewItem10.Rows.Clear();
            foreach (DataRow row0 in dt0.Rows)
            {
                string orderType = row0["orderType"].ToString();

				string query2 = (orderType == "Dine in")
					? "select m.MainID, t.nameTable, s.Name, m.orderType, m.status, m.total from tblMain as m inner join tTable as t on t.idTable = m.idTable inner join tStaff as s on s.idStaff = m.idStaff where CAST(m.aDate AS DATE) = @date"
                    : "select MainID, idTable, idStaff, orderType, status, total from tblMain as m where CAST(m.aDate AS DATE) = @date";

                if (orderType != "Dine in")
                {
                    query2 += " and orderType = '" + orderType + "'";
                }

                DataTable dt = dtBase.DocBang(query2, new object[] { ChooseDate.Value.Date });
                foreach (DataRow row in dt.Rows)
                {
                    int existingRowIndex = -1;
                    foreach (DataGridViewRow dataGridViewRow in dataGridViewItem10.Rows)
                    {
                        if (dataGridViewRow.Cells["dgvID"].Value.ToString() == row["MainID"].ToString())
                        {
                            existingRowIndex = dataGridViewRow.Index;
                            break;
                        }
                    }

                    if (existingRowIndex == -1)
                    {
                        int rowIndex = dataGridViewItem10.Rows.Add();
                        dataGridViewItem10.Rows[rowIndex].Cells["dgvID"].Value = row["MainID"];
                        dataGridViewItem10.Rows[rowIndex].Cells["dgvtable"].Value = (orderType == "Dine in") ? row["nameTable"] : row["idTable"];
                        dataGridViewItem10.Rows[rowIndex].Cells["dgvWaiter"].Value = (orderType == "Dine in") ? row["Name"] : row["idStaff"];
                        dataGridViewItem10.Rows[rowIndex].Cells["dgvType"].Value = row["orderType"];
                        dataGridViewItem10.Rows[rowIndex].Cells["dgvStatus"].Value = row["status"];
                        dataGridViewItem10.Rows[rowIndex].Cells["dgvTotal"].Value = row["total"];
                    }
                }
            }
        }








        private void dataGridViewItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void dataGridViewItem10_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewItem10.CurrentCell.OwningColumn.Name == "dgvedit")
			{
				MainID = Convert.ToInt32(dataGridViewItem10.CurrentRow.Cells["dgvID"].Value);
                OderType = dataGridViewItem10.CurrentRow.Cells["dgvType"].Value.ToString();
                this.Close();
			}
                if (dataGridViewItem10.CurrentCell.OwningColumn.Name == "dgvdel")
			{
				string query = "";
                MainID = Convert.ToInt32(dataGridViewItem10.CurrentRow.Cells["dgvID"].Value);
                OderType = dataGridViewItem10.CurrentRow.Cells["dgvType"].Value.ToString();
				if (OderType == "Dine in")
				{
                    query = @"Select * from tblMain as m
                             inner join tblDetails as d on m.MainID = d.MainID
                             inner join tFood as f on f.idFood = d.proID
                             inner join tTable as t on t.idTable = m.idTable
                             inner join tStaff as s on s.idStaff = m.idStaff 
                             where m.MainID = " + MainID + "";
                }
				else
				{
                    query = @"Select * from tblMain as m
                             inner join tblDetails as d on m.MainID = d.MainID
                             inner join tFood as f on f.idFood = d.proID
                             where m.MainID = " + MainID + "";
                }
                Excel.Application exApp = new Excel.Application();
				Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
				Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
				exRange.Font.Size = 18;
				exRange.Font.Bold = true;
				exRange.Font.Color = Color.Green;
				exRange.Value = "PIZZA HUT RESTAURANT";
				Excel.Range diachi = (Excel.Range)exSheet.Cells[2, 1];
				diachi.Value = "159 Xa Dan, Phuong Lien, Dong Da, Ha Noi";
				diachi.Font.Size = 15;
				diachi.Font.Color = Color.Green;
				exSheet.Range["D4"].Font.Size = 22;
				exSheet.Range["D4"].Font.Bold = true;
				exSheet.Range["D4"].Font.Color = Color.Blue;
				DataTable Main = dtBase.DocBang(query);
				exSheet.Range["D4"].Value = "BILL OF SALE";
				exSheet.Range["A5:A11"].Font.Size = 12;
				exSheet.Range["A5"].Value = "MainID: " + MainID.ToString();
				DateTime aDate = Convert.ToDateTime(Main.Rows[0]["aDate"]);
				exSheet.Range["A6"].Value = "Date: " + aDate.ToShortDateString();
				exSheet.Range["A7"].Value = "Time: " + Main.Rows[0]["aTime"].ToString();
				exSheet.Range["A8"].Value = "Order Type: " + Main.Rows[0]["orderType"].ToString();
				if(Main.Rows[0]["orderType"].ToString() == "Delivery" || Main.Rows[0]["orderType"].ToString() == "TakeAway")
				{
					exSheet.Range["A9"].Value = "Customer Name: " + Main.Rows[0]["CusName"].ToString();
					exSheet.Range["A10"].Value = "Customer Phone: " + Main.Rows[0]["CusPhone"].ToString();
					exSheet.Range["A11"].Value = "Customer Address: " + Main.Rows[0]["CusAddress"].ToString();
				} else
				{
					exSheet.Range["A9"].Value = "Table: " + Main.Rows[0]["nameTable"].ToString();
					exSheet.Range["A10"].Value = "Waiter: " + Main.Rows[0]["Name"].ToString();
				}
				exSheet.Range["A13:E13"].Font.Bold = true;
				exSheet.Range["A13"].Value = "STT ";
				exSheet.Range["B13"].Value = "ProductName ";
				exSheet.Range["B13"].ColumnWidth = 25;
				exSheet.Range["C13"].Value = "Qty ";
				exSheet.Range["C13"].ColumnWidth = 5;
				exSheet.Range["D13"].Value = "Price ";
				exSheet.Range["D13"].ColumnWidth = 20;
				exSheet.Range["E13"].Value = "Amount ";
				exSheet.Range["E13"].ColumnWidth = 20;
				int hang = 13;
				for (int i = 0; i < Main.Rows.Count; i++)
				{
					hang++;
					exSheet.Range["A" + hang.ToString()].Value = (i + 1).ToString();
					exSheet.Range["B" + hang.ToString()].Value = Main.Rows[i]["nameFood"];
					exSheet.Range["C" + hang.ToString()].Value = Main.Rows[i]["qty"];
					exSheet.Range["D" + hang.ToString()].Value = Main.Rows[i]["price"];
					exSheet.Range["E" + hang.ToString()].Value = Main.Rows[i]["amount"];

				}
				exSheet.Range["E" + (hang + 1).ToString()].Value = "Total: " + Main.Rows[0]["total"];
				exSheet.Range["E" + (hang + 2).ToString()].Value = "Received: " + Main.Rows[0]["received"];
				exSheet.Range["E" + (hang + 3).ToString()].Value = "Change: " + Main.Rows[0]["change"];
				exBook.Activate();
				SaveFileDialog save = new SaveFileDialog();
				save.Filter = "Excel 97-2002 Workbook|*.xls|Excel Workbook|*.xlsx|All file|*.*";
				save.FilterIndex = 2;
				if (save.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("Save Successful");
					exBook.SaveAs(save.FileName.ToLower());
				}
				exApp.Quit();
			}

		}

        private void ChooseDate_ValueChanged(object sender, EventArgs e)
        {
			LoadData();
        }
    }
}
