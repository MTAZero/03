namespace BTL_QLTV
{
    partial class FrThuThu
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
            this.txttenthuthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.MaThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnl = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btns = new System.Windows.Forms.Button();
            this.btnt = new System.Windows.Forms.Button();
            this.errPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtmtt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquyen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtquyen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmtt);
            this.groupBox1.Controls.Add(this.txttenthuthu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(325, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thủ thư :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txttenthuthu
            // 
            this.txttenthuthu.Location = new System.Drawing.Point(122, 118);
            this.txttenthuthu.Margin = new System.Windows.Forms.Padding(4);
            this.txttenthuthu.Name = "txttenthuthu";
            this.txttenthuthu.Size = new System.Drawing.Size(183, 26);
            this.txttenthuthu.TabIndex = 1;
            this.txttenthuthu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txttenthuthu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenthuthu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thủ thư :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(351, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(415, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thủ thư :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtgrv
            // 
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuThu,
            this.HoTen,
            this.Quyen});
            this.dtgrv.Location = new System.Drawing.Point(8, 20);
            this.dtgrv.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.Size = new System.Drawing.Size(407, 154);
            this.dtgrv.TabIndex = 0;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaThuThu
            // 
            this.MaThuThu.DataPropertyName = "MaThuThu";
            this.MaThuThu.HeaderText = "Mã thủ thư";
            this.MaThuThu.Name = "MaThuThu";
            this.MaThuThu.Width = 90;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên thủ thư";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền ";
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnl);
            this.groupBox3.Controls.Add(this.btnboqua);
            this.groupBox3.Controls.Add(this.btnx);
            this.groupBox3.Controls.Add(this.btns);
            this.groupBox3.Controls.Add(this.btnt);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(101, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(619, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác :";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnl
            // 
            this.btnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnl.Location = new System.Drawing.Point(408, 39);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(77, 41);
            this.btnl.TabIndex = 5;
            this.btnl.Text = "Lưu";
            this.btnl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(503, 37);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(91, 44);
            this.btnboqua.TabIndex = 4;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnx
            // 
            this.btnx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnx.Location = new System.Drawing.Point(296, 36);
            this.btnx.Margin = new System.Windows.Forms.Padding(4);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(74, 44);
            this.btnx.TabIndex = 3;
            this.btnx.Text = "Xóa";
            this.btnx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btns
            // 
            this.btns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btns.Location = new System.Drawing.Point(188, 39);
            this.btns.Margin = new System.Windows.Forms.Padding(4);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(73, 41);
            this.btns.TabIndex = 2;
            this.btns.Text = "Sửa";
            this.btns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnt
            // 
            this.btnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt.Location = new System.Drawing.Point(58, 39);
            this.btnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(95, 41);
            this.btnt.TabIndex = 1;
            this.btnt.Text = "Thêm";
            this.btnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // errPro
            // 
            this.errPro.ContainerControl = this;
            // 
            // txtmtt
            // 
            this.txtmtt.Location = new System.Drawing.Point(122, 64);
            this.txtmtt.Name = "txtmtt";
            this.txtmtt.Size = new System.Drawing.Size(183, 26);
            this.txtmtt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã thủ thư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quyền";
            // 
            // txtquyen
            // 
            this.txtquyen.Location = new System.Drawing.Point(122, 172);
            this.txtquyen.Name = "txtquyen";
            this.txtquyen.Size = new System.Drawing.Size(183, 26);
            this.txtquyen.TabIndex = 5;
            // 
            // FrThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 337);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrThuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThuThu";
            this.Load += new System.EventHandler(this.FrThuThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenthuthu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.ErrorProvider errPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmtt;
        private System.Windows.Forms.TextBox txtquyen;
        private System.Windows.Forms.Label label3;
    }
}