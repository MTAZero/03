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
    public partial class FrTheLoai : Form
    {
        public FrTheLoai()
        {
            InitializeComponent();
            KHOATEXTBOX();
            btnl.Enabled = false;
        }
        bool themmoi; // đặt biến thêm mới để làm nút thêm và sửa
        //Làm rỗng các textbox
        public void SETNULL()
        {
            txtml.Clear();
            txttl.Clear();
            
        }
        //Khóa các teext box
        public void KHOATEXTBOX()
        {
            txtml.Enabled = false;
            txttl.Enabled = false;

        }
        //Mở các text box
        public void MOTB()
        {
            txtml.Enabled = true;
            txttl.Enabled = true;

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
        private void FrTheLoai_Load(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand cmd = new SqlCommand("dstheloai", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgrv.DataSource = dt;
                dtgrv.ReadOnly = true;

            }

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
                txtml.Text = dtgrv.CurrentRow.Cells["MaSach"].Value.ToString();
                txttl.Text = dtgrv.CurrentRow.Cells["TenSach"].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            KHOADK();
            MOTB();
            themmoi = true;
            txtml.Clear();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            KHOADK();
            MOTB();
            txtml.Focus();
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
                SqlCommand cmd = new SqlCommand("xoatheloai", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                int MaLoai = (int)dtgrv.CurrentRow.Cells["MaLoai"].Value;

                SqlParameter p = new SqlParameter("@MaLoai", MaLoai);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo !");
                    FrTheLoai_Load(sender, e);
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!", "Thông Báo !");
            }
            conn.Close();
            conn.Dispose();
            SETNULL();
        }

        public object MaLoai { get; set; }

        private void btnl_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);

            //NẾU THÊM MÓI 
            if (themmoi == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemTheLoai", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Maloai", txtml.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", txttl.Text);
                    
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông Báo");
                        FrTheLoai_Load(sender, e);
                    }
                    else MessageBox.Show("Không thể thêm mới", "Thông Báo");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Mã thể loại này đã tồn tại ko thể thêm mới !", "Thông báo !");
                    return;
                }

            }
            //ngược lại là sửa
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("suatheloai", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLoai", txtml.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", txttl.Text);
                   
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa thành công !", "Thông Báo !");
                        FrTheLoai_Load(sender, e);
                    }
                    else MessageBox.Show("Không sửa được!", "Thông Báo");
                }
            }
        }

        public static DataTable gettheloai()
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("gettheloai", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
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
            DataTable tblsinhvien = gettheloai();
            DataView dvsinhvien = tblsinhvien.DefaultView;
            dvsinhvien.Sort = "TenLoai";
            if (!string.IsNullOrEmpty(dieukienloc))
                dvsinhvien.RowFilter = dieukienloc;
            dtgrv.DataSource = dvsinhvien;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            txttl.Enabled = true;
            txttl.Focus();
            string dieukienloc = "Maloai>0";
            if (!string.IsNullOrEmpty(txttl.Text))
                dieukienloc += string.Format("AND TenLoai LIKE '%{0}%'", txttl.Text);
            hienSach(dieukienloc);
        }

        private void btnbq_Click(object sender, EventArgs e)
        {
            FrTheLoai_Load(sender, e);
            SETNULL();
            KHOATEXTBOX();
            KHOADK();
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btntk.Enabled = true;
            btnl.Enabled = true;
        }

    }
}
