using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace BTL_QLTV
{
    public partial class FrDSSinhVien : Form
    {
        public FrDSSinhVien()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void FrDSSinhVien_Load(object sender, EventArgs e)
        {
            kn.kn_csdl();
            DataTable dt = new DataTable();
            string caulenh = "select * from tblSinhVien";
            dt = kn.laybang(caulenh);
            RPSinhVien rp = new RPSinhVien();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
