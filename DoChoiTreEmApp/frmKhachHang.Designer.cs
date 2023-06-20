
namespace DoChoiTreEmApp
{
    partial class frmKhachHang
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
            this.btnUpdateKH = new FontAwesome.Sharp.IconButton();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateKH
            // 
            this.btnUpdateKH.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateKH.IconColor = System.Drawing.Color.Black;
            this.btnUpdateKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateKH.IconSize = 16;
            this.btnUpdateKH.Location = new System.Drawing.Point(13, 13);
            this.btnUpdateKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateKH.Name = "btnUpdateKH";
            this.btnUpdateKH.Size = new System.Drawing.Size(183, 48);
            this.btnUpdateKH.TabIndex = 36;
            this.btnUpdateKH.Text = "Cập nhật thông tin";
            this.btnUpdateKH.UseVisualStyleBackColor = true;
            this.btnUpdateKH.Click += new System.EventHandler(this.btnUpdateKH_Click);
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(13, 69);
            this.dataGridViewKH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.Size = new System.Drawing.Size(832, 399);
            this.dataGridViewKH.TabIndex = 35;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 481);
            this.Controls.Add(this.btnUpdateKH);
            this.Controls.Add(this.dataGridViewKH);
            this.Name = "frmKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnUpdateKH;
        private System.Windows.Forms.DataGridView dataGridViewKH;
    }
}