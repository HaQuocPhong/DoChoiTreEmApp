using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DoChoiTreEmApp
{
    public partial class frmMain : Form
    {

        SqlConnection connect = DatabaseConnection.connect;
        
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;

        private IconButton currentBtn;
        //private Panel leftBorderBtn;
        private Form currentChildForm;

        public static string tennv = "";
        public static string chucvu = "";
        public frmMain()
        {
            InitializeComponent();
            //
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 42);
            //pnLeft.Controls.Add(leftBorderBtn);
            //
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(240, 78, 71);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(45, 68, 99);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconmenusmall.IconChar = currentBtn.IconChar;
                //iconmenusmall.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(45, 68, 99);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnView.Controls.Add(childForm);
            pnView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label2.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            //leftBorderBtn.Visible = true;
            iconmenusmall.IconChar = IconChar.Home;
            //iconmenusmall.IconColor = Color.MediumPurple;
            label2.Text = "Trang chủ";
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            if(pnLeft.Visible == false)
            {
                pnLeft.Visible = true;
            }
            else
            {
                pnLeft.Visible = false;
            }
        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void ibtnTrangchu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void hideButtom()
        {
            ibtnThuongHieu.Visible = false;
            ibtnLoai.Visible = false;
            ibtnTonkho.Visible = false;
            ibtnNhapKho.Visible = false;
        }

        private void ibtnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmBanHang());
            hideButtom();
        }

        private void ibtnDonHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmDonHang());
            hideButtom();
        }

        private void ibtnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            ibtnTonkho.Visible = false;
            ibtnNhapKho.Visible = false;
            if (ibtnThuongHieu.Visible == false && ibtnLoai.Visible == false)
            {
                ibtnThuongHieu.Visible = true;
                ibtnLoai.Visible = true;
            }
            else
            {
                ibtnThuongHieu.Visible = false;
                ibtnLoai.Visible = false;
            }
        }

        private void ibtnKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            ibtnThuongHieu.Visible = false;
            ibtnLoai.Visible = false;
            if (ibtnTonkho.Visible == false && ibtnNhapKho.Visible == false)
            {
                ibtnTonkho.Visible = true;
                ibtnNhapKho.Visible = true;
            }
            else
            {
                ibtnTonkho.Visible = false;
                ibtnNhapKho.Visible = false;
            }
            
        }

        private void ibtnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmThongKe());
            hideButtom();
        }

        private void ibtnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new frmCuaHang());
            hideButtom();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Trang chủ";
            iconmenusmall.IconChar = IconChar.Home;
            try
            {
                connect.Open();
                cmd.CommandText = "select * from nhanvien where usernv='" + frmDangNhap.usernv + "'";
                cmd.Connection = connect;
                rdr = cmd.ExecuteReader();
                bool temp = false;
                while (rdr.Read())
                {
                    LabelUser.Text = rdr.GetString(2);
                    tennv = rdr.GetString(2);
                    lblChucVu.Text = rdr.GetString(4);
                    chucvu = rdr.GetString(4);
                    if(lblChucVu.Text == "Quản lý")
                    {
                        ibtnCuaHang.Visible = true;
                        ibtnNhanVien.Visible = true;
                    }
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("not found");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ibtnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void ibtnLoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoai());
        }

        private void ibtnThuongHieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThuongHieu());
        }

        private void ibtnNhapKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapKho());
        }

        private void ibtnTonkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTonKho());
        }

        private void ibtnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmNhanVien());
            hideButtom();
        }

        private void ibtnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmKhachHang());
            hideButtom();
        }

        public int i = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Left += i;
            if (label3.Left >= this.Width - label3.Width || label3.Left <= 0)
                label3.Left = -10;
        }
    }
}
