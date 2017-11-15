namespace BTL_QLTV
{
    partial class FrThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbsach = new System.Windows.Forms.ComboBox();
            this.cbtheloai = new System.Windows.Forms.ComboBox();
            this.tbnam = new System.Windows.Forms.TextBox();
            this.tbthang = new System.Windows.Forms.TextBox();
            this.btnthongke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.errPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbsach);
            this.groupBox1.Controls.Add(this.cbtheloai);
            this.groupBox1.Controls.Add(this.tbnam);
            this.groupBox1.Controls.Add(this.tbthang);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(509, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbsach
            // 
            this.cbbsach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbsach.FormattingEnabled = true;
            this.cbbsach.Location = new System.Drawing.Point(313, 70);
            this.cbbsach.Name = "cbbsach";
            this.cbbsach.Size = new System.Drawing.Size(157, 27);
            this.cbbsach.TabIndex = 6;
            this.cbbsach.SelectedIndexChanged += new System.EventHandler(this.cbbsach_SelectedIndexChanged);
            // 
            // cbtheloai
            // 
            this.cbtheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtheloai.FormattingEnabled = true;
            this.cbtheloai.Location = new System.Drawing.Point(313, 21);
            this.cbtheloai.Name = "cbtheloai";
            this.cbtheloai.Size = new System.Drawing.Size(157, 27);
            this.cbtheloai.TabIndex = 5;
            this.cbtheloai.SelectedIndexChanged += new System.EventHandler(this.cbtheloai_SelectedIndexChanged);
            // 
            // tbnam
            // 
            this.tbnam.Location = new System.Drawing.Point(115, 70);
            this.tbnam.Name = "tbnam";
            this.tbnam.Size = new System.Drawing.Size(138, 26);
            this.tbnam.TabIndex = 4;
            this.tbnam.TextChanged += new System.EventHandler(this.tbnam_TextChanged);
            this.tbnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnam_KeyPress);
            // 
            // tbthang
            // 
            this.tbthang.Location = new System.Drawing.Point(115, 21);
            this.tbthang.Name = "tbthang";
            this.tbthang.Size = new System.Drawing.Size(138, 26);
            this.tbthang.TabIndex = 4;
            this.tbthang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbthang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbthang_KeyPress);
            // 
            // btnthongke
            // 
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Location = new System.Drawing.Point(213, 118);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(103, 41);
            this.btnthongke.TabIndex = 3;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập năm :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tháng :";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgrv
            // 
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.tongso,
            this.damuon,
            this.sachton});
            this.dtgrv.Location = new System.Drawing.Point(-5, 244);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.Size = new System.Drawing.Size(515, 154);
            this.dtgrv.TabIndex = 0;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellContentClick);
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 170;
            // 
            // tongso
            // 
            this.tongso.DataPropertyName = "tongsach";
            this.tongso.HeaderText = "Tổng số";
            this.tongso.Name = "tongso";
            // 
            // damuon
            // 
            this.damuon.DataPropertyName = "damuon";
            this.damuon.HeaderText = "Đã mượn";
            this.damuon.Name = "damuon";
            // 
            // sachton
            // 
            this.sachton.DataPropertyName = "sachton";
            this.sachton.HeaderText = "Sách tồn";
            this.sachton.Name = "sachton";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "THỐNG KÊ SÁCH";
            // 
            // errPro
            // 
            this.errPro.ContainerControl = this;
            // 
            // FrThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.BaoCaoThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.TextBox tbnam;
        private System.Windows.Forms.TextBox tbthang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errPro;
        private System.Windows.Forms.ComboBox cbtheloai;
        private System.Windows.Forms.ComboBox cbbsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongso;
        private System.Windows.Forms.DataGridViewTextBoxColumn damuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachton;
    }
}