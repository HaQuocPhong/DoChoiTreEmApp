using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DoChoiTreEmApp
{
    public partial class frmDangNhap : Form
    {
        public static string usernv = "";
        SqlConnection connect = DatabaseConnection.connect;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            usernv = txtTaikhoan.Text;
            string querynv = "Select * From nhanvien where usernv ='" + txtTaikhoan.Text + "' and passnv='" + txtMatkhau.Text + "' ";
            SqlDataAdapter sqldata = new SqlDataAdapter(querynv, connect);
            DataTable datatb1 = new DataTable();
            sqldata.Fill(datatb1);
            if (datatb1.Rows.Count == 1)
            {
                frmLoad load = new frmLoad();
                this.Hide();
                load.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void checkBoxAnHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnHienMK.Checked == true)
            {
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
                txtMatkhau.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command;
                string sqllogo = "select logo from ThongTinShop where ID=1 ";
                if (connect.State != ConnectionState.Open)
                    connect.Open();
                command = new SqlCommand(sqllogo, connect);
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);

                    }
                    //  MessageBox.Show(img.ToString());
                    connect.Close();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("bi loi");
                }

            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("loi logo: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản lý để cấp lại mật khẩu mới !!!","Thông báo" ,MessageBoxButtons.OKCancel);
        }
    }
    
}
