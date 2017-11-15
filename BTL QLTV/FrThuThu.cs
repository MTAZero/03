using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLTV
{
    public partial class FrThuThu : Form
    {

        
        public FrThuThu()
        {
            InitializeComponent();
            KHOATB();
            btnl.Enabled = false;
        }
        bool themmoi; // đặt biến thêm mới để làm nút thêm và sửa
        //Làm rỗng các textbox
        public void SETNULL()
        {
            txtmtt.Clear();
            txttenthuthu.Clear();
            txtquyen.Clear();
            
        }
        private void FrThuThu_Load(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            using(SqlCommand cmd = new SqlCommand("dsthuthu",conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da= new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgrv.DataSource = dt;
                dtgrv.ReadOnly = true;
               
            }
        }
        public void KHOATB()
        {
            txtmtt.Enabled = false;
            txttenthuthu.Enabled = false;
            txtquyen.Enabled = false;
        }
        public void MOTB()
        {
            txtmtt.Enabled = true;
            txttenthuthu.Enabled = true;
            txtquyen.Enabled = true;
        }
        public void KHOADIEUKHIEN()
        {
            btns.Enabled = false;
            btnl.Enabled = true;
            btnx.Enabled = false;
            btnt.Enabled = false;
            btnboqua.Enabled = true;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnt_Click(object sender, EventArgs e)
        {
            MOTB();
            KHOADIEUKHIEN();
            themmoi = true;
            txtmtt.Clear();
        }
        

        private void btnx_Click(object sender, EventArgs e)
        {
            string connString = (ketnoi.conn);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            KHOADIEUKHIEN();
            btnl.Enabled = false;
            if (MessageBox.Show("Bạn có chắc chắn muôn xóa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("xoathuthu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                int MaThuThu = (int)dtgrv.CurrentRow.Cells["MaThuThu"].Value;

                SqlParameter p = new SqlParameter("@MaThuThu", MaThuThu);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo !");
                    FrThuThu_Load(sender, e);
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!", "Thông Báo !");
            }
            conn.Close();
            conn.Dispose();
            SETNULL();

        }
        // Khi click vào datagriview đổ dl lên txtbox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btnboqua.Enabled = true;
            btnl.Enabled = false;
            try
            {
                txtmtt.Text = dtgrv.CurrentRow.Cells["MaThuThu"].Value.ToString();
                txttenthuthu.Text = dtgrv.CurrentRow.Cells["TenThuThu"].Value.ToString();
                txtquyen.Text = dtgrv.CurrentRow.Cells["Quyen"].Value.ToString();
                
            }
            catch
            {

            }
             
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btns_Click(object sender, EventArgs e)
        {
            KHOADIEUKHIEN();
            MOTB();
            txtmtt.Focus();
            themmoi = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrThuThu_Load(sender, e);
            SETNULL();
            KHOATB();
            KHOADIEUKHIEN();
            btnt.Enabled = true;
            btns.Enabled = true;
            btnx.Enabled = true;
            btnl.Enabled = false;
            errPro.Clear();
            errPro.Clear();


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
                    SqlCommand cmd = new SqlCommand("themthuthu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaThuThu", txtmtt.Text);
                    cmd.Parameters.AddWithValue("@TenThuThu",txttenthuthu.Text);
                    cmd.Parameters.AddWithValue("@Quyen", txtquyen.Text);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thủ thư thành công !", "Thông Báo !");
                        FrThuThu_Load(sender, e);
                    }
                    else MessageBox.Show("Không thể thêm mới !", "Thông Báo !");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Mã thủ thư này đã tồn tại ko thể thêm mới !", "Thông báo !");
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi đang chọn không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("suathuthu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaThuThu", txtmtt.Text);
                    cmd.Parameters.AddWithValue("@TenThuThu", txttenthuthu.Text);
                    cmd.Parameters.AddWithValue("@Quyen", txtquyen.Text);

                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        FrThuThu_Load(sender, e);
                        MessageBox.Show("Sửa thành công !", "Thông Báo !");

                    }
                    else MessageBox.Show("Không sửa được!", "Thông Báo");
                }
            }
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmathuthu_KeyPress(object sender, KeyPressEventArgs e)
        {   
            
             
        }

        private void txttenthuthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ! ", "Thông Báo ! ");
            } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {  
            //Tên ko được để trống 
            if (String.IsNullOrEmpty(txttenthuthu.Text))
            {
                errPro.SetError(txttenthuthu, "Tên thủ thư không được để trống !");
                btnl.Enabled = false;
            }

                //Tên không được vượt quá 30 kí tự 
            else if(txttenthuthu.TextLength>30)
            {
                MessageBox.Show("Tên thủ thư không được quá 30 kí tự !", "Thông báo !");
                txttenthuthu.Clear();
            }

            else
            {
                errPro.Clear();
                btnl.Enabled = true;
            } 
        }


    }
}
