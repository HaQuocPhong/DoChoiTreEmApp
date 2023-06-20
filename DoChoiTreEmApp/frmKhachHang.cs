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
    public partial class frmKhachHang : Form
    {
        SqlConnection connect = DatabaseConnection.connect;
        SqlDataAdapter adap;
        DataSet dskh;
        Label IDtt = new Label();
        public frmKhachHang()
        {
            InitializeComponent();
            gridviewKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void gridviewKhachHang()
        {
            //datagridview thong tin khach hang

            try
            {
                connect.Open();
                adap = new SqlDataAdapter("select IDkh as 'ID', TenKH as 'Tên khách hàng', SDT as 'SĐT', DiaChi as 'Địa chỉ',Email as 'Email' from KhachHang", connect);
                dskh = new System.Data.DataSet();
                adap.Fill(dskh, "KhachHangTable");
                dataGridViewKH.DataSource = dskh.Tables[0];
                connect.Close();
            }
            catch (Exception ex)
            {
                //connect.Close();
                //MessageBox.Show(ex.Message);
            }

        }
        SqlCommandBuilder cmdbuilder;

        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbuilder = new SqlCommandBuilder();
                adap.UpdateCommand = new SqlCommandBuilder(adap).GetUpdateCommand();
                adap.Update(dskh, "KhachHangTable");
                MessageBox.Show("Cập nhật thành công!");
                connect.Close();
            }
            catch (Exception ex)
            {
                //connect.Close();
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
