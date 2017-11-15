namespace BTL_QLTV
{
    partial class FrTheLoai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtml = new System.Windows.Forms.TextBox();
            this.txttl = new System.Windows.Forms.TextBox();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.btnt = new System.Windows.Forms.Button();
            this.btns = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.btnbq = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã loại";
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(182, 60);
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(138, 20);
            this.txtml.TabIndex = 5;
            // 
            // txttl
            // 
            this.txttl.Location = new System.Drawing.Point(182, 132);
            this.txttl.Name = "txttl";
            this.txttl.Size = new System.Drawing.Size(138, 20);
            this.txttl.TabIndex = 6;
            // 
            // dtgrv
            // 
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Location = new System.Drawing.Point(363, 34);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.Size = new System.Drawing.Size(412, 226);
            this.dtgrv.TabIndex = 7;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellContentClick);
            // 
            // btnt
            // 
            this.btnt.Location = new System.Drawing.Point(43, 311);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(75, 23);
            this.btnt.TabIndex = 8;
            this.btnt.Text = "Thêm";
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btns
            // 
            this.btns.Location = new System.Drawing.Point(161, 311);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(75, 23);
            this.btns.TabIndex = 9;
            this.btns.Text = "Sửa";
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnx
            // 
            this.btnx.Location = new System.Drawing.Point(282, 311);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 23);
            this.btnx.TabIndex = 10;
            this.btnx.Text = "Xóa";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(397, 311);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 11;
            this.btnl.Text = "Lưu";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // btnbq
            // 
            this.btnbq.Location = new System.Drawing.Point(522, 311);
            this.btnbq.Name = "btnbq";
            this.btnbq.Size = new System.Drawing.Size(75, 23);
            this.btnbq.TabIndex = 12;
            this.btnbq.Text = "Bỏ qua";
            this.btnbq.UseVisualStyleBackColor = true;
            this.btnbq.Click += new System.EventHandler(this.btnbq_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(649, 311);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 13;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // FrTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 349);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnbq);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.btnt);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.txttl);
            this.Controls.Add(this.txtml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrTheLoai";
            this.Text = "FrTheLoai";
            this.Load += new System.EventHandler(this.FrTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtml;
        private System.Windows.Forms.TextBox txttl;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.Button btnbq;
        private System.Windows.Forms.Button btntk;
    }
}