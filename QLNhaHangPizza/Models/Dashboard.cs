using QLNhaHangPizza.DAO;
using QLNhaHangPizza.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNhaHangPizza.Models
{

    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard
    {
        DAO.DataProvider dtBase = new DAO.DataProvider();
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int NumCustomers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> Outstandingemployee { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        //Constructor
        public Dashboard()
        {
        }
        //Private methods
        private void GetNumberItems()
        {
            string query = "select count(CusPhone) as numcus from tblMain";
            DataTable result = dtBase.DocBang(query);
            if (result.Rows.Count > 0)
            {
                NumCustomers = (int)result.Rows[0]["numcus"];
            }
            string query2 = "select count(idFood) as numpro from tFood";
            DataTable result2 = dtBase.DocBang(query2);
            if (result2.Rows.Count > 0)
            {
                NumProducts = (int)result2.Rows[0]["numpro"];
            }
            string query3 = "select count(MainID) as numorder from tblMain where aDate between  '" + startDate.ToString() + "' and '" + endDate.ToString() + "'";
            DataTable result3 = dtBase.DocBang(query3);
            if (result3.Rows.Count > 0)
            {
                NumOrders = (int)result3.Rows[0]["numorder"];
            }


        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            Outstandingemployee = new List<KeyValuePair<string, int>>();

            string query = @"select s.Name as name, count(m.MainID) as totalbill
											from tStaff as s join tblMain as m on s.idStaff= m.idStaff
											group by s.Name
											order by count(MainID) desc";
            DataTable result = dtBase.DocBang(query);
            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    Outstandingemployee.Add(
                            new KeyValuePair<string, int>((string)row[0], (int)row[1]));
                }
            }


            string query2 = "select top 5 f.nameFood as namefood, SUM(dt.qty) as qty from tblDetails as dt inner join tFood as f on dt.proID= f.idFood join tblMain as m on m.MainID= dt.MainID where aDate  between  '" + startDate.ToString() + "' and '" + endDate.ToString() + "' group by f.nameFood, dt.qty order by dt.qty desc ";
            DataTable result2 = dtBase.DocBang(query2);
            if (result2.Rows.Count > 0)
            {
                foreach (DataRow row in result2.Rows)
                {
                    TopProductsList.Add(new KeyValuePair<string, int>((string)row[0], (int)row[1]));
                }
            }





        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            string query = "SELECT CAST(aDate AS datetime) , CAST(SUM(total) AS DECIMAL) AS totalmoney " +
               "FROM tblMain " +
               "WHERE aDate BETWEEN @startDate AND @endDate " +
               "AND CAST(LTRIM(RTRIM(LEFT(aTime, 5))) AS TIME) BETWEEN '00:00:00' AND '23:59:59'  " +
               "GROUP BY aDate;";
            Object[] parameters =
            {
                    startDate ,endDate/*,TimeSpan.Parse(startDate.ToString("HH:mm:ss")),TimeSpan.Parse(endDate.ToString("HH:mm:ss"))*/
	
			};

            DataTable result = dtBase.DocBang(query, parameters);
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();
            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    DateTime dateValue = (DateTime)row[0];
                    decimal totalMoneyValue = (decimal)row[1];
                    resultTable.Add(new KeyValuePair<DateTime, decimal>(dateValue, totalMoneyValue));
                    TotalRevenue += totalMoneyValue;
                }

            }

            TotalProfit = TotalRevenue * 0.2m; // 20%

            // Group by Hours
            if (numberDays <= 1)
            {
                GrossRevenueList = resultTable
                    .GroupBy(orderList => orderList.Key.ToString("hh tt"))
                    .Select(order => new RevenueByDate
                    {
                        Date = order.Key,
                        TotalAmount = order.Sum(amount => amount.Value)
                    })
                    .ToList();
            }
            // Group by Days
            else if (numberDays <= 30)
            {
                GrossRevenueList = resultTable
                    .GroupBy(orderList => orderList.Key.ToString("dd MMM"))
                    .Select(order => new RevenueByDate
                    {
                        Date = order.Key,
                        TotalAmount = order.Sum(amount => amount.Value)
                    })
                    .ToList();
            }
            // Group by Weeks
            else if (numberDays <= 92)
            {
                GrossRevenueList = resultTable
                    .GroupBy(orderList => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString())
                    .Select(order => new RevenueByDate
                    {
                        Date = "Week " + order.Key,
                        TotalAmount = order.Sum(amount => amount.Value)
                    })
                    .ToList();
            }
            // Group by Months
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365;
                GrossRevenueList = resultTable
                    .GroupBy(orderList => orderList.Key.ToString("MMM yyyy").Substring(0, isYear ? 3 : 0))
                    .Select(order => new RevenueByDate
                    {
                        Date = order.Key,
                        TotalAmount = order.Sum(amount => amount.Value)
                    })
                    .ToList();
            }
            // Group by Years
            else
            {
                GrossRevenueList = resultTable
                    .GroupBy(orderList => orderList.Key.ToString("yyyy"))
                    .Select(order => new RevenueByDate
                    {
                        Date = order.Key,
                        TotalAmount = order.Sum(amount => amount.Value)
                    })
                    .ToList();
            }

        }
        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                            endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}