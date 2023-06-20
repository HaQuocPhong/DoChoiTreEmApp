
namespace DoChoiTreEmApp
{
    partial class ChiTietHoaDon
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
            this.dataGridViewct = new System.Windows.Forms.DataGridView();
            this.hdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvsanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvientt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthanhtoanno = new System.Windows.Forms.Button();
            this.textBoxttNo = new System.Windows.Forms.TextBox();
            this.btXuatExcel = new System.Windows.Forms.Button();
            this.btInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewct
            // 
            this.dataGridViewct.AllowUserToAddRows = false;
            this.dataGridViewct.AllowUserToDeleteRows = false;
            this.dataGridViewct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdid,
            this.TenKH,
            this.masp,
            this.tensp,
            this.loaisp,
            this.slsp,
            this.dvsanpham,
            this.DongiaSP,
            this.thanhtoan,
            this.hdtime,
            this.sdt,
            this.no,
            this.nhanvientt});
            this.dataGridViewct.Location = new System.Drawing.Point(13, 131);
            this.dataGridViewct.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewct.Name = "dataGridViewct";
            this.dataGridViewct.ReadOnly = true;
            this.dataGridViewct.RowHeadersVisible = false;
            this.dataGridViewct.RowHeadersWidth = 51;
            this.dataGridViewct.Size = new System.Drawing.Size(1124, 411);
            this.dataGridViewct.TabIndex = 2;
            // 
            // hdid
            // 
            this.hdid.HeaderText = "ID";
            this.hdid.MinimumWidth = 6;
            this.hdid.Name = "hdid";
            this.hdid.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại";
            this.loaisp.MinimumWidth = 6;
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            // 
            // slsp
            // 
            this.slsp.HeaderText = "Số lượng";
            this.slsp.MinimumWidth = 6;
            this.slsp.Name = "slsp";
            this.slsp.ReadOnly = true;
            // 
            // dvsanpham
            // 
            this.dvsanpham.HeaderText = "Đơn vị";
            this.dvsanpham.MinimumWidth = 6;
            this.dvsanpham.Name = "dvsanpham";
            this.dvsanpham.ReadOnly = true;
            // 
            // DongiaSP
            // 
            this.DongiaSP.HeaderText = "Đơn giá";
            this.DongiaSP.MinimumWidth = 6;
            this.DongiaSP.Name = "DongiaSP";
            this.DongiaSP.ReadOnly = true;
            // 
            // thanhtoan
            // 
            this.thanhtoan.HeaderText = "Thanh toán";
            this.thanhtoan.MinimumWidth = 6;
            this.thanhtoan.Name = "thanhtoan";
            this.thanhtoan.ReadOnly = true;
            // 
            // hdtime
            // 
            this.hdtime.HeaderText = "Thời gian";
            this.hdtime.MinimumWidth = 6;
            this.hdtime.Name = "hdtime";
            this.hdtime.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // no
            // 
            this.no.HeaderText = "Nợ";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // nhanvientt
            // 
            this.nhanvientt.HeaderText = "Nhân viên thanh toán";
            this.nhanvientt.MinimumWidth = 6;
            this.nhanvientt.Name = "nhanvientt";
            this.nhanvientt.ReadOnly = true;
            // 
            // btnthanhtoanno
            // 
            this.btnthanhtoanno.Location = new System.Drawing.Point(325, 21);
            this.btnthanhtoanno.Margin = new System.Windows.Forms.Padding(4);
            this.btnthanhtoanno.Name = "btnthanhtoanno";
            this.btnthanhtoanno.Size = new System.Drawing.Size(196, 59);
            this.btnthanhtoanno.TabIndex = 10;
            this.btnthanhtoanno.Text = "Thanh toán";
            this.btnthanhtoanno.UseVisualStyleBackColor = true;
            this.btnthanhtoanno.Click += new System.EventHandler(this.btnthanhtoanno_Click);
            // 
            // textBoxttNo
            // 
            this.textBoxttNo.Location = new System.Drawing.Point(13, 39);
            this.textBoxttNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxttNo.Name = "textBoxttNo";
            this.textBoxttNo.Size = new System.Drawing.Size(271, 22);
            this.textBoxttNo.TabIndex = 9;
            // 
            // btXuatExcel
            // 
            this.btXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXuatExcel.Location = new System.Drawing.Point(707, 21);
            this.btXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btXuatExcel.Name = "btXuatExcel";
            this.btXuatExcel.Size = new System.Drawing.Size(196, 59);
            this.btXuatExcel.TabIndex = 8;
            this.btXuatExcel.Text = "Xuất file Excel";
            this.btXuatExcel.UseVisualStyleBackColor = true;
            this.btXuatExcel.Click += new System.EventHandler(this.btXuatExcel_Click);
            // 
            // btInHoaDon
            // 
            this.btInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btInHoaDon.Location = new System.Drawing.Point(922, 21);
            this.btInHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btInHoaDon.Name = "btInHoaDon";
            this.btInHoaDon.Size = new System.Drawing.Size(208, 59);
            this.btInHoaDon.TabIndex = 7;
            this.btInHoaDon.Text = "In hóa đơn";
            this.btInHoaDon.UseVisualStyleBackColor = true;
            this.btInHoaDon.Click += new System.EventHandler(this.btInHoaDon_Click);
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 555);
            this.Controls.Add(this.btnthanhtoanno);
            this.Controls.Add(this.textBoxttNo);
            this.Controls.Add(this.btXuatExcel);
            this.Controls.Add(this.btInHoaDon);
            this.Controls.Add(this.dataGridViewct);
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewct;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn slsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvientt;
        private System.Windows.Forms.Button btnthanhtoanno;
        private System.Windows.Forms.TextBox textBoxttNo;
        private System.Windows.Forms.Button btXuatExcel;
        private System.Windows.Forms.Button btInHoaDon;
    }
}