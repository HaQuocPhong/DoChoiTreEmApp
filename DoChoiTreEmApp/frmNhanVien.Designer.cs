
namespace DoChoiTreEmApp
{
    partial class frmNhanVien
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSttNV = new System.Windows.Forms.TextBox();
            this.BtnHuy = new FontAwesome.Sharp.IconButton();
            this.BtnXoa = new FontAwesome.Sharp.IconButton();
            this.BtnSua = new FontAwesome.Sharp.IconButton();
            this.BtnThem = new FontAwesome.Sharp.IconButton();
            this.txtPassNV = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtUserNV = new System.Windows.Forms.TextBox();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tên NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "STT";
            // 
            // txtSttNV
            // 
            this.txtSttNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSttNV.Location = new System.Drawing.Point(150, 24);
            this.txtSttNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSttNV.Name = "txtSttNV";
            this.txtSttNV.Size = new System.Drawing.Size(213, 27);
            this.txtSttNV.TabIndex = 30;
            // 
            // BtnHuy
            // 
            this.BtnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnHuy.IconColor = System.Drawing.Color.Black;
            this.BtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHuy.IconSize = 16;
            this.BtnHuy.Location = new System.Drawing.Point(150, 354);
            this.BtnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(215, 48);
            this.BtnHuy.TabIndex = 29;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.UseVisualStyleBackColor = true;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnXoa.IconColor = System.Drawing.Color.Black;
            this.BtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnXoa.IconSize = 16;
            this.BtnXoa.Location = new System.Drawing.Point(150, 298);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(215, 48);
            this.BtnXoa.TabIndex = 28;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSua.IconColor = System.Drawing.Color.Black;
            this.BtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSua.IconSize = 16;
            this.BtnSua.Location = new System.Drawing.Point(150, 242);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(215, 48);
            this.BtnSua.TabIndex = 27;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnThem.IconColor = System.Drawing.Color.Black;
            this.BtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnThem.IconSize = 16;
            this.BtnThem.Location = new System.Drawing.Point(148, 186);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(215, 48);
            this.BtnThem.TabIndex = 26;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // txtPassNV
            // 
            this.txtPassNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNV.Location = new System.Drawing.Point(150, 114);
            this.txtPassNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNV.Name = "txtPassNV";
            this.txtPassNV.Size = new System.Drawing.Size(213, 27);
            this.txtPassNV.TabIndex = 25;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNV.Location = new System.Drawing.Point(150, 84);
            this.txtNameNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(213, 27);
            this.txtNameNV.TabIndex = 24;
            // 
            // txtUserNV
            // 
            this.txtUserNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNV.Location = new System.Drawing.Point(150, 54);
            this.txtUserNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNV.Name = "txtUserNV";
            this.txtUserNV.Size = new System.Drawing.Size(213, 27);
            this.txtUserNV.TabIndex = 23;
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AllowUserToAddRows = false;
            this.dataGridViewNV.AllowUserToDeleteRows = false;
            this.dataGridViewNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Location = new System.Drawing.Point(390, 24);
            this.dataGridViewNV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.Size = new System.Drawing.Size(541, 430);
            this.dataGridViewNV.TabIndex = 22;
            this.dataGridViewNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellContentClick);
            this.dataGridViewNV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Chức vụ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 27);
            this.textBox1.TabIndex = 35;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSttNV);
            this.Controls.Add(this.BtnHuy);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.txtPassNV);
            this.Controls.Add(this.txtNameNV);
            this.Controls.Add(this.txtUserNV);
            this.Controls.Add(this.dataGridViewNV);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSttNV;
        private FontAwesome.Sharp.IconButton BtnHuy;
        private FontAwesome.Sharp.IconButton BtnXoa;
        private FontAwesome.Sharp.IconButton BtnSua;
        private FontAwesome.Sharp.IconButton BtnThem;
        private System.Windows.Forms.TextBox txtPassNV;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.TextBox txtUserNV;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}