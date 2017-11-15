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

namespace BTL_QLTV
{
    public partial class FrDangNhap : Form
    {
        public FrDangNhap()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // Khi click vào nút thoát
        private void btnt_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc chắn muốn thoát ? " ,"Thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb==DialogResult.OK)
            {
                this.Close();
            }


        }
        // Khi click vào nút hiện mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbmk.Checked)
            {
                txttk.PasswordChar = '\0';
                txtmk.PasswordChar = '\0';
            }
            else
            {
                txttk.PasswordChar = '\0';
                txtmk.PasswordChar = '*';
            }
        }
        // Khi click vào nút đăng nhập
        private void btndn_Click(object sender, EventArgs e)
        {
            if(txttk.Text == "" && txtmk.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và mật khẩu !", "Thông báo !");
                txttk.Focus();
            }
            else if (txttk.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản ! ", "Thông báo !");
                txttk.Focus();
            }
            else if ( txtmk.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !", "Thông báo !");
                txtmk.Focus();
            }
            else
            {
                string connString = (ketnoi.conn);
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string sqlkt = "Select count(*) from tblLoGin WHERE TenDangNhap=N'"+txttk.Text+"' and MatKhau=N'"+txtmk.Text+"'";
                SqlCommand cmd = new SqlCommand(sqlkt, conn);
                int count = (int)cmd.ExecuteScalar();
                if (count==1)
                {
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo !");
                     FormMain.taikhoan = txttk.Text;
                 //   FrGiaoDien.matkhau = txtmk.Text;
                       FormMain gd = new FormMain();
                       gd.Show();
                  //  FrGiaoDien.taikhoan = txttk.Text;
                   
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo !");
                    txttk.Focus();
                }
                conn.Close();
            }


        }



        public SqlConnection conn { get; set; }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
