using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoChoiTreEmApp
{
    public partial class frmThongKe : Form
    {
        SqlConnection connect =DatabaseConnection.connect;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        private Form currentchildform;
        string CurrentMonth = DateTime.Now.ToString("MM");
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            motrangcon(new frmChartMoney());
            doanhsobanhang();
            tongslsptrongkho();
            loaisptrongkho();
            khachno();
        }

        private void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            PanelChart.Controls.Add(trangcon);
            PanelChart.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();

        }

        private void doanhsobanhang()
        {

            //   MessageBox.Show(CurrentMonth);
            try
            {
                connect.Open();
                // SqlCommand cmdCountTongHD = new SqlCommand("select COUNT(IDhoadon) from HoaDon", connect);
                SqlCommand cmdCountTongHDThangNay = new SqlCommand("SELECT count( MONTH([HDtime])) as HDtimene from HoaDon where MONTH(HDtime) = '" + CurrentMonth + "'  ", connect);
                SqlCommand cmdCountHDToday = new SqlCommand("select count(IDhoadon) from HoaDon where cast ([HDtime] as date) = cast(getdate() as date)", connect);
                SqlCommand cmdCountTongTienThangNay = new SqlCommand("select sum(HDthanhtoan) from HoaDon where MONTH(HDtime) = '" + CurrentMonth + "'  ", connect);
                SqlCommand cmdCountTienToday = new SqlCommand("select sum(HDthanhtoan) from HoaDon where cast ([HDtime] as date) = cast(getdate() as date)", connect);
                SqlCommand cmdCountDistinctMasp = new SqlCommand("SELECT COUNT(DISTINCT value) FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where MONTH(HDtime) = '" + CurrentMonth + "' ", connect);
                SqlCommand cmdCountDistinctMaspToday = new SqlCommand("SELECT COUNT(DISTINCT value) FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where cast([HDtime] as date) = cast(getdate() as date) ", connect);

                int CountTongHD = Convert.ToInt32(cmdCountTongHDThangNay.ExecuteScalar());
                int CountHDtoday = Convert.ToInt32(cmdCountHDToday.ExecuteScalar());
                var CountTongTienThangNay = (cmdCountTongTienThangNay.ExecuteScalar());
                var CountTienToday = (cmdCountTienToday.ExecuteScalar());
                int CountDistinctMasp = Convert.ToInt32(cmdCountDistinctMasp.ExecuteScalar());
                int CountDistinctMaspToday = Convert.ToInt32(cmdCountDistinctMaspToday.ExecuteScalar());
                if (CountTienToday == DBNull.Value)
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + 0;
                }
                else
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + CountTienToday.ToString();
                }
                if (CountTongTienThangNay == DBNull.Value)
                {
                    lbDoanhSoToday.Text = "0";
                }
                else
                {
                    lbTongDoanhSo.Text = CountTongTienThangNay.ToString();
                }
                lbSumHD.Text = CountTongHD.ToString();
                lbHDtoday.Text = "Hôm nay: " + CountHDtoday.ToString();
                lbSumSP.Text = CountDistinctMasp.ToString();
                lbSPtoday.Text = "Hôm nay: " + CountDistinctMaspToday.ToString();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ket nói 1" + ex.Message);
                connect.Close();
            }
        }

        private void tongslsptrongkho()
        {
            try
            {
                connect.Open();
                SqlCommand cmdCountTongspTrongkho = new SqlCommand("select sum(soluongsp) from tonkho", connect);
                SqlCommand cmdCountNhapKhoToday = new SqlCommand("select COUNT(masp) from nhapkho where cast([ngaynhapkho] as date) = cast(getdate() as date)", connect);
                int CountTongspTrongkho = Convert.ToInt32(cmdCountTongspTrongkho.ExecuteScalar());
                int CountCountNhapKhoToday = Convert.ToInt32(cmdCountNhapKhoToday.ExecuteScalar());
                lbTongSP.Text = CountTongspTrongkho.ToString();
                lbNhapKhoToday.Text = "Nhập kho hôm nay: " + CountCountNhapKhoToday.ToString() + " sản phẩm";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loaisptrongkho()
        {
            try
            {
                connect.Open();
                SqlCommand cmdCountLoaiSPTrongkho = new SqlCommand("select count(masp) from tonkho", connect);
                int CountCountLoaiSPTrongkho = Convert.ToInt32(cmdCountLoaiSPTrongkho.ExecuteScalar());
                lbTongLoaiSp.Text = CountCountLoaiSPTrongkho.ToString();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void khachno()
        {
            try
            {
                connect.Open();
                SqlCommand cmdSumKhachNoThang = new SqlCommand("select sum(HDno) from HoaDon where MONTH(HDtime) = '" + CurrentMonth + "' ", connect);
                SqlCommand cmdKhachNoToday = new SqlCommand("select sum(HDno) from HoaDon where cast ([HDtime] as date) = cast(getdate() as date)", connect);

                int SumKhachNoThang = Convert.ToInt32(cmdSumKhachNoThang.ExecuteScalar());
                var KhachNoToday = cmdKhachNoToday.ExecuteScalar();
                if (KhachNoToday == DBNull.Value)
                {
                    lbKhachNoToday.Text = "Hôm nay: 0";
                }
                else
                {
                    lbKhachNoToday.Text = "Hôm nay: " + KhachNoToday.ToString();
                }
                lbKhachNoThang.Text = SumKhachNoThang.ToString();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChartMoney_Click(object sender, EventArgs e)
        {
            motrangcon(new frmChartMoney());
        }

        private void btnChartSL_Click(object sender, EventArgs e)
        {
            motrangcon(new frmChartSLSP());
        }
    }
}
