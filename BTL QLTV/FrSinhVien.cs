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
    public partial class FrSinhVien : Form
    {
        public FrSinhVien()
        {
            InitializeComponent();
            KHOATEXTBOX();
            btnl.Enabled = false;
        }

        bool themmoi; // đặt biến thêm mới để làm nút thêm và sửa
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Làm rỗng các textbox
        public void SETNULL()
        {
            txtmsv.Clear();
            txttsv.Clear();
            txtsdt.Clear();
            txtemail.Clear();
            txtcmt.Clear();
            txtlop.Clear();
        }
        //Khóa các teext box
        public void KHOATEXTBOX()
        {
            txtmsv.Enabled = false;
            txttsv.Enabled = false;
            dtpkns.Enabled = false;
            txtcmt.Enabled = false;
            txtemail.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            txtsdt.Enabled = false;
            txtlop.Enabled = false;
            
        }
        //Mở các text box
        public void MOTB()
        {
            txtmsv.Enabled = true;
            txttsv.Enabled = true;
            dtpkns.Enabled = true;
            txtcmt.Enabled = true;
            txtemail.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            txtsdt.Enabled = true;
            txtlop.Enabled = true;
            
           
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
////////////////////////////////////////////////////////////////////////////////////
        //Đổ dl lên texbox khi click vào dtgrv
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnt.Enabled = true;
            btns.Enabled = true;
            btntk.Enabled = true;
            btnx.Enabled = true;
            
            btnbq.Enabled = true;
            btnl.Enabled = false;
            try
            {
                txtmsv.Text = dtgrv.CurrentRow.Cells["MaSV"].Value.ToString();
                txttsv.Text = dtgrv.CurrentRow.Cells["HoTen"].Value.ToString();
                txtsdt.Text = dtgrv.CurrentRow.Cells["SDT"].Value.ToString();
                txtemail.Text = dtgrv.CurrentRow.Cells["Email"].Value.ToString();
                txtcmt.Text = dtgrv.CurrentRow.Cells["CMND"].Value.ToString();
                dtpkns.Text = dtgrv.CurrentRow.Cells["NgaySinh"].Value.ToString();
                txtlop.Text = dtgrv.CurrentRow.Cells["Lop"].Value.ToString();
                rdNam.Checked = dtgrv.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                rdNu.Checked = !rdNam.Checked;
            }
            catch (Exception)
            {

            }
        }
     ///  ///// ///////////////////
        // đổ dl của bảng sinhvien ra dtgrv
        private void FrSinhVien_Load(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand cmd = new SqlCommand("dssinhvien", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgrv.DataSource = dt;
                dtgrv.ReadOnly = true;

            }
        }

        private void gbdssv_Enter(object sender, EventArgs e)
        {

        }
        //Khi click vào nút thêm
        private void btnt_Click(object sender, EventArgs e)
        {
            KHOADK();
            MOTB();
            themmoi = true;
            txtmsv.Clear();

        }
        //Khi click vào nút sua
        private void btns_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            KHOADK();
            MOTB();
            txtmsv.Focus();
            themmoi = false;

        }
        //Khi click vào nút xóa
        private void btnx_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn); 
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            KHOADK();
            btnl.Enabled = false;
            if (MessageBox.Show("Bạn có chắc chắn muôn xóa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("XoaSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    int MaSV = (int)dtgrv.CurrentRow.Cells["MaSV"].Value;
 
                    SqlParameter p = new SqlParameter("@MaSV", MaSV);
                    cmd.Parameters.Add(p);
 
                    int count = cmd.ExecuteNonQuery();
 
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa thành công!","Thông Báo !");
                        FrSinhVien_Load(sender,e);
                    }
                    else MessageBox.Show("Không thể xóa bản ghi hiện thời!","Thông Báo !");
                }
            conn.Close();
            conn.Dispose();
            SETNULL();
        }
        //Khi click vào nút lưu
        private void btnl_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            
            //NẾU THÊM MÓI 
            if (themmoi==true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", txtmsv.Text);
                    cmd.Parameters.AddWithValue("@Hoten", txttsv.Text);
                    cmd.Parameters.AddWithValue("@Ngaysinh", dtpkns.Text);
                    cmd.Parameters.AddWithValue("@Gioitinh", rdNam.Checked ? rdNam.Text : rdNu.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@CMND", txtcmt.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtlop.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông Báo");
                        FrSinhVien_Load(sender, e);
                    }
                    else MessageBox.Show("Không thể thêm mới", "Thông Báo");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại ko thể thêm mới !", "Thông báo !");
                    return;
                }      
                
            }
                //ngược lại là sửa
            else
            { 
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("SuaSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", txtmsv.Text);
                    cmd.Parameters.AddWithValue("@Hoten", txttsv.Text);
                    cmd.Parameters.AddWithValue("@Ngaysinh", dtpkns.Text);
                    cmd.Parameters.AddWithValue("@Gioitinh", rdNam.Checked ? rdNam.Text : rdNu.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@CMND", txtcmt.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtlop.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa thành công !", "Thông Báo !");
                        FrSinhVien_Load(sender, e);
                    }
                    else MessageBox.Show("Không sửa được!","Thông Báo");
                }
            }
        }




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static DataTable getSinhvien()
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("getsinhvien", conn))
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

        private void hienSinhvien(string dieukienloc)
        {
            DataTable tblsinhvien = getSinhvien();
            DataView dvsinhvien = tblsinhvien.DefaultView;
            dvsinhvien.Sort = "HoTen";
            if (!string.IsNullOrEmpty(dieukienloc))
                dvsinhvien.RowFilter = dieukienloc;
            dtgrv.DataSource = dvsinhvien;
        }
        // tìm kiếm
        private void btntk_Click(object sender, EventArgs e)
        {
            txttsv.Enabled = true;
            txttsv.Focus();
            string dieukienloc = "MaSV>0";
            if (!string.IsNullOrEmpty(txttsv.Text))
                dieukienloc += string.Format("AND HoTen LIKE '%{0}%'", txttsv.Text);
            // if (checkgt)
            // dieukienloc += string.Format("AND GioiTinh LIKE '%{0}%'", rdNam.Checked ? rdNam.Text : rdNu.Text);
            // if (!string.IsNullOrEmpty(dtpkns.Text))
            //   dieukienloc += string.Format("AND Ngaysinh LIKE '%{0}%'", dtpkns.Text);
            if (!string.IsNullOrEmpty(txtsdt.Text))
                dieukienloc += string.Format("AND SDT LIKE '%{0}%'", txtsdt.Text);
            if (!string.IsNullOrEmpty(txtcmt.Text))
                dieukienloc += string.Format("AND CMND LIKE '%{0}%'", txtcmt.Text);
            if (!string.IsNullOrEmpty(txtlop.Text))
                dieukienloc += string.Format("AND Lop LIKE '%{0}%'", txtlop.Text);
            hienSinhvien(dieukienloc);
            

        }


        public static SqlConnection conn { get; set; }

        // Bắt lỗi khi nhập số điện thoại không đúng
        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtsdt.Text, @"^(0\d{9,11})$"))
            {
                  errorPro.SetError(txtsdt,"Số điện thoại không hợp lệ .Bạn cần bắt đầu sđt từ số 0 !");
                  btnl.Enabled = false;
            }

            else
            {
                btnl.Enabled = true;
                errorPro.Clear();
            }
           
        }
        // Bắt lỗi khi nhập số email không đúng
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtemail.Text, @"^(\w+@\w+\.\w+)$"))
            {
                errorPro.SetError(txtemail, "Địa chỉ email không hợp lệ !");
                btnl.Enabled = false;
            }
            
            else if(txtemail.TextLength>98)
            {
                MessageBox.Show("Email không được nhập dài quá 100 kí tự !", "Thông báo !");
                txtemail.Clear();
            }
            else
            {
                errorPro.Clear();
                btnl.Enabled = true;
            }
            
                
        }
        // Bắt lỗi khi nhập cmt không đúng
        private void txtcmt_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtcmt.Text, @"^([0-9]{9})$"))
            {
                errorPro.SetError(txtcmt, "Chứng minh thư không hợp lệ !");
                btnl.Enabled = false;
            }
              
            else
            {
                btnl.Enabled = true;
                errorPro.Clear();
            } 

            
        }
        // bắt lôi không nhập tên sinh viên
        private void txttsv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txttsv.Text))
            {
                 errorPro.SetError(txttsv, "Tên sinh viên không được để trống !");
                 btnl.Enabled = false;
            }
            else
            {
                errorPro.Clear();
                btnl.Enabled = true;
            } 
           
                
        }
       
        
       
            

      

        private void button1_Click(object sender, EventArgs e)
        {

           
            
        }

        private void btnbq_Click(object sender, EventArgs e)
        {
            FrSinhVien_Load(sender, e);
            SETNULL();
            KHOATEXTBOX();
            errorPro.Clear();
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btntk.Enabled = true;
           
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        // Số điện thoại yêu cầu phải nhập kí tự số và không được quá 11 số
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần nhập số điện thoại là kí tự số  !", "Thông Báo ! ");
            }
            else if(txtsdt.TextLength>10)
            {
                MessageBox.Show("Số điện thoại không được lớn hơn 11 số !", "Thông báo !");
                txtsdt.Clear();
            }
            
        }

        private void txtcmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Bạn cần nhập chứng minh thư là kí tự số !", "Thông Báo !");
            }
            else if(txtcmt.TextLength>8)
            {
                MessageBox.Show("Chứng minh thư không được nhiều hơn 9 số !", "Thông báo !");
            }
        }
        // Họ tên sinh viên yêu cầu phải nhập kí tự chữ và không quá 50ki tự
        private void txttsv_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ! ", "Thông Báo ! ");
            } 
            else if(txttsv.TextLength>48)
            {
                MessageBox.Show("Họ tên không được dài quá 50 ký tự !", "Thông báo !");
                txttsv.Clear();
            }
        }

        private void cbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    }
 }

