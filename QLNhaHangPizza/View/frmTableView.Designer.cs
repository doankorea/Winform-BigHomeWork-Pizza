namespace QLNhaHangPizza.View
{
    partial class frmTableView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtSearchTable = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnAddTable = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridViewItem = new System.Windows.Forms.DataGridView();
			this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
			this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnAddTable)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 127);
			this.panel1.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.panel5.Controls.Add(this.panel3);
			this.panel5.Controls.Add(this.panel4);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(900, 127);
			this.panel5.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtSearchTable);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(247, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(653, 127);
			this.panel3.TabIndex = 7;
			// 
			// txtSearchTable
			// 
			this.txtSearchTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.txtSearchTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearchTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchTable.ForeColor = System.Drawing.Color.White;
			this.txtSearchTable.Location = new System.Drawing.Point(338, 48);
			this.txtSearchTable.Name = "txtSearchTable";
			this.txtSearchTable.Size = new System.Drawing.Size(226, 30);
			this.txtSearchTable.TabIndex = 6;
			this.txtSearchTable.TextChanged += new System.EventHandler(this.txtSearchTable_TextChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::QLNhaHangPizza.Properties.Resources.SearchIcon;
			this.pictureBox2.Location = new System.Drawing.Point(302, 48);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(334, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnAddTable);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(247, 127);
			this.panel4.TabIndex = 6;
			// 
			// btnAddTable
			// 
			this.btnAddTable.Image = global::QLNhaHangPizza.Properties.Resources.AddIcon;
			this.btnAddTable.Location = new System.Drawing.Point(3, 26);
			this.btnAddTable.Name = "btnAddTable";
			this.btnAddTable.Size = new System.Drawing.Size(67, 67);
			this.btnAddTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnAddTable.TabIndex = 3;
			this.btnAddTable.TabStop = false;
			this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(76, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Table List";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			this.panel2.Controls.Add(this.dataGridViewItem);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 127);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(900, 520);
			this.panel2.TabIndex = 1;
			// 
			// dataGridViewItem
			// 
			this.dataGridViewItem.AllowUserToAddRows = false;
			this.dataGridViewItem.AllowUserToDeleteRows = false;
			this.dataGridViewItem.AllowUserToOrderColumns = true;
			this.dataGridViewItem.AllowUserToResizeColumns = false;
			this.dataGridViewItem.AllowUserToResizeRows = false;
			this.dataGridViewItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			this.dataGridViewItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridViewItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewItem.ColumnHeadersHeight = 29;
			this.dataGridViewItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvedit,
            this.dgvdel});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewItem.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewItem.EnableHeadersVisualStyles = false;
			this.dataGridViewItem.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridViewItem.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewItem.Name = "dataGridViewItem";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewItem.RowHeadersVisible = false;
			this.dataGridViewItem.RowHeadersWidth = 51;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewItem.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewItem.RowTemplate.Height = 24;
			this.dataGridViewItem.Size = new System.Drawing.Size(900, 520);
			this.dataGridViewItem.TabIndex = 6;
			this.dataGridViewItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItem_CellClick);
			// 
			// dgvID
			// 
			this.dgvID.HeaderText = "ID";
			this.dgvID.MinimumWidth = 6;
			this.dgvID.Name = "dgvID";
			this.dgvID.ReadOnly = true;
			this.dgvID.Width = 125;
			// 
			// dgvName
			// 
			this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvName.HeaderText = "Name";
			this.dgvName.MinimumWidth = 6;
			this.dgvName.Name = "dgvName";
			this.dgvName.ReadOnly = true;
			// 
			// dgvedit
			// 
			this.dgvedit.FillWeight = 50F;
			this.dgvedit.HeaderText = "";
			this.dgvedit.Image = global::QLNhaHangPizza.Properties.Resources.EditIcon;
			this.dgvedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dgvedit.MinimumWidth = 50;
			this.dgvedit.Name = "dgvedit";
			this.dgvedit.Width = 50;
			// 
			// dgvdel
			// 
			this.dgvdel.FillWeight = 50F;
			this.dgvdel.HeaderText = "";
			this.dgvdel.Image = global::QLNhaHangPizza.Properties.Resources.DeleteIcon;
			this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dgvdel.MinimumWidth = 50;
			this.dgvdel.Name = "dgvdel";
			this.dgvdel.Width = 50;
			// 
			// frmTableView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 647);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTableView";
			this.Text = "frmTableView";
			this.Load += new System.EventHandler(this.frmTableView_Load);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnAddTable)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox btnAddTable;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchTable;
        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}