
namespace DoChoiTreEmApp
{
    partial class frmCuaHang
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
            this.SaveIMGlogo = new FontAwesome.Sharp.IconButton();
            this.btnButtonChooseIMG = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSaveThongtin = new FontAwesome.Sharp.IconButton();
            this.txtLoiChao = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenShop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveIMGlogo
            // 
            this.SaveIMGlogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SaveIMGlogo.IconColor = System.Drawing.Color.Black;
            this.SaveIMGlogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveIMGlogo.IconSize = 16;
            this.SaveIMGlogo.Location = new System.Drawing.Point(642, 316);
            this.SaveIMGlogo.Margin = new System.Windows.Forms.Padding(4);
            this.SaveIMGlogo.Name = "SaveIMGlogo";
            this.SaveIMGlogo.Size = new System.Drawing.Size(164, 62);
            this.SaveIMGlogo.TabIndex = 43;
            this.SaveIMGlogo.Text = "Lưu ảnh";
            this.SaveIMGlogo.UseVisualStyleBackColor = true;
            this.SaveIMGlogo.Click += new System.EventHandler(this.SaveIMGlogo_Click);
            // 
            // btnButtonChooseIMG
            // 
            this.btnButtonChooseIMG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnButtonChooseIMG.IconColor = System.Drawing.Color.Black;
            this.btnButtonChooseIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnButtonChooseIMG.IconSize = 16;
            this.btnButtonChooseIMG.Location = new System.Drawing.Point(642, 246);
            this.btnButtonChooseIMG.Margin = new System.Windows.Forms.Padding(4);
            this.btnButtonChooseIMG.Name = "btnButtonChooseIMG";
            this.btnButtonChooseIMG.Size = new System.Drawing.Size(164, 62);
            this.btnButtonChooseIMG.TabIndex = 42;
            this.btnButtonChooseIMG.Text = "Chọn ảnh";
            this.btnButtonChooseIMG.UseVisualStyleBackColor = true;
            this.btnButtonChooseIMG.Click += new System.EventHandler(this.btnButtonChooseIMG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(216, 209);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Lời chào";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên cửa hàng";
            // 
            // BtnSaveThongtin
            // 
            this.BtnSaveThongtin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSaveThongtin.IconColor = System.Drawing.Color.Black;
            this.BtnSaveThongtin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSaveThongtin.IconSize = 16;
            this.BtnSaveThongtin.Location = new System.Drawing.Point(642, 190);
            this.BtnSaveThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveThongtin.Name = "BtnSaveThongtin";
            this.BtnSaveThongtin.Size = new System.Drawing.Size(164, 48);
            this.BtnSaveThongtin.TabIndex = 35;
            this.BtnSaveThongtin.Text = "Lưu";
            this.BtnSaveThongtin.UseVisualStyleBackColor = true;
            this.BtnSaveThongtin.Click += new System.EventHandler(this.BtnSaveThongtin_Click);
            // 
            // txtLoiChao
            // 
            this.txtLoiChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiChao.Location = new System.Drawing.Point(186, 155);
            this.txtLoiChao.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoiChao.Name = "txtLoiChao";
            this.txtLoiChao.Size = new System.Drawing.Size(620, 27);
            this.txtLoiChao.TabIndex = 34;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(186, 123);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(620, 27);
            this.txtDiaChi.TabIndex = 33;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(186, 91);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(620, 27);
            this.txtSDT.TabIndex = 32;
            // 
            // txtTenShop
            // 
            this.txtTenShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenShop.Location = new System.Drawing.Point(186, 59);
            this.txtTenShop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenShop.Name = "txtTenShop";
            this.txtTenShop.Size = new System.Drawing.Size(620, 27);
            this.txtTenShop.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Logo cửa hàng";
            // 
            // frmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 472);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveIMGlogo);
            this.Controls.Add(this.btnButtonChooseIMG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSaveThongtin);
            this.Controls.Add(this.txtLoiChao);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenShop);
            this.Name = "frmCuaHang";
            this.Text = "Thông tin cửa hàng";
            this.Load += new System.EventHandler(this.frmCaiDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton SaveIMGlogo;
        private FontAwesome.Sharp.IconButton btnButtonChooseIMG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnSaveThongtin;
        private System.Windows.Forms.TextBox txtLoiChao;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenShop;
        private System.Windows.Forms.Label label5;
    }
}