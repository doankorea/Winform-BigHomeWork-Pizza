using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLNhaHangPizza.View
{
    public partial class frmReportView : Form
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();

        public frmReportView()
        {
            InitializeComponent();
            dateTime1.Format = DateTimePickerFormat.Custom;
            dateTime1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTime1.Value = DateTime.Today;
            dateTime2.Format = DateTimePickerFormat.Custom;
            dateTime2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTime2.Value = DateTime.Now;

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime selectedStartDate = dateTime1.Value;
            string StartdateString = selectedStartDate.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime selectedEndDate = dateTime2.Value;
            string EnddateString = selectedEndDate.ToString("yyyy-MM-dd HH:mm:ss");

            if(selectedStartDate > selectedEndDate)
            {
                MessageBox.Show("The start date must be less than the end date");
                return;
            }
            if (DateTime.Now < selectedEndDate)
            {
                MessageBox.Show("The end date cannot be greater than the current date");
                return;
            }
            string query3 = "SELECT nameCategory FROM tFoodCategory";

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

            exSheet.Range["D4"].Value = "SALES REPORT";
            exSheet.Range["D4"].Font.Size = 25;
            exSheet.Range["D4"].Font.Bold = true;

            exSheet.Range["A6"].Value = "Date: " + StartdateString + " to " + EnddateString;
            DataTable Main3 = dtBase.DocBang(query3);

            int hang = 7;
            string query0 = $"Select sum(amount) as Total from tblMain as m inner join tblDetails as d on m.MainID = d.MainID inner join tFood p on p.idFood = d.proID\r\ninner join tFoodCategory c on c.idCategory = p.idCategory";
            DataTable dataTable = dtBase.DocBang(query0);
            for (int i = 0; i < Main3.Rows.Count; i++)
            {
                string categoryName = Main3.Rows[i]["nameCategory"].ToString();

                string query1 = $"SELECT ROW_NUMBER() OVER(ORDER BY p.nameFood) AS STT, p.nameFood, SUM(d.qty) as Qty, SUM(d.amount) as Amount FROM tblMain as m INNER JOIN tblDetails as d ON m.MainID = d.MainID INNER JOIN tFood p ON p.idFood = d.proID INNER JOIN tFoodCategory c ON c.idCategory = p.idCategory WHERE m.aDate BETWEEN @sdate AND @edate AND c.nameCategory = N'{categoryName}' GROUP BY p.nameFood";
                string query2 = $"Select sum(amount) as Total from tblMain as m inner join tblDetails as d on m.MainID = d.MainID inner join tFood p on p.idFood = d.proID\r\ninner join tFoodCategory c on c.idCategory = p.idCategory where c.nameCategory = N'{categoryName}'";
                DataTable Main2 = dtBase.DocBang(query2, new object[] { StartdateString, EnddateString });
                DataTable Main = dtBase.DocBang(query1, new object[] { StartdateString, EnddateString });

                exSheet.Range["A" + (hang + 1).ToString()].Value = categoryName;
                exSheet.Range["A" + (hang + 1).ToString()].Font.Size = 15;

                if (Main.Rows.Count > 0)
                {
                    exSheet.Range["A" + (hang + 2).ToString()].Value = "STT";
                    exSheet.Range["B" + (hang + 2).ToString()].Value = "NameFood";
                    exSheet.Range["C" + (hang + 2).ToString()].Value = "Qty";
                    exSheet.Range["D" + (hang + 2).ToString()].Value = "Amount";
                    int sum = 0;
                    for (int j = 0; j < Main.Rows.Count; j++)
                    {
                        exSheet.Range["A" + (hang + j + 3).ToString()].Value = Main.Rows[j]["STT"];
                        exSheet.Range["B" + (hang + j + 3).ToString()].Value = Main.Rows[j]["nameFood"];
                        exSheet.Range["B" + (hang + j + 3).ToString()].ColumnWidth = 25;

                        exSheet.Range["C" + (hang + j + 3).ToString()].Value = Main.Rows[j]["Qty"];
                        exSheet.Range["D" + (hang + j + 3).ToString()].Value = Main.Rows[j]["Amount"];
                    }

                        sum = sum + int.Parse(Main2.Rows[0]["Total"].ToString());
                        exSheet.Range["C" + (hang + Main.Rows.Count + 3).ToString()].Value = $"Total ({categoryName}): " + sum;  
                }
                else
                {

                }



                hang += Main.Rows.Count + 4 ; 
            }
            exSheet.Range["C" + (hang + 1).ToString()].Value = $"Total: " + dataTable.Rows[0]["Total"];
            exSheet.Range["C" + (hang + 1).ToString()].Font.Size = 20;
            exSheet.Range["C" + (hang + 1).ToString()].Font.Bold = true;

            exBook.Activate();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002 Workbook|*.xls|Excel Workbook|*.xlsx|All files|*.*";
            save.FilterIndex = 2;

            if (save.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Save Successful");
                exBook.SaveAs(save.FileName.ToLower());
            }

            exApp.Quit();
        }

        private void dateTime2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime2.Value < DateTime.Today)
            {
                dateTime2.Value = new DateTime(dateTime2.Value.Year, dateTime2.Value.Month, dateTime2.Value.Day, 23, 59, 59);

            }
            else
            {
                dateTime2.Value = DateTime.Now;
            }
        }
    }
}