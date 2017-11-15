namespace BTL_QLTV
{
    partial class FrDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrDangNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.ckbmk = new System.Windows.Forms.CheckBox();
            this.btnt = new System.Windows.Forms.Button();
            this.btndn = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.ckbmk);
            this.groupBox1.Controls.Add(this.btnt);
            this.groupBox1.Controls.Add(this.btndn);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điền thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu :";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(137, 86);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(206, 25);
            this.txtmk.TabIndex = 4;
            // 
            // ckbmk
            // 
            this.ckbmk.AutoSize = true;
            this.ckbmk.Location = new System.Drawing.Point(230, 117);
            this.ckbmk.Name = "ckbmk";
            this.ckbmk.Size = new System.Drawing.Size(113, 21);
            this.ckbmk.TabIndex = 3;
            this.ckbmk.Text = "Hiện mật khẩu";
            this.ckbmk.UseVisualStyleBackColor = true;
            this.ckbmk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnt
            // 
            this.btnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt.Location = new System.Drawing.Point(260, 144);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(83, 38);
            this.btnt.TabIndex = 2;
            this.btnt.Text = "Thoát";
            this.btnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btndn
            // 
            this.btndn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndn.Location = new System.Drawing.Point(137, 144);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(104, 38);
            this.btndn.TabIndex = 2;
            this.btndn.Text = "Đăng nhập";
            this.btndn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(137, 36);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(206, 25);
            this.txttk.TabIndex = 1;
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản :";
            // 
            // FrDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 251);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbmk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label2;

    }
}

