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
    public partial class frmThuongHieu : Form
    {
        SqlConnection connect = DatabaseConnection.connect;

        public frmThuongHieu()
        {
            InitializeComponent();
        }

        /*private void addIDThuongHieu()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select count(IDdonvi) from donvisp", connect);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            connect.Close();
            i++;
            textBoxID.Text = i.ToString();
        }*/

        private void clear()
        {
            textBoxTenDV.Clear();
        }

        private void gridviewsp()
        {
            string querydv = @"select IDdonvi as 'ID thương hiệu', TenDonvi as 'Tên thương hiệu' from donvisp";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(querydv, connect);
            DataTable datatbdv = new DataTable();
            sqldatasp.Fill(datatbdv);
            dataGridViewDVsp.DataSource = datatbdv;
            connect.Close();
        }

        private void frmThuongHieu_Load(object sender, EventArgs e)
        {
            //addIDThuongHieu();
            gridviewsp();
        }

        private void dataGridViewDVsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear();
            if (dataGridViewDVsp.CurrentRow.Index != -1)
            {
                textBoxID.Text = dataGridViewDVsp.CurrentRow.Cells[0].Value.ToString();
                textBoxTenDV.Text = dataGridViewDVsp.CurrentRow.Cells[1].Value.ToString();
            }
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
                using (var cmd = new SqlCommand("INSERT INTO donvisp (IDdonvi,TenDonvi) VALUES (@IDdonvi,@TenDonvi)"))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@IDdonvi", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@TenDonvi", textBoxTenDV.Text);

                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm");
                        connect.Close();
                        clear();
                        gridviewsp();
                        //addIDThuongHieu();
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
                    using (var cmd = new SqlCommand("update donvisp set TenDonVi=@TenDonvi where IDdonvi=@IDdonvi"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDdonvi", textBoxID.Text);
                        cmd.Parameters.AddWithValue("@TenDonvi", textBoxTenDV.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã lựu");
                            connect.Close();
                            clear();
                            gridviewsp();
                            //addIDThuongHieu();
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
                    using (var cmd = new SqlCommand("delete donvisp where IDdonvi=@IDdonvi"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDdonvi", textBoxID.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa");
                            connect.Close();
                            clear();
                            gridviewsp();
                            //addIDThuongHieu();
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
                    MessageBox.Show("Error during delete: " + ex.Message);
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
