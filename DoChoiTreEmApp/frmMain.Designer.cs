
namespace DoChoiTreEmApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnTaskBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.iconZoom = new FontAwesome.Sharp.IconButton();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.ibtnKhachHang = new FontAwesome.Sharp.IconButton();
            this.ibtnNhanVien = new FontAwesome.Sharp.IconButton();
            this.ibtnCuaHang = new FontAwesome.Sharp.IconButton();
            this.ibtnThongKe = new FontAwesome.Sharp.IconButton();
            this.ibtnTonkho = new FontAwesome.Sharp.IconButton();
            this.ibtnNhapKho = new FontAwesome.Sharp.IconButton();
            this.ibtnKho = new FontAwesome.Sharp.IconButton();
            this.ibtnLoai = new FontAwesome.Sharp.IconButton();
            this.ibtnThuongHieu = new FontAwesome.Sharp.IconButton();
            this.ibtnDangXuat = new FontAwesome.Sharp.IconButton();
            this.ibtnSanPham = new FontAwesome.Sharp.IconButton();
            this.ibtnDonHang = new FontAwesome.Sharp.IconButton();
            this.ibtnBanHang = new FontAwesome.Sharp.IconButton();
            this.ibtnTrangchu = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.iconmenusmall = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.pbBottom = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnView = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).BeginInit();
            this.pbBottom.SuspendLayout();
            this.pnView.SuspendLayout();
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
            this.pnLeft.Controls.Add(this.ibtnKhachHang);
            this.pnLeft.Controls.Add(this.ibtnNhanVien);
            this.pnLeft.Controls.Add(this.ibtnCuaHang);
            this.pnLeft.Controls.Add(this.ibtnThongKe);
            this.pnLeft.Controls.Add(this.ibtnTonkho);
            this.pnLeft.Controls.Add(this.ibtnNhapKho);
            this.pnLeft.Controls.Add(this.ibtnKho);
            this.pnLeft.Controls.Add(this.ibtnLoai);
            this.pnLeft.Controls.Add(this.ibtnThuongHieu);
            this.pnLeft.Controls.Add(this.ibtnDangXuat);
            this.pnLeft.Controls.Add(this.ibtnSanPham);
            this.pnLeft.Controls.Add(this.ibtnDonHang);
            this.pnLeft.Controls.Add(this.ibtnBanHang);
            this.pnLeft.Controls.Add(this.ibtnTrangchu);
            this.pnLeft.Controls.Add(this.pnLogo);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 30);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(181, 823);
            this.pnLeft.TabIndex = 1;
            // 
            // ibtnKhachHang
            // 
            this.ibtnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnKhachHang.FlatAppearance.BorderSize = 0;
            this.ibtnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ibtnKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnKhachHang.IconSize = 32;
            this.ibtnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnKhachHang.Location = new System.Drawing.Point(0, 549);
            this.ibtnKhachHang.Name = "ibtnKhachHang";
            this.ibtnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnKhachHang.Size = new System.Drawing.Size(181, 42);
            this.ibtnKhachHang.TabIndex = 34;
            this.ibtnKhachHang.Text = "Khách hàng";
            this.ibtnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnKhachHang.UseVisualStyleBackColor = true;
            this.ibtnKhachHang.Click += new System.EventHandler(this.ibtnKhachHang_Click);
            // 
            // ibtnNhanVien
            // 
            this.ibtnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNhanVien.FlatAppearance.BorderSize = 0;
            this.ibtnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnNhanVien.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNhanVien.IconSize = 32;
            this.ibtnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNhanVien.Location = new System.Drawing.Point(0, 507);
            this.ibtnNhanVien.Name = "ibtnNhanVien";
            this.ibtnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnNhanVien.Size = new System.Drawing.Size(181, 42);
            this.ibtnNhanVien.TabIndex = 33;
            this.ibtnNhanVien.Text = "Nhân viên";
            this.ibtnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNhanVien.UseVisualStyleBackColor = true;
            this.ibtnNhanVien.Visible = false;
            this.ibtnNhanVien.Click += new System.EventHandler(this.ibtnNhanVien_Click);
            // 
            // ibtnCuaHang
            // 
            this.ibtnCuaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCuaHang.FlatAppearance.BorderSize = 0;
            this.ibtnCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCuaHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCuaHang.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibtnCuaHang.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCuaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCuaHang.IconSize = 32;
            this.ibtnCuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCuaHang.Location = new System.Drawing.Point(0, 465);
            this.ibtnCuaHang.Name = "ibtnCuaHang";
            this.ibtnCuaHang.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnCuaHang.Size = new System.Drawing.Size(181, 42);
            this.ibtnCuaHang.TabIndex = 32;
            this.ibtnCuaHang.Text = "Cửa hàng";
            this.ibtnCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCuaHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCuaHang.UseVisualStyleBackColor = true;
            this.ibtnCuaHang.Visible = false;
            this.ibtnCuaHang.Click += new System.EventHandler(this.ibtnCaiDat_Click);
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
            this.ibtnThongKe.Location = new System.Drawing.Point(0, 423);
            this.ibtnThongKe.Name = "ibtnThongKe";
            this.ibtnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnThongKe.Size = new System.Drawing.Size(181, 42);
            this.ibtnThongKe.TabIndex = 31;
            this.ibtnThongKe.Text = "Thống kê";
            this.ibtnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThongKe.UseVisualStyleBackColor = true;
            this.ibtnThongKe.Click += new System.EventHandler(this.ibtnThongKe_Click);
            // 
            // ibtnTonkho
            // 
            this.ibtnTonkho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.ibtnTonkho.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTonkho.FlatAppearance.BorderSize = 0;
            this.ibtnTonkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTonkho.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnTonkho.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.ibtnTonkho.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnTonkho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTonkho.IconSize = 32;
            this.ibtnTonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTonkho.Location = new System.Drawing.Point(0, 381);
            this.ibtnTonkho.Name = "ibtnTonkho";
            this.ibtnTonkho.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnTonkho.Size = new System.Drawing.Size(181, 42);
            this.ibtnTonkho.TabIndex = 28;
            this.ibtnTonkho.Text = "Tồn kho";
            this.ibtnTonkho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTonkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTonkho.UseVisualStyleBackColor = false;
            this.ibtnTonkho.Visible = false;
            this.ibtnTonkho.Click += new System.EventHandler(this.ibtnTonkho_Click);
            // 
            // ibtnNhapKho
            // 
            this.ibtnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.ibtnNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNhapKho.FlatAppearance.BorderSize = 0;
            this.ibtnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNhapKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnNhapKho.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.ibtnNhapKho.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNhapKho.IconSize = 32;
            this.ibtnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNhapKho.Location = new System.Drawing.Point(0, 339);
            this.ibtnNhapKho.Name = "ibtnNhapKho";
            this.ibtnNhapKho.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnNhapKho.Size = new System.Drawing.Size(181, 42);
            this.ibtnNhapKho.TabIndex = 27;
            this.ibtnNhapKho.Text = "Nhập kho";
            this.ibtnNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNhapKho.UseVisualStyleBackColor = false;
            this.ibtnNhapKho.Visible = false;
            this.ibtnNhapKho.Click += new System.EventHandler(this.ibtnNhapKho_Click);
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
            this.ibtnKho.Location = new System.Drawing.Point(0, 297);
            this.ibtnKho.Name = "ibtnKho";
            this.ibtnKho.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnKho.Size = new System.Drawing.Size(181, 42);
            this.ibtnKho.TabIndex = 26;
            this.ibtnKho.Text = "Kho";
            this.ibtnKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnKho.UseVisualStyleBackColor = true;
            this.ibtnKho.Click += new System.EventHandler(this.ibtnKho_Click);
            // 
            // ibtnLoai
            // 
            this.ibtnLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.ibtnLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnLoai.FlatAppearance.BorderSize = 0;
            this.ibtnLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnLoai.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.ibtnLoai.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLoai.IconSize = 32;
            this.ibtnLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLoai.Location = new System.Drawing.Point(0, 255);
            this.ibtnLoai.Name = "ibtnLoai";
            this.ibtnLoai.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnLoai.Size = new System.Drawing.Size(181, 42);
            this.ibtnLoai.TabIndex = 19;
            this.ibtnLoai.Text = "Loại";
            this.ibtnLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLoai.UseVisualStyleBackColor = false;
            this.ibtnLoai.Visible = false;
            this.ibtnLoai.Click += new System.EventHandler(this.ibtnLoai_Click);
            // 
            // ibtnThuongHieu
            // 
            this.ibtnThuongHieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.ibtnThuongHieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnThuongHieu.FlatAppearance.BorderSize = 0;
            this.ibtnThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnThuongHieu.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnThuongHieu.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.ibtnThuongHieu.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnThuongHieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThuongHieu.IconSize = 32;
            this.ibtnThuongHieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThuongHieu.Location = new System.Drawing.Point(0, 213);
            this.ibtnThuongHieu.Name = "ibtnThuongHieu";
            this.ibtnThuongHieu.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnThuongHieu.Size = new System.Drawing.Size(181, 42);
            this.ibtnThuongHieu.TabIndex = 18;
            this.ibtnThuongHieu.Text = "Thương hiệu";
            this.ibtnThuongHieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThuongHieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThuongHieu.UseVisualStyleBackColor = false;
            this.ibtnThuongHieu.Visible = false;
            this.ibtnThuongHieu.Click += new System.EventHandler(this.ibtnThuongHieu_Click);
            // 
            // ibtnDangXuat
            // 
            this.ibtnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnDangXuat.FlatAppearance.BorderSize = 0;
            this.ibtnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ibtnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDangXuat.IconSize = 32;
            this.ibtnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDangXuat.Location = new System.Drawing.Point(0, 781);
            this.ibtnDangXuat.Name = "ibtnDangXuat";
            this.ibtnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.ibtnDangXuat.Size = new System.Drawing.Size(181, 42);
            this.ibtnDangXuat.TabIndex = 17;
            this.ibtnDangXuat.Text = "Đăng xuất";
            this.ibtnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDangXuat.UseVisualStyleBackColor = true;
            this.ibtnDangXuat.Click += new System.EventHandler(this.ibtnDangXuat_Click);
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
            this.ibtnSanPham.Size = new System.Drawing.Size(181, 42);
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
            this.ibtnDonHang.Size = new System.Drawing.Size(181, 42);
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
            this.ibtnBanHang.Size = new System.Drawing.Size(181, 42);
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
            this.ibtnTrangchu.Size = new System.Drawing.Size(181, 42);
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
            this.pnLogo.Size = new System.Drawing.Size(181, 45);
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
            this.pnMenu.Controls.Add(this.lblChucVu);
            this.pnMenu.Controls.Add(this.LabelUser);
            this.pnMenu.Controls.Add(this.iconmenusmall);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.ibtnMenu);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(181, 30);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1101, 45);
            this.pnMenu.TabIndex = 2;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChucVu.Location = new System.Drawing.Point(807, 12);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(108, 20);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "aaaaaaaaaaa";
            // 
            // LabelUser
            // 
            this.LabelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelUser.Location = new System.Drawing.Point(923, 12);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(108, 20);
            this.LabelUser.TabIndex = 6;
            this.LabelUser.Text = "aaaaaaaaaaa";
            // 
            // iconmenusmall
            // 
            this.iconmenusmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(99)))));
            this.iconmenusmall.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconmenusmall.IconColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenusmall.IconSize = 29;
            this.iconmenusmall.Location = new System.Drawing.Point(81, 7);
            this.iconmenusmall.Margin = new System.Windows.Forms.Padding(4);
            this.iconmenusmall.Name = "iconmenusmall";
            this.iconmenusmall.Size = new System.Drawing.Size(30, 29);
            this.iconmenusmall.TabIndex = 2;
            this.iconmenusmall.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(118, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            this.pbBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbBottom.Controls.Add(this.lblVersion);
            this.pbBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBottom.Location = new System.Drawing.Point(181, 828);
            this.pbBottom.Name = "pbBottom";
            this.pbBottom.Size = new System.Drawing.Size(1101, 25);
            this.pbBottom.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(1021, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(77, 18);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version 1.0";
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.SystemColors.Control;
            this.pnView.Controls.Add(this.label3);
            this.pnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnView.Location = new System.Drawing.Point(181, 75);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1101, 753);
            this.pnView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(632, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "-- Chào mừng quý khách đến với cửa hàng Tiny Store --";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
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
            this.Name = "frmMain";
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
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).EndInit();
            this.pbBottom.ResumeLayout(false);
            this.pbBottom.PerformLayout();
            this.pnView.ResumeLayout(false);
            this.pnView.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnDangXuat;
        private FontAwesome.Sharp.IconButton ibtnKho;
        private FontAwesome.Sharp.IconButton ibtnLoai;
        private FontAwesome.Sharp.IconButton ibtnThuongHieu;
        private FontAwesome.Sharp.IconButton ibtnCuaHang;
        private FontAwesome.Sharp.IconButton ibtnThongKe;
        private FontAwesome.Sharp.IconButton ibtnTonkho;
        private FontAwesome.Sharp.IconButton ibtnNhapKho;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconmenusmall;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label lblChucVu;
        private FontAwesome.Sharp.IconButton ibtnNhanVien;
        private FontAwesome.Sharp.IconButton ibtnKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}