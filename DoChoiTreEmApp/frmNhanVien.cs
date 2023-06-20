using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoChoiTreEmApp
{
    public partial class frmNhanVien : Form
    {
        SqlConnection connect =DatabaseConnection.connect;
        SqlDataAdapter adap;
        DataSet dskh;
        Label IDtt = new Label();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            gridviewNhanVien();
        }
        public void gridviewNhanVien()
        {
            //data grid view nhan vien
            string querynv = @"select STT as 'STT', usernv as 'Tên tài khoản', tennv as 'Tên nhân viên', passnv as 'Mật khẩu',chucvu as 'Chức vụ' from nhanvien";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(querynv, connect);
            DataTable datatbsp = new DataTable();
            sqldatasp.Fill(datatbsp);
            dataGridViewNV.DataSource = datatbsp;
            connect.Close();

        }

        public void clearnv()
        {
            txtSttNV.Clear();
            txtUserNV.Clear();
            txtNameNV.Clear();
            txtPassNV.Clear();
            textBox1.Clear();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserNV.Text))
            {
                MessageBox.Show("Trống!");
                txtUserNV.Select();
            }

            if (string.IsNullOrWhiteSpace(txtNameNV.Text))
            {
                txtNameNV.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPassNV.Text))
            {
                txtPassNV.Select();
            }
            else
            {
                using (var cmd = new SqlCommand("INSERT INTO nhanvien (usernv,tennv,passnv,chucvu) VALUES (@usernv,@tennv,@passnv,@chucvu)"))
                {
                    cmd.Connection = connect;
                    //    cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                    cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                    cmd.Parameters.AddWithValue("@tennv", txtNameNV.Text);
                    cmd.Parameters.AddWithValue("@passnv", txtPassNV.Text);
                    cmd.Parameters.AddWithValue("@chucvu", textBox1.Text);
                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm");
                        connect.Close();
                        clearnv();
                        gridviewNhanVien();

                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                        connect.Close();
                    }
                    connect.Close();

                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserNV.Text))
            {
                MessageBox.Show("Trống!");
                txtUserNV.Select();
            }

            if (string.IsNullOrWhiteSpace(txtNameNV.Text))
            {
                txtNameNV.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPassNV.Text))
            {
                txtPassNV.Select();
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update nhanvien set usernv=@usernv,tennv=@tennv,passnv=@passnv,chucvu =@Chucvu where STT=@STT"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@STT", txtSttNV.Text);
                        cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                        cmd.Parameters.AddWithValue("@tennv", txtNameNV.Text);
                        cmd.Parameters.AddWithValue("@passnv", txtPassNV.Text);
                        cmd.Parameters.AddWithValue("@Chucvu", textBox1.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã lưu");
                            connect.Close();
                            clearnv();
                            gridviewNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error during update: " + ex.Message);
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserNV.Text))
            {
                MessageBox.Show("Thông tin trống!");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("delete nhanvien where usernv=@usernv"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa");
                            connect.Close();
                            clearnv();
                            gridviewNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error during delete: " + ex.Message);
                }

            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            clearnv();
        }

        

        private void dataGridViewNV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridViewNV.CurrentRow.Index != -1)
            {
                txtSttNV.Text = dataGridViewNV.CurrentRow.Cells[0].Value.ToString();
                txtUserNV.Text = dataGridViewNV.CurrentRow.Cells[1].Value.ToString();
                txtNameNV.Text = dataGridViewNV.CurrentRow.Cells[2].Value.ToString();
                txtPassNV.Text = dataGridViewNV.CurrentRow.Cells[3].Value.ToString();
                textBox1.Text = dataGridViewNV.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {

            }*/
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNV.CurrentRow.Index != -1)
            {
                txtSttNV.Text = dataGridViewNV.CurrentRow.Cells[0].Value.ToString();
                txtUserNV.Text = dataGridViewNV.CurrentRow.Cells[1].Value.ToString();
                txtNameNV.Text = dataGridViewNV.CurrentRow.Cells[2].Value.ToString();
                txtPassNV.Text = dataGridViewNV.CurrentRow.Cells[3].Value.ToString();
                textBox1.Text = dataGridViewNV.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {

            }
        }
    }
}
