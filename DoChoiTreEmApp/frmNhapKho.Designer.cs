
namespace DoChoiTreEmApp
{
    partial class frmNhapKho
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
            this.txtKhuyenmai = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.combodonvi = new System.Windows.Forms.ComboBox();
            this.comboloai = new System.Windows.Forms.ComboBox();
            this.btnButtonChooseIMG = new FontAwesome.Sharp.IconButton();
            this.btnDeleteIMG = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Khuyến mãi";
            // 
            // txtKhuyenmai
            // 
            this.txtKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuyenmai.Location = new System.Drawing.Point(172, 227);
            this.txtKhuyenmai.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhuyenmai.Name = "txtKhuyenmai";
            this.txtKhuyenmai.Size = new System.Drawing.Size(239, 27);
            this.txtKhuyenmai.TabIndex = 54;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(310, 292);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(76, 49);
            this.btnclear.TabIndex = 53;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // combodonvi
            // 
            this.combodonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodonvi.FormattingEnabled = true;
            this.combodonvi.Items.AddRange(new object[] {
            "Chai",
            "Lon",
            "Gói",
            "Hộp",
            "Thùng"});
            this.combodonvi.Location = new System.Drawing.Point(172, 195);
            this.combodonvi.Margin = new System.Windows.Forms.Padding(4);
            this.combodonvi.Name = "combodonvi";
            this.combodonvi.Size = new System.Drawing.Size(239, 28);
            this.combodonvi.TabIndex = 52;
            // 
            // comboloai
            // 
            this.comboloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboloai.FormattingEnabled = true;
            this.comboloai.Items.AddRange(new object[] {
            "Nước ngọt",
            "Bánh",
            "Mì",
            "Nước suối",
            "Xúc xích"});
            this.comboloai.Location = new System.Drawing.Point(172, 163);
            this.comboloai.Margin = new System.Windows.Forms.Padding(4);
            this.comboloai.Name = "comboloai";
            this.comboloai.Size = new System.Drawing.Size(239, 28);
            this.comboloai.TabIndex = 51;
            this.comboloai.SelectedIndexChanged += new System.EventHandler(this.comboloai_SelectedIndexChanged);
            // 
            // btnButtonChooseIMG
            // 
            this.btnButtonChooseIMG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnButtonChooseIMG.IconColor = System.Drawing.Color.Black;
            this.btnButtonChooseIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnButtonChooseIMG.IconSize = 16;
            this.btnButtonChooseIMG.Location = new System.Drawing.Point(211, 426);
            this.btnButtonChooseIMG.Margin = new System.Windows.Forms.Padding(4);
            this.btnButtonChooseIMG.Name = "btnButtonChooseIMG";
            this.btnButtonChooseIMG.Size = new System.Drawing.Size(175, 58);
            this.btnButtonChooseIMG.TabIndex = 50;
            this.btnButtonChooseIMG.Text = "Chọn ảnh";
            this.btnButtonChooseIMG.UseVisualStyleBackColor = true;
            this.btnButtonChooseIMG.Click += new System.EventHandler(this.btnButtonChooseIMG_Click);
            // 
            // btnDeleteIMG
            // 
            this.btnDeleteIMG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeleteIMG.IconColor = System.Drawing.Color.Black;
            this.btnDeleteIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteIMG.IconSize = 16;
            this.btnDeleteIMG.Location = new System.Drawing.Point(211, 349);
            this.btnDeleteIMG.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteIMG.Name = "btnDeleteIMG";
            this.btnDeleteIMG.Size = new System.Drawing.Size(175, 58);
            this.btnDeleteIMG.TabIndex = 49;
            this.btnDeleteIMG.Text = "Xóa ảnh";
            this.btnDeleteIMG.UseVisualStyleBackColor = true;
            this.btnDeleteIMG.Click += new System.EventHandler(this.btnDeleteIMG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 349);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(211, 292);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(76, 49);
            this.btndelete.TabIndex = 47;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(114, 292);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(80, 49);
            this.btnsave.TabIndex = 46;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(17, 292);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 49);
            this.btnadd.TabIndex = 45;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Thương hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Giá nhập";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(172, 133);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(239, 27);
            this.txtgiaban.TabIndex = 40;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgianhap.Location = new System.Drawing.Point(172, 103);
            this.txtgianhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(239, 27);
            this.txtgianhap.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(172, 73);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(239, 27);
            this.txtsl.TabIndex = 35;
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.Location = new System.Drawing.Point(172, 43);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(239, 27);
            this.txttensp.TabIndex = 34;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(172, 13);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(239, 27);
            this.txtid.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(695, 383);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcel.IconSize = 16;
            this.btnExportExcel.Location = new System.Drawing.Point(905, 13);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(267, 46);
            this.btnExportExcel.TabIndex = 60;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(905, 65);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 27);
            this.dateTimePicker1.TabIndex = 59;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.Location = new System.Drawing.Point(738, 14);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(82, 21);
            this.LabelSearch.TabIndex = 58;
            this.LabelSearch.Text = "Tìm kiếm";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(477, 13);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(260, 27);
            this.txtsearch.TabIndex = 57;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 503);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKhuyenmai);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.combodonvi);
            this.Controls.Add(this.comboloai);
            this.Controls.Add(this.btnButtonChooseIMG);
            this.Controls.Add(this.btnDeleteIMG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txtgianhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtid);
            this.Name = "frmNhapKho";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKhuyenmai;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox combodonvi;
        private System.Windows.Forms.ComboBox comboloai;
        private FontAwesome.Sharp.IconButton btnButtonChooseIMG;
        private FontAwesome.Sharp.IconButton btnDeleteIMG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}