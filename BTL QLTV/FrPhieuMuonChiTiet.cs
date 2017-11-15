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
    public partial class FrPhieuMuonChiTiet : Form
    {
        public FrPhieuMuonChiTiet()
        {
            InitializeComponent();
            KHOATEXTBOX();
            btnl.Enabled = false;
        }
        bool themmoi; // đặt biến thêm mới để làm nút thêm và sửa
        //Làm rỗng các textbox
        public void SETNULL()
        {

            txtmpm.Clear();
            txtms.Clear();
            txtsl.Clear();
            txtmpm.Clear();

        }
        //Khóa các teext box
        public void KHOATEXTBOX()
        {

            txtmpmct.Enabled = false;
            txtsl.Enabled = false;
            txtms.Enabled = false;
            txtmpm.Enabled = false;
            btnl.Enabled = false;
        }
        //Mở các text box
        public void MOTB()
        {


            txtmpmct.Enabled = true;
            txtsl.Enabled = true;
            txtms.Enabled = true;
            txtmpm.Enabled = true;
            btnl.Enabled = true;

        }
        //Khóa các nút điều khiển
        public void KHOADK()
        {
            btns.Enabled = false;
            btnl.Enabled = true;
            btns.Enabled = false;
            btnx.Enabled = false;
            btntk.Enabled = false;
            btnt.Enabled = false;

            btnbq.Enabled = true;
        }

        private void FrPhieuMuonChiTiet_Load(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand cmd = new SqlCommand("dsphieumuonchitiet", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgrv.DataSource = dt;
                dtgrv.ReadOnly = true;

            }
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            MOTB();
            KHOADK();
            themmoi = true;
            txtmpmct.Clear();
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
                SqlCommand cmd = new SqlCommand("xoaphieumuonchitiet", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                int MaPhieuMuonChiTiet = (int)dtgrv.CurrentRow.Cells["MaPhieuMuonChiTiet"].Value;

                SqlParameter p = new SqlParameter("@MaPhieuMuonChiTiet", MaPhieuMuonChiTiet);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo !");
                    FrPhieuMuonChiTiet_Load(sender, e);
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!", "Thông Báo !");
            }
            conn.Close();
            conn.Dispose();
            SETNULL();

        }

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btnbq.Enabled = true;
            btntk.Enabled = true;
            btnl.Enabled = false;
            try
            {
                txtmpmct.Text = dtgrv.CurrentRow.Cells["MaPhieuMuonChiTiet"].Value.ToString();
                txtms.Text = dtgrv.CurrentRow.Cells["MaSach"].Value.ToString();
                txtsl.Text = dtgrv.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtmpm.Text = dtgrv.CurrentRow.Cells["MaPhieuMuon"].Value.ToString();

            }
            catch
            {

            }
        }

        private void btns_Click(object sender, EventArgs e)
        {
            KHOADK();
            MOTB();
            txtmpmct.Focus();
            themmoi = false;
        }

        private void btnbq_Click(object sender, EventArgs e)
        {
            FrPhieuMuonChiTiet_Load(sender, e);
            SETNULL();
            KHOATEXTBOX();
            KHOADK();
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btntk.Enabled = true;
            btnl.Enabled = true;
            
            
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);

            //NẾU THÊM MÓI 
            if (themmoi == true)
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("themphieumuonchitiet", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuonChiTiet", txtmpmct.Text);
                    cmd.Parameters.AddWithValue("@MaSach", txtms.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtsl.Text);
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", txtmpm.Text);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm chi tiet phieu muon moi thành công !", "Thông Báo !");
                        FrPhieuMuonChiTiet_Load(sender, e);
                    }
                    else MessageBox.Show("Không thể thêm mới !", "Thông Báo !");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Mã phieu muon chi tiet này đã tồn tại ko thể thêm mới !", "Thông báo !");
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("suaphieumuonchitiet", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuonChitiet", txtmpmct.Text);
                    cmd.Parameters.AddWithValue("@MaSach", txtms.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtsl.Text);
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", txtms.Text);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        FrPhieuMuonChiTiet_Load(sender, e);
                        MessageBox.Show("Sửa thành công !", "Thông Báo !");

                    }
                    else MessageBox.Show("Không sửa được!", "Thông Báo");
                }
            }
             
        }

        private void hienPhieuMuonChiTiet(string dieukienloc)
        {
            DataTable tblphieumuonchitiet = getphieumuonchitiet();
            DataView dvphieumuonchitiet = tblphieumuonchitiet.DefaultView;
            dvphieumuonchitiet.Sort = "MaSach";
            if (!string.IsNullOrEmpty(dieukienloc))
                dvphieumuonchitiet.RowFilter = dieukienloc;
            dtgrv.DataSource = dvphieumuonchitiet;
        }

        private DataTable getphieumuonchitiet()
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("getphieumuonchitiet", conn))
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
        private void btntk_Click(object sender, EventArgs e)
        {
            txtms.Enabled = true;
            txtms.Focus();
            string dieukienloc = "MaPhieuMuonChiTiet>0";
            if (!string.IsNullOrEmpty(txtms.Text))
                dieukienloc += string.Format("AND MaSach LIKE '%{0}%'", txtms.Text);
            
            if (!string.IsNullOrEmpty(txtsl.Text))
                dieukienloc += string.Format("AND SoLuong LIKE '%{0}%'", txtsl.Text);

            if (!string.IsNullOrEmpty(txtmpm.Text))
                dieukienloc += string.Format("AND MaPhieuMuon LIKE '%{0}%'", txtmpm.Text);
            hienPhieuMuonChiTiet(dieukienloc);
        }
       /* public static SqlConnection conn { get; set; }
        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsl.Text))
            {
                errorPro.SetError(txtsl, "số lương không được để trống !");
                btnl.Enabled = false;
            }
            else
            {
                errorPro.Clear();
                btnl.Enabled = true;
            }

        }*/

    }
}
