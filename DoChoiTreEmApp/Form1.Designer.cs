
namespace DoChoiTreEmApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnTaskBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.iconZoom = new FontAwesome.Sharp.IconButton();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.ibtnCaiDat = new FontAwesome.Sharp.IconButton();
            this.ibtnThongKe = new FontAwesome.Sharp.IconButton();
            this.ibtnKho = new FontAwesome.Sharp.IconButton();
            this.ibtnSanPham = new FontAwesome.Sharp.IconButton();
            this.ibtnDonHang = new FontAwesome.Sharp.IconButton();
            this.ibtnBanHang = new FontAwesome.Sharp.IconButton();
            this.ibtnTrangchu = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.pbBottom = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnView = new System.Windows.Forms.Panel();
            this.pnTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pbBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTaskBar
            // 
            this.pnTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.pnTaskBar.Controls.Add(this.label1);
            this.pnTaskBar.Controls.Add(this.pictureBox1);
            this.pnTaskBar.Controls.Add(this.iconMinimize);
            this.pnTaskBar.Controls.Add(this.ibtnExit);
            this.pnTaskBar.Controls.Add(this.iconZoom);
            this.pnTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnTaskBar.Name = "pnTaskBar";
            this.pnTaskBar.Size = new System.Drawing.Size(1282, 30);
            this.pnTaskBar.TabIndex = 0;
            this.pnTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTaskBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiny Store - Đồ chơi trẻ em số 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatAppearance.BorderSize = 0;
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(1186, 2);
            this.iconMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(26, 30);
            this.iconMinimize.TabIndex = 7;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // ibtnExit
            // 
            this.ibtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnExit.FlatAppearance.BorderSize = 0;
            this.ibtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExit.IconSize = 25;
            this.ibtnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnExit.Location = new System.Drawing.Point(1252, 0);
            this.ibtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.ibtnExit.Name = "ibtnExit";
            this.ibtnExit.Size = new System.Drawing.Size(26, 30);
            this.ibtnExit.TabIndex = 5;
            this.ibtnExit.UseVisualStyleBackColor = true;
            this.ibtnExit.Click += new System.EventHandler(this.ibtnExit_Click);
            // 
            // iconZoom
            // 
            this.iconZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoom.FlatAppearance.BorderSize = 0;
            this.iconZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconZoom.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconZoom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconZoom.IconSize = 25;
            this.iconZoom.Location = new System.Drawing.Point(1219, 2);
            this.iconZoom.Margin = new System.Windows.Forms.Padding(4);
            this.iconZoom.Name = "iconZoom";
            this.iconZoom.Size = new System.Drawing.Size(26, 30);
            this.iconZoom.TabIndex = 6;
            this.iconZoom.UseVisualStyleBackColor = true;
            this.iconZoom.Click += new System.EventHandler(this.iconZoom_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(99)))));
            this.pnLeft.Controls.Add(this.pnUser);
            this.pnLeft.Controls.Add(this.ibtnCaiDat);
            this.pnLeft.Controls.Add(this.ibtnThongKe);
            this.pnLeft.Controls.Add(this.ibtnKho);
            this.pnLeft.Controls.Add(this.ibtnSanPham);
            this.pnLeft.Controls.Add(this.ibtnDonHang);
            this.pnLeft.Controls.Add(this.ibtnBanHang);
            this.pnLeft.Controls.Add(this.ibtnTrangchu);
            this.pnLeft.Controls.Add(this.pnLogo);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 30);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(167, 823);
            this.pnLeft.TabIndex = 1;
            // 
            // pnUser
            // 
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnUser.Location = new System.Drawing.Point(0, 769);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(167, 54);
            this.pnUser.TabIndex = 16;
            // 
            // ibtnCaiDat
            // 
            this.ibtnCaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCaiDat.FlatAppearance.BorderSize = 0;
            this.ibtnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCaiDat.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCaiDat.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibtnCaiDat.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCaiDat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCaiDat.IconSize = 32;
            this.ibtnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCaiDat.Location = new System.Drawing.Point(0, 297);
            this.ibtnCaiDat.Name = "ibtnCaiDat";
            this.ibtnCaiDat.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnCaiDat.Size = new System.Drawing.Size(167, 42);
            this.ibtnCaiDat.TabIndex = 15;
            this.ibtnCaiDat.Text = "Cài đặt";
            this.ibtnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCaiDat.UseVisualStyleBackColor = true;
            this.ibtnCaiDat.Click += new System.EventHandler(this.ibtnCaiDat_Click);
            // 
            // ibtnThongKe
            // 
            this.ibtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnThongKe.FlatAppearance.BorderSize = 0;
            this.ibtnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ibtnThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThongKe.IconSize = 32;
            this.ibtnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThongKe.Location = new System.Drawing.Point(0, 255);
            this.ibtnThongKe.Name = "ibtnThongKe";
            this.ibtnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnThongKe.Size = new System.Drawing.Size(167, 42);
            this.ibtnThongKe.TabIndex = 14;
            this.ibtnThongKe.Text = "Thống kê";
            this.ibtnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThongKe.UseVisualStyleBackColor = true;
            this.ibtnThongKe.Click += new System.EventHandler(this.ibtnThongKe_Click);
            // 
            // ibtnKho
            // 
            this.ibtnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnKho.FlatAppearance.BorderSize = 0;
            this.ibtnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnKho.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.ibtnKho.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnKho.IconSize = 32;
            this.ibtnKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnKho.Location = new System.Drawing.Point(0, 213);
            this.ibtnKho.Name = "ibtnKho";
            this.ibtnKho.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnKho.Size = new System.Drawing.Size(167, 42);
            this.ibtnKho.TabIndex = 13;
            this.ibtnKho.Text = "Kho";
            this.ibtnKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnKho.UseVisualStyleBackColor = true;
            this.ibtnKho.Click += new System.EventHandler(this.ibtnKho_Click);
            // 
            // ibtnSanPham
            // 
            this.ibtnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSanPham.FlatAppearance.BorderSize = 0;
            this.ibtnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSanPham.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnSanPham.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.ibtnSanPham.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSanPham.IconSize = 32;
            this.ibtnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSanPham.Location = new System.Drawing.Point(0, 171);
            this.ibtnSanPham.Name = "ibtnSanPham";
            this.ibtnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnSanPham.Size = new System.Drawing.Size(167, 42);
            this.ibtnSanPham.TabIndex = 12;
            this.ibtnSanPham.Text = "Sản phẩm";
            this.ibtnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSanPham.UseVisualStyleBackColor = true;
            this.ibtnSanPham.Click += new System.EventHandler(this.ibtnSanPham_Click);
            // 
            // ibtnDonHang
            // 
            this.ibtnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDonHang.FlatAppearance.BorderSize = 0;
            this.ibtnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDonHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnDonHang.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.ibtnDonHang.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDonHang.IconSize = 32;
            this.ibtnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDonHang.Location = new System.Drawing.Point(0, 129);
            this.ibtnDonHang.Name = "ibtnDonHang";
            this.ibtnDonHang.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnDonHang.Size = new System.Drawing.Size(167, 42);
            this.ibtnDonHang.TabIndex = 11;
            this.ibtnDonHang.Text = "Đơn hàng";
            this.ibtnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDonHang.UseVisualStyleBackColor = true;
            this.ibtnDonHang.Click += new System.EventHandler(this.ibtnDonHang_Click);
            // 
            // ibtnBanHang
            // 
            this.ibtnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnBanHang.FlatAppearance.BorderSize = 0;
            this.ibtnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBanHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnBanHang.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.ibtnBanHang.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBanHang.IconSize = 32;
            this.ibtnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBanHang.Location = new System.Drawing.Point(0, 87);
            this.ibtnBanHang.Name = "ibtnBanHang";
            this.ibtnBanHang.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnBanHang.Size = new System.Drawing.Size(167, 42);
            this.ibtnBanHang.TabIndex = 10;
            this.ibtnBanHang.Text = "Bán hàng";
            this.ibtnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBanHang.UseVisualStyleBackColor = true;
            this.ibtnBanHang.Click += new System.EventHandler(this.ibtnBanHang_Click);
            // 
            // ibtnTrangchu
            // 
            this.ibtnTrangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTrangchu.FlatAppearance.BorderSize = 0;
            this.ibtnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTrangchu.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnTrangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnTrangchu.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnTrangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTrangchu.IconSize = 32;
            this.ibtnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTrangchu.Location = new System.Drawing.Point(0, 45);
            this.ibtnTrangchu.Name = "ibtnTrangchu";
            this.ibtnTrangchu.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnTrangchu.Size = new System.Drawing.Size(167, 42);
            this.ibtnTrangchu.TabIndex = 6;
            this.ibtnTrangchu.Text = "Trang chủ";
            this.ibtnTrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTrangchu.UseVisualStyleBackColor = true;
            this.ibtnTrangchu.Click += new System.EventHandler(this.ibtnTrangchu_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.pnLogo.Controls.Add(this.lblDanhMuc);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(167, 45);
            this.pnLogo.TabIndex = 0;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.ForeColor = System.Drawing.Color.White;
            this.lblDanhMuc.Location = new System.Drawing.Point(21, 11);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(109, 21);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "DANH MỤC";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(99)))));
            this.pnMenu.Controls.Add(this.ibtnMenu);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(167, 30);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1115, 45);
            this.pnMenu.TabIndex = 2;
            // 
            // ibtnMenu
            // 
            this.ibtnMenu.FlatAppearance.BorderSize = 0;
            this.ibtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.ibtnMenu.IconColor = System.Drawing.Color.White;
            this.ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMenu.IconSize = 30;
            this.ibtnMenu.Location = new System.Drawing.Point(3, 0);
            this.ibtnMenu.Name = "ibtnMenu";
            this.ibtnMenu.Size = new System.Drawing.Size(39, 45);
            this.ibtnMenu.TabIndex = 0;
            this.ibtnMenu.UseVisualStyleBackColor = true;
            this.ibtnMenu.Click += new System.EventHandler(this.ibtnMenu_Click);
            // 
            // pbBottom
            // 
            this.pbBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbBottom.Controls.Add(this.lblVersion);
            this.pbBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBottom.Location = new System.Drawing.Point(167, 828);
            this.pbBottom.Name = "pbBottom";
            this.pbBottom.Size = new System.Drawing.Size(1115, 25);
            this.pbBottom.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(1035, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(77, 18);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version 1.0";
            // 
            // pnView
            // 
            this.pnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnView.Location = new System.Drawing.Point(167, 75);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1115, 753);
            this.pnView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.pbBottom);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTaskBar);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnTaskBar.ResumeLayout(false);
            this.pnTaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pbBottom.ResumeLayout(false);
            this.pbBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTaskBar;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private System.Windows.Forms.Label lblDanhMuc;
        private FontAwesome.Sharp.IconButton ibtnTrangchu;
        private FontAwesome.Sharp.IconButton ibtnSanPham;
        private FontAwesome.Sharp.IconButton ibtnDonHang;
        private FontAwesome.Sharp.IconButton ibtnBanHang;
        private FontAwesome.Sharp.IconButton ibtnExit;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private FontAwesome.Sharp.IconButton iconZoom;
        private System.Windows.Forms.Panel pbBottom;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnUser;
        private FontAwesome.Sharp.IconButton ibtnCaiDat;
        private FontAwesome.Sharp.IconButton ibtnThongKe;
        private FontAwesome.Sharp.IconButton ibtnKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}