using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLTV
{
    public partial class FrThongKe : Form
    {
        public FrThongKe()
        {
            InitializeComponent();
            laydlcbthloai();
            dtgrv.ReadOnly = true;
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

       

        private void button3_Click(object sender, EventArgs e)
        {

            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string MaLoai = cbtheloai.SelectedValue.ToString();
          //  Convert.ToInt32(MaLoai);
           // MessageBox.Show(MaLoai.ToString());
            using (SqlCommand cmd = new SqlCommand("thongke", conn))
            { 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@thang", tbthang.Text);
                cmd.Parameters.AddWithValue("@nam", tbnam.Text);
                cmd.Parameters.AddWithValue("@MaLoai", MaLoai);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    dtgrv.DataSource = tbl;
                }
            }
            conn.Close();
            conn.Dispose();
           
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbthang.Text))
            {
                errPro.SetError(tbthang, "Bạn cần chọn tháng để có thể thống kê !");
                btnthongke.Enabled = false;
            }
            else if(tbthang.TextLength>2)
            {
                MessageBox.Show(" Bạn nhập sai tháng ! ", "Thông báo !");
                tbthang.Clear();
            }
           
            else
            {
                errPro.Clear();
                btnthongke.Enabled = true;
            }
        }

        private void tbnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần nhập năm  là kí tự số  !", "Thông Báo ! ");
            }
        }

        private void tbthang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần nhập tháng là kí tự số  !", "Thông Báo ! ");
            }
             
        }

        private void tbnam_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbnam.Text))
            {
                errPro.SetError(tbnam, "Bạn cần chọn năm để có thể thống kê !");
                btnthongke.Enabled = false;
            }
            else if(tbnam.TextLength>4)
            {
                MessageBox.Show("Vui lòng nhập đúng năm !", "Thông báo !");
                tbnam.Clear();
            }
            else
            {
                errPro.Clear();
                btnthongke.Enabled = true;
            }
        }

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public SqlConnection conn { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //Lấy dữ liệu thể loại đổ ra cb box
        public void laydlcbthloai()
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("laytheloai", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Columns.Add("MaLoai");
                dt.Columns.Add("TenLoai");
                
                dt.Rows.Add("", "-- Chọn Thể Loại --");
               
                da.Fill(dt);
                cbtheloai.DataSource = dt;
                cbtheloai.SelectedIndex = 0;
                cbtheloai.DisplayMember = "TenLoai";
                cbtheloai.ValueMember = "MaLoai";
            }
            conn.Close();
        }

        
        

        private void cbbsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtheloai.SelectedIndex > 0)
            {

                string connString = (ketnoi.conn);
                SqlConnection conn = new SqlConnection(connString);
                string MaTheLoai = cbtheloai.SelectedValue.ToString();
               // MessageBox.Show(MaTheLoai);
               conn.Open();
                using (SqlCommand cmd = new SqlCommand("laysachtheotheloai", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLoai", MaTheLoai);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaSach");
                    dt.Columns.Add("TenSach");
                    dt.Rows.Add("", "-- Chọn Sách --");
                    da.Fill(dt);
                    cbbsach.DataSource = dt;
                    cbbsach.SelectedIndex = 0;
                    cbbsach.DisplayMember = "TenSach";
                    cbbsach.ValueMember = "MaSach";
                }
                conn.Close();
                
            }
        }



        public object MaLoai { get; set; }
    }
    
       
}
