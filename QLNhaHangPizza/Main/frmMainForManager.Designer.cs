namespace QLNhaHangPizza.Main
{
    partial class frmMainForManager
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
			this.sidebar = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.picAnh = new fa_icon_demo.CustomControls.CircularPictureBox();
			this.UserName = new System.Windows.Forms.Label();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
			this.btnReports = new FontAwesome.Sharp.IconButton();
			this.btnKitchen = new FontAwesome.Sharp.IconButton();
			this.btnPos = new FontAwesome.Sharp.IconButton();
			this.btnStaff = new FontAwesome.Sharp.IconButton();
			this.btnTables = new FontAwesome.Sharp.IconButton();
			this.btnProducts = new FontAwesome.Sharp.IconButton();
			this.btnCategories = new FontAwesome.Sharp.IconButton();
			this.iconButton5 = new FontAwesome.Sharp.IconButton();
			this.btnHome = new FontAwesome.Sharp.IconButton();
			this.menusidebar = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.sidebar.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
			this.menusidebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// sidebar
			// 
			this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.sidebar.Controls.Add(this.panel2);
			this.sidebar.Controls.Add(this.btnReports);
			this.sidebar.Controls.Add(this.btnKitchen);
			this.sidebar.Controls.Add(this.btnPos);
			this.sidebar.Controls.Add(this.btnStaff);
			this.sidebar.Controls.Add(this.btnTables);
			this.sidebar.Controls.Add(this.btnProducts);
			this.sidebar.Controls.Add(this.btnCategories);
			this.sidebar.Controls.Add(this.iconButton5);
			this.sidebar.Controls.Add(this.btnHome);
			this.sidebar.Controls.Add(this.menusidebar);
			this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebar.Location = new System.Drawing.Point(0, 0);
			this.sidebar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new System.Drawing.Size(333, 950);
			this.sidebar.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.picAnh);
			this.panel2.Controls.Add(this.UserName);
			this.panel2.Controls.Add(this.iconButton4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 806);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(333, 144);
			this.panel2.TabIndex = 36;
			// 
			// picAnh
			// 
			this.picAnh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
			this.picAnh.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.picAnh.BorderColor2 = System.Drawing.SystemColors.ActiveCaptionText;
			this.picAnh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.picAnh.BorderSize = 2;
			this.picAnh.GradientAngle = 50F;
			this.picAnh.Location = new System.Drawing.Point(32, 16);
			this.picAnh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.picAnh.Name = "picAnh";
			this.picAnh.Size = new System.Drawing.Size(111, 111);
			this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAnh.TabIndex = 24;
			this.picAnh.TabStop = false;
			this.picAnh.Click += new System.EventHandler(this.circularPictureBox1_Click);
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.UserName.Location = new System.Drawing.Point(180, 38);
			this.UserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(97, 20);
			this.UserName.TabIndex = 25;
			this.UserName.Text = "UserName";
			this.UserName.Click += new System.EventHandler(this.UserName_Click);
			// 
			// iconButton4
			// 
			this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.iconButton4.FlatAppearance.BorderSize = 0;
			this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
			this.iconButton4.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton4.IconSize = 25;
			this.iconButton4.Location = new System.Drawing.Point(176, 63);
			this.iconButton4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Size = new System.Drawing.Size(115, 41);
			this.iconButton4.TabIndex = 26;
			this.iconButton4.Text = "Logout";
			this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.iconButton4.UseVisualStyleBackColor = false;
			this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
			// 
			// btnReports
			// 
			this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReports.FlatAppearance.BorderSize = 0;
			this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReports.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
			this.btnReports.IconColor = System.Drawing.Color.White;
			this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnReports.IconSize = 32;
			this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReports.Location = new System.Drawing.Point(0, 695);
			this.btnReports.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnReports.Name = "btnReports";
			this.btnReports.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnReports.Size = new System.Drawing.Size(333, 65);
			this.btnReports.TabIndex = 34;
			this.btnReports.Text = "    Reports";
			this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReports.UseVisualStyleBackColor = false;
			this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
			// 
			// btnKitchen
			// 
			this.btnKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnKitchen.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKitchen.FlatAppearance.BorderSize = 0;
			this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKitchen.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnKitchen.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
			this.btnKitchen.IconColor = System.Drawing.Color.White;
			this.btnKitchen.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnKitchen.IconSize = 32;
			this.btnKitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKitchen.Location = new System.Drawing.Point(0, 630);
			this.btnKitchen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnKitchen.Name = "btnKitchen";
			this.btnKitchen.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnKitchen.Size = new System.Drawing.Size(333, 65);
			this.btnKitchen.TabIndex = 33;
			this.btnKitchen.Text = "    Kitchen";
			this.btnKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKitchen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKitchen.UseVisualStyleBackColor = false;
			this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
			// 
			// btnPos
			// 
			this.btnPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnPos.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPos.FlatAppearance.BorderSize = 0;
			this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPos.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnPos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
			this.btnPos.IconColor = System.Drawing.Color.White;
			this.btnPos.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPos.IconSize = 32;
			this.btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPos.Location = new System.Drawing.Point(0, 565);
			this.btnPos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnPos.Name = "btnPos";
			this.btnPos.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnPos.Size = new System.Drawing.Size(333, 65);
			this.btnPos.TabIndex = 32;
			this.btnPos.Text = "    POS";
			this.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPos.UseVisualStyleBackColor = false;
			this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
			// 
			// btnStaff
			// 
			this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnStaff.FlatAppearance.BorderSize = 0;
			this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStaff.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
			this.btnStaff.IconColor = System.Drawing.Color.White;
			this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnStaff.IconSize = 32;
			this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStaff.Location = new System.Drawing.Point(0, 500);
			this.btnStaff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnStaff.Name = "btnStaff";
			this.btnStaff.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnStaff.Size = new System.Drawing.Size(333, 65);
			this.btnStaff.TabIndex = 31;
			this.btnStaff.Text = "    Staff";
			this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnStaff.UseVisualStyleBackColor = false;
			this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
			// 
			// btnTables
			// 
			this.btnTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnTables.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTables.FlatAppearance.BorderSize = 0;
			this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTables.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnTables.IconChar = FontAwesome.Sharp.IconChar.Th;
			this.btnTables.IconColor = System.Drawing.Color.White;
			this.btnTables.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnTables.IconSize = 32;
			this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTables.Location = new System.Drawing.Point(0, 435);
			this.btnTables.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnTables.Name = "btnTables";
			this.btnTables.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnTables.Size = new System.Drawing.Size(333, 65);
			this.btnTables.TabIndex = 30;
			this.btnTables.Text = "    Tables";
			this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTables.UseVisualStyleBackColor = false;
			this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProducts.FlatAppearance.BorderSize = 0;
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
			this.btnProducts.IconColor = System.Drawing.Color.White;
			this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnProducts.IconSize = 32;
			this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.Location = new System.Drawing.Point(0, 370);
			this.btnProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnProducts.Size = new System.Drawing.Size(333, 65);
			this.btnProducts.TabIndex = 29;
			this.btnProducts.Text = "    Products";
			this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProducts.UseVisualStyleBackColor = false;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnCategories
			// 
			this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCategories.FlatAppearance.BorderSize = 0;
			this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategories.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnCategories.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
			this.btnCategories.IconColor = System.Drawing.Color.White;
			this.btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCategories.IconSize = 32;
			this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCategories.Location = new System.Drawing.Point(0, 305);
			this.btnCategories.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnCategories.Size = new System.Drawing.Size(333, 65);
			this.btnCategories.TabIndex = 28;
			this.btnCategories.Text = "    Categories";
			this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCategories.UseVisualStyleBackColor = false;
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
			// 
			// iconButton5
			// 
			this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton5.FlatAppearance.BorderSize = 0;
			this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
			this.iconButton5.IconColor = System.Drawing.Color.White;
			this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton5.IconSize = 32;
			this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton5.Location = new System.Drawing.Point(0, 240);
			this.iconButton5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.iconButton5.Name = "iconButton5";
			this.iconButton5.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.iconButton5.Size = new System.Drawing.Size(333, 65);
			this.iconButton5.TabIndex = 27;
			this.iconButton5.Text = "    Dashboard";
			this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton5.UseVisualStyleBackColor = false;
			this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
			this.btnHome.IconColor = System.Drawing.Color.White;
			this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnHome.IconSize = 32;
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(0, 175);
			this.btnHome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnHome.Name = "btnHome";
			this.btnHome.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
			this.btnHome.Size = new System.Drawing.Size(333, 65);
			this.btnHome.TabIndex = 11;
			this.btnHome.Text = "    Home";
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// menusidebar
			// 
			this.menusidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.menusidebar.Controls.Add(this.pictureBox1);
			this.menusidebar.Dock = System.Windows.Forms.DockStyle.Top;
			this.menusidebar.Location = new System.Drawing.Point(0, 0);
			this.menusidebar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.menusidebar.Name = "menusidebar";
			this.menusidebar.Size = new System.Drawing.Size(333, 175);
			this.menusidebar.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::QLNhaHangPizza.Properties.Resources.MainIcon;
			this.pictureBox1.Location = new System.Drawing.Point(53, 25);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(187, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.panelTitleBar.Controls.Add(this.panel1);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(333, 0);
			this.panelTitleBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1297, 62);
			this.panelTitleBar.TabIndex = 3;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.iconButton1);
			this.panel1.Controls.Add(this.iconButton3);
			this.panel1.Controls.Add(this.iconButton2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(1126, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 62);
			this.panel1.TabIndex = 15;
			// 
			// iconButton1
			// 
			this.iconButton1.BackColor = System.Drawing.Color.Transparent;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
			this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 25;
			this.iconButton1.Location = new System.Drawing.Point(117, 14);
			this.iconButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(43, 37);
			this.iconButton1.TabIndex = 13;
			this.iconButton1.UseVisualStyleBackColor = false;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_2);
			// 
			// iconButton3
			// 
			this.iconButton3.BackColor = System.Drawing.Color.Transparent;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton3.IconSize = 25;
			this.iconButton3.Location = new System.Drawing.Point(13, 14);
			this.iconButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Size = new System.Drawing.Size(43, 37);
			this.iconButton3.TabIndex = 14;
			this.iconButton3.UseVisualStyleBackColor = false;
			this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_1);
			// 
			// iconButton2
			// 
			this.iconButton2.BackColor = System.Drawing.Color.Transparent;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Square;
			this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 25;
			this.iconButton2.Location = new System.Drawing.Point(65, 14);
			this.iconButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Size = new System.Drawing.Size(43, 37);
			this.iconButton2.TabIndex = 12;
			this.iconButton2.UseVisualStyleBackColor = false;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTitleChildForm.Location = new System.Drawing.Point(95, 25);
			this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(54, 20);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Home";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(242)))));
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(242)))));
			this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconCurrentChildForm.IconSize = 39;
			this.iconCurrentChildForm.Location = new System.Drawing.Point(35, 15);
			this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 39);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(333, 62);
			this.panelShadow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1297, 2);
			this.panelShadow.TabIndex = 4;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
			this.panelDesktop.Controls.Add(this.pictureBox2);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.ForeColor = System.Drawing.Color.MediumPurple;
			this.panelDesktop.Location = new System.Drawing.Point(333, 64);
			this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1297, 886);
			this.panelDesktop.TabIndex = 5;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = global::QLNhaHangPizza.Properties.Resources.BackLogin11;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1297, 886);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// frmMainForManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1630, 950);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.sidebar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmMainForManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhà hàng Pizza";
			this.Load += new System.EventHandler(this.frmMainForManager_Load);
			this.sidebar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
			this.menusidebar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel menusidebar;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label UserName;
        private fa_icon_demo.CustomControls.CircularPictureBox picAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
		private FontAwesome.Sharp.IconButton btnReports;
		private FontAwesome.Sharp.IconButton btnKitchen;
		private FontAwesome.Sharp.IconButton btnPos;
		private FontAwesome.Sharp.IconButton btnStaff;
		private FontAwesome.Sharp.IconButton btnTables;
		private FontAwesome.Sharp.IconButton btnProducts;
		private FontAwesome.Sharp.IconButton btnCategories;
		private FontAwesome.Sharp.IconButton iconButton5;
		private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}