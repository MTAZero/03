namespace BTL_QLTV
{
    partial class FrPhieuMuonChiTiet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.txtmpmct = new System.Windows.Forms.TextBox();
            this.txtmpm = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtms = new System.Windows.Forms.TextBox();
            this.btnt = new System.Windows.Forms.Button();
            this.btns = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.btnbq = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu mượn chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phiếu mượn";
            // 
            // dtgrv
            // 
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Location = new System.Drawing.Point(297, 27);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.Size = new System.Drawing.Size(464, 174);
            this.dtgrv.TabIndex = 5;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellContentClick);
            // 
            // txtmpmct
            // 
            this.txtmpmct.Location = new System.Drawing.Point(190, 40);
            this.txtmpmct.Name = "txtmpmct";
            this.txtmpmct.Size = new System.Drawing.Size(100, 20);
            this.txtmpmct.TabIndex = 6;
            // 
            // txtmpm
            // 
            this.txtmpm.Location = new System.Drawing.Point(190, 195);
            this.txtmpm.Name = "txtmpm";
            this.txtmpm.Size = new System.Drawing.Size(100, 20);
            this.txtmpm.TabIndex = 7;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(190, 134);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 8;
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(190, 79);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(100, 20);
            this.txtms.TabIndex = 9;
            // 
            // btnt
            // 
            this.btnt.Location = new System.Drawing.Point(42, 266);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(75, 23);
            this.btnt.TabIndex = 10;
            this.btnt.Text = "Thêm";
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btns
            // 
            this.btns.Location = new System.Drawing.Point(155, 266);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(75, 23);
            this.btns.TabIndex = 11;
            this.btns.Text = "Sửa";
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnx
            // 
            this.btnx.Location = new System.Drawing.Point(278, 266);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 23);
            this.btnx.TabIndex = 12;
            this.btnx.Text = "Xóa";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(411, 266);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 13;
            this.btnl.Text = "Lưu";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // btnbq
            // 
            this.btnbq.Location = new System.Drawing.Point(549, 266);
            this.btnbq.Name = "btnbq";
            this.btnbq.Size = new System.Drawing.Size(75, 23);
            this.btnbq.TabIndex = 14;
            this.btnbq.Text = "Bỏ qua";
            this.btnbq.UseVisualStyleBackColor = true;
            this.btnbq.Click += new System.EventHandler(this.btnbq_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(683, 266);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 15;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // FrPhieuMuonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 303);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnbq);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.btnt);
            this.Controls.Add(this.txtms);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtmpm);
            this.Controls.Add(this.txtmpmct);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrPhieuMuonChiTiet";
            this.Text = "FrPhieuMuonChiTiet";
            this.Load += new System.EventHandler(this.FrPhieuMuonChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.TextBox txtmpmct;
        private System.Windows.Forms.TextBox txtmpm;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.Button btnbq;
        private System.Windows.Forms.Button btntk;
    }
}