using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_QLTV
{
    public partial class FormMain : Form
    {
        public static string taikhoan = String.Empty;
        public static string matkhau = String.Empty;
        public FormMain()
        {
            InitializeComponent();
        }

        //kiểm tra xem form đã mở chưa
        private bool checkFormOpen(string FormName)
        {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == FormName)
                {
                    frm.Focus();
                    FormFound = true;
                }
            }
            return FormFound;
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(taikhoan))
            {
                this.txttk.Text = taikhoan;
            } 
        }
        // Nếu formSinhViên mở rùi thì ko hiện nữa và ngược lại
        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("FrSinhVien");
            if (check == false)
            {
                FrSinhVien sv = new FrSinhVien();
                sv.MdiParent = this;
                sv.Show();
            }
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("FrBaoCaoThongKe");
            if (check == false)
            {
                FrThongKe tk = new FrThongKe();
                tk.MdiParent = this;
                tk.Show();
            }
        }
        //Nếu form Thủ thư đã mở thì ko cho mở nữa và ngược lại
        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("FrThuThu");
            if (check == false)
            {
                FrThuThu tt = new FrThuThu();
                tt.MdiParent = this;
                tt.Show();
            }
            
        }

        private void chiTiếtPhiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("FrPhieuMuonChiTiet");
            if (check == false)
            {
                FrPhieuMuonChiTiet tt = new FrPhieuMuonChiTiet();
                tt.MdiParent = this;
                tt.Show();
            }
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("FrSach");
            if (check == false)
            {
                FrSach tt = new FrSach();
                tt.MdiParent = this;
                tt.Show();
            }
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("FrTheLoai");
            if (check == false)
            {
                FrTheLoai tt = new FrTheLoai();
                tt.MdiParent = this;
                tt.Show();
            }
        }
    }
}
