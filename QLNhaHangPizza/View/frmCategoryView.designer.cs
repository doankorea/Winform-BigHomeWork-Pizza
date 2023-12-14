namespace QlyNhaHangPizza
{
    partial class frmCategoryView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtSearchCategory = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAddCategory = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridViewItem = new System.Windows.Forms.DataGridView();
			this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
			this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(335, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(76, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Category List";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 127);
			this.panel1.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtSearchCategory);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(247, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(653, 127);
			this.panel3.TabIndex = 6;
			// 
			// txtSearchCategory
			// 
			this.txtSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.txtSearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearchCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchCategory.ForeColor = System.Drawing.Color.White;
			this.txtSearchCategory.Location = new System.Drawing.Point(339, 48);
			this.txtSearchCategory.Name = "txtSearchCategory";
			this.txtSearchCategory.Size = new System.Drawing.Size(226, 30);
			this.txtSearchCategory.TabIndex = 5;
			this.txtSearchCategory.TextChanged += new System.EventHandler(this.txtSearchCategory_TextChanged);
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
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAddCategory);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(247, 127);
			this.panel2.TabIndex = 5;
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Image = global::QLNhaHangPizza.Properties.Resources.AddIcon;
			this.btnAddCategory.Location = new System.Drawing.Point(3, 26);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(67, 67);
			this.btnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnAddCategory.TabIndex = 3;
			this.btnAddCategory.TabStop = false;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			this.panel4.Controls.Add(this.dataGridViewItem);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 127);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(900, 520);
			this.panel4.TabIndex = 6;
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
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewItem.ColumnHeadersHeight = 29;
			this.dataGridViewItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvedit,
            this.dgvdel});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewItem.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewItem.EnableHeadersVisualStyles = false;
			this.dataGridViewItem.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridViewItem.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewItem.Name = "dataGridViewItem";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewItem.RowHeadersVisible = false;
			this.dataGridViewItem.RowHeadersWidth = 51;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewItem.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewItem.RowTemplate.Height = 24;
			this.dataGridViewItem.Size = new System.Drawing.Size(900, 520);
			this.dataGridViewItem.TabIndex = 7;
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
			// frmCategoryView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(900, 647);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimizeBox = false;
			this.Name = "frmCategoryView";
			this.Text = "Header Text";
			this.Load += new System.EventHandler(this.frmCategoryView_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox btnAddCategory;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}