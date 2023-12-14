using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using QLNhaHangPizza.DAO;
using QLNhaHangPizza.Model;
using System.Collections.Generic;
using System.Linq;

namespace QlyNhaHangPizza.Model
{
    public partial class frmPOS : Form
    {
        QLNhaHangPizza.DAO.DataProvider dtBase = new QLNhaHangPizza.DAO.DataProvider();

        public int mainID = 0;
        public string OderType = "";
        public string customerName = "";
        public string customerPhone = "";
        public string customerAddress = "";
        public frmPOS()
        {
            InitializeComponent();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            lblDriverName.Text = "";
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnNew);
            CCB.Resetcolor(btnBillList);
            CCB.Resetcolor(btnDelivery);
            CCB.Resetcolor(btnHold);
            CCB.Resetcolor(btnKOT);
            CCB.Resetcolor(btnDinein);
            CCB.Resetcolor(btnTakeaway);
            lblTable.Text = " ";
            lblWaiter.Text = " ";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            dataGridViewItem.Rows.Clear();
            mainID = 0;
            lblTotal.Text = "0.00";
        }


        public int id = 0;
        private void btnBillList_Click(object sender, EventArgs e)
        {
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnBillList);
            CCB.Resetcolor(btnNew);
            CCB.Resetcolor(btnDelivery);
            CCB.Resetcolor(btnHold);
            CCB.Resetcolor(btnKOT);
            CCB.Resetcolor(btnDinein);
            CCB.Resetcolor(btnTakeaway);
            frmBillList frmBL = new frmBillList();
            DataProvider.BlurBackground(frmBL);
            if (frmBL.MainID > 0)
            {
                mainID = frmBL.MainID;
                OderType = frmBL.OderType;
                btnCheckOut.Enabled = true;
                LoadEntries();
            }
        }
        private void LoadEntries()
        {
            string query = "";
            if (OderType == "Delivery" || OderType == "TakeAway")
            {
                query = @"Select * from tblMain as m
                             inner join tblDetails as d on m.MainID = d.MainID
                             inner join tFood as f on f.idFood = d.proID
                             where m.MainID = " + mainID + "";

            }
            else
            {
                query = @"Select * from tblMain as m
                             inner join tblDetails as d on m.MainID = d.MainID
                             inner join tFood as f on f.idFood = d.proID
                             inner join tTable as t on t.idTable = m.idTable
                             inner join tStaff as s on s.idStaff = m.idStaff 
                             where m.MainID = " + mainID + "";
            }
            DataTable dt2 = dtBase.DocBang(query);
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
                {
                    ChangeColorBtn CCB = new ChangeColorBtn();
                    CCB.Changecolor(btnDelivery);
                    OderType = "Delivery";

                    lblWaiter.Visible = false;
                    lblTable.Visible = false;
                }
                if (dt2.Rows[0]["orderType"].ToString() == "Dine in")
                {
                    ChangeColorBtn CCB = new ChangeColorBtn();
                    CCB.Changecolor(btnDinein);
                    OderType = "Dine in";
                    lblWaiter.Visible = true;
                    lblTable.Visible = true;
                }
                if (dt2.Rows[0]["orderType"].ToString() == "TakeAway")
                {
                    ChangeColorBtn CCB = new ChangeColorBtn();
                    CCB.Changecolor(btnTakeaway);
                    OderType = "TakeAway";
                    lblWaiter.Visible = false;
                    lblTable.Visible = false;
                }

                dataGridViewItem.Rows.Clear();
                foreach (DataRow item in dt2.Rows)
                {
                    if (dt2.Rows[0]["orderType"].ToString() == "Dine in")
                    {
                        lblTable.Text = item["nameTable"].ToString();
                        lblWaiter.Text = item["Name"].ToString();
                    }
                    string detailid = item["DetailID"].ToString();
                    string proName = item["nameFood"].ToString();
                    string proid = item["proID"].ToString();
                    string qty = item["qty"].ToString();
                    string price = item["price"].ToString();
                    string amount = item["amount"].ToString();
                    object[] obj = { detailid, proid, proName, qty, price, amount };
                    dataGridViewItem.Rows.Add(obj);
                }
                GetTotal();
            }
            else
            {
                Console.WriteLine("DataTable is empty.");
            }

        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnHold);
            CCB.Resetcolor(btnBillList);
            CCB.Resetcolor(btnDelivery);
            CCB.Resetcolor(btnNew);
            CCB.Resetcolor(btnKOT);
            CCB.Resetcolor(btnDinein);
            CCB.Resetcolor(btnTakeaway);

            string query1 = "";
            string query2 = "";
            int detailID = 0;
            if (dataGridViewItem.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one item to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OderType == "")
            {
                MessageBox.Show("Please select Order Type", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mainID == 0) // Insert
            {
                query1 = @"Insert into tblMain Values (@aDate, @aTime, @idTable, @idStaff, @status, @orderType, @total, @received, @change, @cusName, @cusPhone, @cusAddress);
                  select SCOPE_IDENTITY()";
                string query1_1 = @"Select idTable from tTable where nameTable = N'" + lblTable.Text + "'";
                object idt = dtBase.ExecuteScalar(query1_1);
                string query1_2 = @"Select idTable from tTable where nameTable = N'" + lblTable.Text + "'";
                object ids = dtBase.ExecuteScalar(query1_2);
                Hashtable ht1 = new Hashtable();
                ht1.Add("@aDate", DateTime.Now.ToString());
                ht1.Add("@aTime", DateTime.Now.ToShortTimeString());
                if (OderType == "Delivery" || OderType == "TakeAway")
                {
                    // Gán giá trị NULL cho idTable và idStaff
                    ht1.Add("@idTable", DBNull.Value);
                    ht1.Add("@idStaff", DBNull.Value);
                }
                else
                {
                    ht1.Add("@idTable", Convert.ToInt32(idt));
                    ht1.Add("@idStaff", Convert.ToInt32(ids));
                }
                ht1.Add("@status", "pending");
                ht1.Add("@orderType", OderType);
                ht1.Add("@total", Convert.ToDouble(lblTotal.Text));
                ht1.Add("@received", Convert.ToDouble(0));
                ht1.Add("@change", Convert.ToDouble(0));
                ht1.Add("@cusName", customerName);
                ht1.Add("@cusPhone", customerPhone);
                ht1.Add("@cusAddress", customerAddress);

                object result = dtBase.ExecuteScalar(query1, ht1);

                if (result != null && result != DBNull.Value)
                {
                    mainID = Convert.ToInt32(result);
                }
            }
            else // Update
            {
                query1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change where MainID = @ID";

                Hashtable ht1 = new Hashtable();
                ht1.Add("@ID", mainID);
                ht1.Add("@status", "hold");
                ht1.Add("@total", Convert.ToDouble(lblTotal.Text));
                ht1.Add("@received", Convert.ToDouble(0));
                ht1.Add("@change", Convert.ToDouble(0));

                object result = dtBase.CapNhatDuLieu(query1, ht1);
            }

            foreach (DataGridViewRow item in dataGridViewItem.Rows)
            {
                detailID = Convert.ToInt32(item.Cells["dgvID"].Value);

                if (detailID == 0)
                {
                    query2 = @"insert into tblDetails values(@MainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    query2 = @"update tblDetails set MainID = @MainID, proID = @proID, qty = @qty, price = @price, amount = @amount
                      where DetailID = @ID";
                }

                Hashtable ht2 = new Hashtable();
                ht2.Add("@ID", detailID);
                ht2.Add("@MainID", mainID);
                ht2.Add("@proID", Convert.ToInt32(item.Cells["dgvproID"].Value));
                ht2.Add("@qty", Convert.ToInt32(item.Cells["dgvQty"].Value));
                ht2.Add("@price", Convert.ToDouble(item.Cells["dgvPrice"].Value));
                ht2.Add("@amount", Convert.ToDouble(item.Cells["dgvAmount"].Value));

                object result = dtBase.ExecuteScalar(query2, ht2);
            }

            DialogResult result1 = MessageBox.Show("Save Successfully", "Inform", MessageBoxButtons.OK);

            mainID = 0;
            detailID = 0;
            dataGridViewItem.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnKOT);
            CCB.Resetcolor(btnBillList);
            CCB.Resetcolor(btnDelivery);
            CCB.Resetcolor(btnHold);
            CCB.Resetcolor(btnNew);
            CCB.Resetcolor(btnDinein);
            CCB.Resetcolor(btnTakeaway);


            string query1 = "";
            string query2 = "";
            int detailID = 0;
            if (dataGridViewItem.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one item to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OderType == "")
            {
                MessageBox.Show("Please select Order Type", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mainID == 0) // Insert
            {

                query1 = @"Insert into tblMain Values (@aDate, @aTime, @idTable, @idStaff, @status, @orderType, @total, @received, @change, @cusName, @cusPhone, @cusAddress);
                  select SCOPE_IDENTITY()";
                string query1_1 = @"Select idTable from tTable where nameTable = N'" + lblTable.Text + "'";
                object idt = dtBase.ExecuteScalar(query1_1);
                string query1_2 = @"Select idStaff from tStaff where Name = N'" + lblWaiter.Text + "'";
                object ids = dtBase.ExecuteScalar(query1_2);
                Hashtable ht1 = new Hashtable();

                ht1.Add("@aDate", DateTime.Now);
                ht1.Add("@aTime", DateTime.Now.ToShortTimeString());
                if (OderType == "Delivery" || OderType == "TakeAway")
                {
                    // Gán giá trị NULL cho idTable và idStaff
                    ht1.Add("@idTable", DBNull.Value);
                    ht1.Add("@idStaff", DBNull.Value);
                }
                else
                {
                    ht1.Add("@idTable", Convert.ToInt32(idt));
                    ht1.Add("@idStaff", Convert.ToInt32(ids));
                }
                ht1.Add("@status", "pending");
                ht1.Add("@orderType", OderType);
                ht1.Add("@total", Convert.ToDouble(lblTotal.Text));
                ht1.Add("@received", Convert.ToDouble(0));
                ht1.Add("@change", Convert.ToDouble(0));
                ht1.Add("@cusName", customerName);
                ht1.Add("@cusPhone", customerPhone);
                ht1.Add("@cusAddress", customerAddress);

                object result = dtBase.ExecuteScalar(query1, ht1);

                if (result != null && result != DBNull.Value)
                {
                    mainID = Convert.ToInt32(result);
                }
            }
            else // Update
            {
                query1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change where MainID = @ID";

                Hashtable ht1 = new Hashtable();
                ht1.Add("@ID", mainID);
                ht1.Add("@status", "pending");
                ht1.Add("@total", Convert.ToDouble(lblTotal.Text));
                ht1.Add("@received", Convert.ToDouble(0));
                ht1.Add("@change", Convert.ToDouble(0));

                object result = dtBase.CapNhatDuLieu(query1, ht1);
            }

            foreach (DataGridViewRow item in dataGridViewItem.Rows)
            {
                detailID = Convert.ToInt32(item.Cells["dgvID"].Value);

                if (detailID == 0)
                {
                    // Insert mới
                    query2 = @"insert into tblDetails values(@MainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    query2 = @"update tblDetails set MainID = @MainID, proID = @proID, qty = @qty, price = @price, amount = @amount
          where DetailID = @ID";
                }

                Hashtable ht2 = new Hashtable();
                ht2.Add("@ID", detailID);
                ht2.Add("@MainID", mainID);
                ht2.Add("@proID", Convert.ToInt32(item.Cells["dgvproID"].Value));
                ht2.Add("@qty", Convert.ToInt32(item.Cells["dgvQty"].Value));
                ht2.Add("@price", Convert.ToDouble(item.Cells["dgvPrice"].Value));
                ht2.Add("@amount", Convert.ToDouble(item.Cells["dgvAmount"].Value));

                object result = dtBase.ExecuteScalar(query2, ht2);
            }


            DialogResult result1 = MessageBox.Show("Save Successfully", "Inform", MessageBoxButtons.OK);

            mainID = 0;
            detailID = 0;
            dataGridViewItem.Rows.Clear();
            lblTable.Text = " ";
            lblWaiter.Text = " ";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
        }



        private void btnDelivery_Click(object sender, EventArgs e)
        {           
            btnKOT.Enabled = true;
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnDelivery);
            CCB.Resetcolor(btnBillList);
            CCB.Resetcolor(btnNew);
            CCB.Resetcolor(btnHold);
            CCB.Resetcolor(btnKOT);
            CCB.Resetcolor(btnDinein);
            CCB.Resetcolor(btnTakeaway);
            lblTable.Text = " ";
            lblWaiter.Text = " ";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OderType = "Delivery";
            frmAddCustomer frm = new frmAddCustomer();
            frm.OderType = OderType;
            DataProvider.BlurBackground(frm);
            if (frm.txtName.Text != "")
            {
                lblDriverName.Text = "Customer name: " + frm.txtName.Text + " - PhoneNumber: " + frm.txtPhoneNumber.Text + " - Driver: " + frm.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhoneNumber.Text;
                customerAddress = frm.txtAddress.Text;
            }

        }

        private void btnTakeaway_Click(object sender, EventArgs e)
        {
            btnKOT.Enabled = true;
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnTakeaway);
            CCB.Resetcolor(btnBillList);
            CCB.Resetcolor(btnNew);
            CCB.Resetcolor(btnHold);
            CCB.Resetcolor(btnKOT);
            CCB.Resetcolor(btnDinein);
            CCB.Resetcolor(btnDelivery);
            lblTable.Text = " ";
            lblWaiter.Text = " ";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OderType = "TakeAway";
            frmAddCustomer frm = new frmAddCustomer();
            frm.MainID = mainID;
            frm.OderType = OderType;
            DataProvider.BlurBackground(frm);
            if (frm.txtName.Text != "")
            {
                lblDriverName.Text = "Customer name: " + frm.txtName.Text + " - PhoneNumber: " + frm.txtPhoneNumber.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhoneNumber.Text;
                customerAddress = frm.txtAddress.Text;
            }
        }

        private void btnDinein_Click(object sender, EventArgs e)
        {
            lblDriverName.Text = "";
            btnKOT.Enabled = true;
            ChangeColorBtn CCB = new ChangeColorBtn();
            CCB.Changecolor(btnDinein);
            CCB.Resetcolor(btnBillList);
            CCB.Resetcolor(btnNew);
            CCB.Resetcolor(btnHold);
            CCB.Resetcolor(btnKOT);
            CCB.Resetcolor(btnDelivery);
            CCB.Resetcolor(btnTakeaway);

            OderType = "Dine in";
            lblTable.Visible = false;
            frmWaiterSelect frm = new frmWaiterSelect();
            QLNhaHangPizza.DAO.DataProvider.BlurBackground(frm);

            if (frm.waiterName != "")
            {
                lblWaiter.Text = frm.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
            frmTableSelect frm1 = new frmTableSelect();
            QLNhaHangPizza.DAO.DataProvider.BlurBackground(frm1);
            if (frm1.tableName != "")
            {
                lblTable.Text = frm1.tableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadFood();
            btnCheckOut.Enabled = false;
        }
        private void AddCategory()
        {
            DataTable dt = dtBase.DocBang("SELECT * FROM tFoodCategory");
            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                Button btnAll = new Button();
                btnAll.BackColor = Color.FromArgb(0xC8, 0x50, 0xF2);
                btnAll.FlatAppearance.BorderColor = Color.FromArgb(28, 26, 36);
                btnAll.Text = "All Products";
                btnAll.Size = new Size(184, 64);
                btnAll.ForeColor = Color.White;
                CategoryPanel.Controls.Add(btnAll);

                btnAll.Click += new EventHandler(btnAll_click);
                foreach (DataRow row in dt.Rows)
                {
                    Button btnCategory = new Button();
                    btnCategory.BackColor = Color.FromArgb(0xC8, 0x50, 0xF2);
                    btnCategory.FlatAppearance.BorderColor = Color.FromArgb(28, 26, 36);
                    btnCategory.Text = row["nameCategory"].ToString();
                    btnCategory.Size = new Size(184, 64);
                    btnCategory.ForeColor = Color.White;
                    CategoryPanel.Controls.Add(btnCategory);
                    btnCategory.Click += new EventHandler(btnCategory_click);
                }

            }
        }
        private void btnAll_click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadFood();
        }
        private void btnCategory_click(object sender, EventArgs e)
        {
            Button clickedCategoryButton = (Button)sender;
            string categoryName = clickedCategoryButton.Text;

            DataTable dt = dtBase.DocBang("SELECT * FROM tFood INNER JOIN tFoodCategory ON tFood.idCategory = tFoodCategory.idCategory WHERE tFoodCategory.nameCategory = N'" + categoryName + "'");

            if (dt != null && dt.Rows.Count > 0)
            {
                ProductPanel.Controls.Clear(); // Xóa các sản phẩm hiện tại trước khi thêm sản phẩm mới.

                foreach (DataRow item in dt.Rows)
                {
                    string imageName = item["avtFood"].ToString();
                    string imagePath = Path.Combine(Application.StartupPath, "ImagesProduct", imageName);

                    AddFood(0, int.Parse(item["idFood"].ToString()), item["nameFood"].ToString(), int.Parse(item["idCategory"].ToString()), float.Parse(item["priceFood"].ToString()), imagePath);
                }
            }
            else
            {
                Console.WriteLine("DataTable is empty.");
            }
        }


        private void AddFood(int id, int proID, string name, int idCategory, float price, string imgPath)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = idCategory,
                ImagePath = imgPath,
                id = Convert.ToInt32(proID),
            };
            w.LoadImage();
            ProductPanel.Controls.Add(w);
            ProductPanel.Refresh();
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                bool itemFound = false;

                foreach (DataGridViewRow item in dataGridViewItem.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        int newQty = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        double newAmount = newQty * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        item.Cells["dgvQty"].Value = newQty;
                        item.Cells["dgvAmount"].Value = newAmount;
                        itemFound = true;
                        break;
                    }
                }

                if (!itemFound)
                {
                    int rowIndex = dataGridViewItem.Rows.Add(new object[] { 0, wdg.id, wdg.PName, wdg.PCategory, wdg.PPrice, wdg.PPrice });
                    dataGridViewItem.Rows[rowIndex].Cells["dgvproID"].Value = wdg.id;
                    dataGridViewItem.Rows[rowIndex].Cells["dgvQty"].Value = 1;
                    dataGridViewItem.Rows[rowIndex].Cells["dgvAmount"].Value = wdg.PPrice;
                }

                ProductPanel.Refresh(); // Cập nhật giao diện
                GetTotal();
            };




        }

        public void LoadFood()
        {
            DataTable dt = dtBase.DocBang("Select * from tFood inner join tFoodCategory on tFood.idCategory = tFoodCategory.idCategory order by tFoodCategory.idCategory");

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    string imageName = item["avtFood"].ToString(); // Assuming the column is named "avtFood"
                    string imagePath = Path.Combine(Application.StartupPath, "ImagesProduct", imageName);

                    if (!string.IsNullOrEmpty(imageName) && File.Exists(imagePath))
                    {
                        AddFood(0, int.Parse(item["idFood"].ToString()), item["nameFood"].ToString(), int.Parse(item["idCategory"].ToString()), float.Parse(item["priceFood"].ToString()), imagePath);

                    }
                    else
                    {
                        AddFood(0, int.Parse(item["idFood"].ToString()), item["nameFood"].ToString(), int.Parse(item["idCategory"].ToString()), float.Parse(item["priceFood"].ToString()), null);
                    }
                }
            }
            else
            {
                Console.WriteLine("DataTable is empty.");
            }
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());
            }
        }
        private void GetTotal()
        {
            float total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in dataGridViewItem.Rows)
            {
                total += float.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = total.ToString("N2");
        }

        private void dataGridViewItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewItem.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(49, 47, 61);
            Color headerBackgroundColor = Color.FromArgb(40, 38, 51);
            dataGridViewItem.ColumnHeadersDefaultCellStyle.BackColor = headerBackgroundColor;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.mainID = mainID;
            if(mainID == 0)
            {
                MessageBox.Show("Please choose a bill !!!");
                return;
            }
            string query = "Select * from tblMain where mainID = " + mainID;
            DataTable dt = dtBase.DocBang(query);
            if (dt.Rows[0]["status"].ToString() == "Paid")
            {
                MessageBox.Show("This bill paid !!!");
                return;
            }
            frm.amt = Convert.ToDouble(lblTotal.Text);
            DataProvider.BlurBackground(frm);
            mainID = 0;
            dataGridViewItem.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblTable.Text = "";
            lblDriverName.Text = "";
        }
        private void dataGridViewItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewItem.Rows[e.RowIndex];
                int mID = mainID;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product? ", "Inform", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridViewItem.Rows.Remove(selectedRow);
                    GetTotal();
                    if (decimal.TryParse(lblTotal.Text.Replace(",", ""), out decimal totalValue))
                    {
                        Console.WriteLine(totalValue.ToString());
                        string proIDToDelete = selectedRow.Cells[dataGridViewItem.Columns["dgvproID"].Index].Value.ToString();

                        string queryDelete = "DELETE FROM tblDetails WHERE MainID = " + mID + " AND proID = " + proIDToDelete;
                        string queryUpdateTotal = "UPDATE tblMain SET total = " + totalValue + " WHERE MainID = " + mID;
                        dtBase.CapNhatDuLieu(queryDelete);
                        dtBase.CapNhatDuLieu(queryUpdateTotal);
                    }
                    else
                    {
                        Console.WriteLine("Cannot convert to decimal !!!");
                    }
                }
            }

        }
    }
}

