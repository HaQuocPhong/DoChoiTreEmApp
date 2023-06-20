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

namespace DoChoiTreEmApp
{
    public partial class frmLoai : Form
    {
        
        SqlConnection connect = DatabaseConnection.connect;

        public frmLoai()
        {
            InitializeComponent();
        }

        /*private void addIDLoai()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select count(IDloai) from loaisp", connect);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            textBoxID.Text = i.ToString();
            connect.Close();
        }*/

        private void clear()
        {
            textBoxTenLoai.Clear();
            textBoxID.Clear();
        }

        private void gridviewsploai()
        {
            connect.Open();
            string querysploai = @"select IDloai as 'Mã loại', TenLoai as 'Tên loại' from loaisp";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(querysploai, connect);
            DataTable datatbsploai = new DataTable();
            sqldatasp.Fill(datatbsploai);
            dataGridViewLoaiSPloai.DataSource = datatbsploai;
            connect.Close();
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            //addIDLoai();
            gridviewsploai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Trống mã loại!");
                textBoxID.Select();
            }
            else
            {
                using (var cmd = new SqlCommand("INSERT INTO loaisp (IDloai,TenLoai) VALUES (@IDloai,@TenLoai)"))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@IDloai", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", textBoxTenLoai.Text);

                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm");
                        connect.Close();
                        clear();
                        gridviewsploai();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                        connect.Close();
                    }
                    connect.Close();

                }
            }
            //addIDLoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Thông tin trống!");
            }
            else
            {
                try
                {
                    connect.Open();
                    using (var cmd = new SqlCommand("update loaisp set TenLoai=@TenLoai where IDloai=@IDloai"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDloai", textBoxID.Text);
                        cmd.Parameters.AddWithValue("@TenLoai", textBoxTenLoai.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã lựu");
                            connect.Close();
                            gridviewsploai();
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công!");
                            connect.Close();
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
            clear();
            //addIDLoai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Thông tin trống!");
            }
            else
            {


                try
                {
                    using (var cmd = new SqlCommand("delete loaisp where IDloai=@IDloai"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDloai", textBoxID.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa");
                            connect.Close();
                            clear();
                            gridviewsploai();

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
                    MessageBox.Show("Error during delete: " + ex.Message);
                }

            }
            clear();
        }

        private void dataGridViewLoaiSPloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLoaiSPloai.CurrentRow.Index != -1)
            {
                textBoxID.Text = dataGridViewLoaiSPloai.CurrentRow.Cells[0].Value.ToString();
                textBoxTenLoai.Text = dataGridViewLoaiSPloai.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
