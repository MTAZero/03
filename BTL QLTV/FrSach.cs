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
    public partial class FrSach : Form
    {
        public FrSach()
        {
            InitializeComponent();
            KHOATEXTBOX();
            btnl.Enabled = false;

        }
        bool themmoi; // đặt biến thêm mới để làm nút thêm và sửa
        //Làm rỗng các textbox
        public void SETNULL()
        {
            txtms.Clear();
            txtts.Clear();
            txtsl.Clear();
            txtnxb.Clear();
            txtnamxb.Clear();
            txtml.Clear();
        }
        //Khóa các teext box
        public void KHOATEXTBOX()
        {
            txtms.Enabled = false;
            txtts.Enabled = false;
            txtsl.Enabled = false;
            txtnxb.Enabled = false;
            txtnamxb.Enabled = false;
            txtml.Enabled = false;

            timeCheck.Enabled = false;
        }
        //Mở các text box
        public void MOTB()
        {
            txtms.Enabled = true;
            txtts.Enabled = true;
            txtsl.Enabled = true;
            txtnxb.Enabled = true;
            txtnamxb.Enabled = true;
            txtml.Enabled = true;

            timeCheck.Enabled = true;

        }
        //Khóa các nút điều khiển
        public void KHOADK()
        {
            btns.Enabled = false;
            btnl.Enabled = true;
            btnx.Enabled = false;
            btntk.Enabled = false;
            btnt.Enabled = false;
            btnbq.Enabled = true;
            
        }

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnt.Enabled = true;
            btns.Enabled = true;
            btntk.Enabled = true;
            btnx.Enabled = true;
            btnbq.Enabled = true;
            btnl.Enabled = false;
            try
            {
                txtms.Text = dtgrv.CurrentRow.Cells["MaSach"].Value.ToString();
                txtts.Text = dtgrv.CurrentRow.Cells["TenSach"].Value.ToString();
                txtsl.Text = dtgrv.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtnxb.Text = dtgrv.CurrentRow.Cells["NXB"].Value.ToString();
                txtnamxb.Text = dtgrv.CurrentRow.Cells["NamXB"].Value.ToString();
                txtml.Text = dtgrv.CurrentRow.Cells["MaLoai"].Value.ToString();
                
            }
            catch (Exception)
            {

            }
        }

        private void FrSach_Load(object sender, EventArgs e)
        {
            //string connString = (ketnoi.conn);
            //SqlConnection conn = new SqlConnection(connString);
            //using (SqlCommand cmd = new SqlCommand("dssach", conn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dtgrv.DataSource = dt;
            //    dtgrv.ReadOnly = true;

            //}

            dtgrv.DataSource = getSach();
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            KHOADK();
            MOTB();
            themmoi = true;
            txtms.Clear();

            
        }

        private void btns_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            KHOADK();
            MOTB();
            txtms.Focus();
            themmoi = false;

            
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            KHOADK();
            btnl.Enabled = false;
            if (MessageBox.Show("Bạn có chắc chắn muôn xóa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("xoasach", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                int MaSach = (int)dtgrv.CurrentRow.Cells["MaSach"].Value;

                SqlParameter p = new SqlParameter("@MaSach", MaSach);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo !");
                    FrSach_Load(sender, e);
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!", "Thông Báo !");
            }
            conn.Close();
            conn.Dispose();
            SETNULL();
        }


        public object MaSach { get; set; }

        private void btnl_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);

            //NẾU THÊM MÓI 
            if (themmoi == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemSach", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSach", txtms.Text);
                    cmd.Parameters.AddWithValue("@TenSach", txtts.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtsl.Text);
                    cmd.Parameters.AddWithValue("@NXB", txtnxb.Text);
                    cmd.Parameters.AddWithValue("@NamXB", txtnamxb.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", txtml.Text);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông Báo");
                        FrSach_Load(sender, e);
                    }
                    else MessageBox.Show("Không thể thêm mới", "Thông Báo");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Mã sách này đã tồn tại ko thể thêm mới !", "Thông báo !");
                    return;
                }

            }
            //ngược lại là sửa
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("SuaSach", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSach", txtms.Text);
                    cmd.Parameters.AddWithValue("@TenSach", txtts.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtsl.Text);
                    cmd.Parameters.AddWithValue("@NXB", txtnxb.Text);
                    cmd.Parameters.AddWithValue("@NamXB", txtnamxb.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", txtml.Text);
                    
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa thành công !", "Thông Báo !");
                        FrSach_Load(sender, e);
                    }
                    else MessageBox.Show("Không sửa được!", "Thông Báo");
                }
            }
        }
        public static DataTable getSach()
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("select MaSach, TenSach, SoLuong, NXB, NamXB, TenLoai from tblSach, tblTheLoai where tblSach.MaLoai = tblTheLoai.MaLoai", conn))
            {

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }// end da
            }// end cmd
        }

        private void hienSach(string dieukienloc)
        {
            DataTable tblsinhvien = getSach();
            DataView dvsinhvien = tblsinhvien.DefaultView;
            dvsinhvien.Sort = "TenSach";
            if (!string.IsNullOrEmpty(dieukienloc))
                dvsinhvien.RowFilter = dieukienloc;
            dtgrv.DataSource = dvsinhvien;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            txtts.Enabled = true;
            txtts.Focus();
            string dieukienloc = "MaSach>0";
            if (!string.IsNullOrEmpty(txtts.Text))
                dieukienloc += string.Format("AND TenSach LIKE '%{0}%'", txtts.Text);
            if (!string.IsNullOrEmpty(txtsl.Text))
                dieukienloc += string.Format("AND SoLuong LIKE '%{0}%'", txtsl.Text);
            if (!string.IsNullOrEmpty(txtnxb.Text))
                dieukienloc += string.Format("AND NXB LIKE '%{0}%'", txtnxb.Text);
            if (!string.IsNullOrEmpty(txtnamxb.Text))
                dieukienloc += string.Format("AND NamXB LIKE '%{0}%'", txtnamxb.Text);
            if (!string.IsNullOrEmpty(txtml.Text))
                dieukienloc += string.Format("AND MaLoai LIKE '%{0}%'", txtml.Text);
            hienSach(dieukienloc);
            
        }

        private void btnbq_Click(object sender, EventArgs e)
        {
            FrSach_Load(sender, e);
            SETNULL();
            KHOATEXTBOX();
            KHOADK();

            timeCheck.Enabled = false;
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btntk.Enabled = true;
            btnl.Enabled = true;
            
        }

        private void timeCheck_Tick(object sender, EventArgs e)
        {
            bool ok = true;
            if (txtms.Text == "") ok = false;
            if (txtts.Text == "") ok = false;
            if (txtsl.Text == "") ok = false;
            if (txtnxb.Text == "") ok = false;
            if (txtnamxb.Text == "") ok = false;
            if (txtml.Text == "") ok = false;

            btnl.Enabled = ok;
        }
    }
}
