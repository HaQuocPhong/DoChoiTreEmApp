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
    public partial class frmCuaHang : Form
    {
        SqlConnection connect = DatabaseConnection.connect;
        SqlDataAdapter adap;
        DataSet dskh;
        Label IDtt = new Label();
        string imglogoloc = "";

        public frmCuaHang()
        {
            InitializeComponent();

        }

        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Close();
                connect.Open();
                string sqlquery = "select ID,TenShop,Diachi,SDT,Loichao from ThongTinShop";
                SqlCommand command = new SqlCommand(sqlquery, connect);
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    IDtt.Text = sdr["ID"].ToString();
                    txtTenShop.Text = sdr["TenShop"].ToString();
                    txtSDT.Text = sdr["SDT"].ToString();
                    txtDiaChi.Text = sdr["Diachi"].ToString();
                    txtLoiChao.Text = sdr["Loichao"].ToString();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

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

        SqlCommand cmd = new SqlCommand();

        SqlDataReader rdr;
        //  DataSet ds;
        SqlDataAdapter da;

        private void BtnSaveThongtin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenShop.Text))
            {
                MessageBox.Show("Trống!");
                txtTenShop.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                txtSDT.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                txtDiaChi.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtLoiChao.Text))
            {
                txtLoiChao.Select();
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update ThongTinShop set TenShop=@TenShop,SDT=@SDT,Diachi=@Diachi,Loichao=@Loichao where ID=1"))
                    {

                        cmd.Connection = connect;
                        //cmd.Parameters.AddWithValue("@ID", IDtt.Text);
                        cmd.Parameters.AddWithValue("@TenShop", txtTenShop.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Diachi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@Loichao", txtLoiChao.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã lưu");
                            connect.Close();
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
                    MessageBox.Show("Error during update tt: " + ex.Message);
                }
            }
        }

        private void btnButtonChooseIMG_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imglogoloc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imglogoloc;
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Error during insert: " + ex.Message);
            }
        }

        private void SaveIMGlogo_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglogoloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                using (var cmd = new SqlCommand("update ThongTinShop set logo=@logo where ID=1"))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@logo", img);
                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã lưu");
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
