namespace test4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datenvl = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtt = new System.Windows.Forms.RadioButton();
            this.rbtts = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.txtsglt = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lbpc = new System.Windows.Forms.Label();
            this.lbsglt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thongke = new System.Windows.Forms.Button();
            this.sapxep = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HOTEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIOITINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIENTHOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NVL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SGLT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHUCAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.datenvl);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtpc);
            this.groupBox1.Controls.Add(this.txtsglt);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.lbpc);
            this.groupBox1.Controls.Add(this.lbsglt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin phóng viên";
            // 
            // datenvl
            // 
            this.datenvl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenvl.Location = new System.Drawing.Point(127, 208);
            this.datenvl.Name = "datenvl";
            this.datenvl.Size = new System.Drawing.Size(200, 20);
            this.datenvl.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtt);
            this.panel2.Controls.Add(this.rbtts);
            this.panel2.Location = new System.Drawing.Point(113, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 26);
            this.panel2.TabIndex = 14;
            // 
            // rbtt
            // 
            this.rbtt.AutoSize = true;
            this.rbtt.Location = new System.Drawing.Point(105, 6);
            this.rbtt.Name = "rbtt";
            this.rbtt.Size = new System.Drawing.Size(73, 17);
            this.rbtt.TabIndex = 3;
            this.rbtt.Text = "thường trú";
            this.rbtt.UseVisualStyleBackColor = true;
            this.rbtt.CheckedChanged += new System.EventHandler(this.rbtt_CheckedChanged);
            // 
            // rbtts
            // 
            this.rbtts.AutoSize = true;
            this.rbtts.Checked = true;
            this.rbtts.Location = new System.Drawing.Point(14, 6);
            this.rbtts.Name = "rbtts";
            this.rbtts.Size = new System.Drawing.Size(80, 17);
            this.rbtts.TabIndex = 2;
            this.rbtts.TabStop = true;
            this.rbtts.Text = "tại tòa soạn";
            this.rbtts.UseVisualStyleBackColor = true;
            this.rbtts.CheckedChanged += new System.EventHandler(this.rbtts_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnu);
            this.panel1.Controls.Add(this.rbnam);
            this.panel1.Location = new System.Drawing.Point(113, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 26);
            this.panel1.TabIndex = 13;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(105, 6);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(37, 17);
            this.rbnu.TabIndex = 1;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Checked = true;
            this.rbnam.Location = new System.Drawing.Point(14, 6);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(45, 17);
            this.rbnam.TabIndex = 0;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // txtpc
            // 
            this.txtpc.Location = new System.Drawing.Point(147, 311);
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(100, 20);
            this.txtpc.TabIndex = 12;
            this.txtpc.Visible = false;
            // 
            // txtsglt
            // 
            this.txtsglt.Location = new System.Drawing.Point(147, 312);
            this.txtsglt.Name = "txtsglt";
            this.txtsglt.Size = new System.Drawing.Size(100, 20);
            this.txtsglt.TabIndex = 11;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(113, 174);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(100, 20);
            this.txtdienthoai.TabIndex = 10;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(113, 78);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(100, 20);
            this.txthoten.TabIndex = 9;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(113, 31);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 8;
            // 
            // lbpc
            // 
            this.lbpc.AutoSize = true;
            this.lbpc.Location = new System.Drawing.Point(23, 319);
            this.lbpc.Name = "lbpc";
            this.lbpc.Size = new System.Drawing.Size(46, 13);
            this.lbpc.TabIndex = 7;
            this.lbpc.Text = "phụ cấp";
            this.lbpc.Visible = false;
            // 
            // lbsglt
            // 
            this.lbsglt.AutoSize = true;
            this.lbsglt.Location = new System.Drawing.Point(21, 319);
            this.lbsglt.Name = "lbsglt";
            this.lbsglt.Size = new System.Drawing.Size(80, 13);
            this.lbsglt.TabIndex = 6;
            this.lbsglt.Text = "số giờ làm thêm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "loại pv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ngày vào làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "giới tính ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã nv";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.thongke);
            this.groupBox2.Controls.Add(this.sapxep);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.luu);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Location = new System.Drawing.Point(478, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tác vụ";
            // 
            // thongke
            // 
            this.thongke.Location = new System.Drawing.Point(36, 309);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(75, 23);
            this.thongke.TabIndex = 13;
            this.thongke.Text = "thống kê";
            this.thongke.UseVisualStyleBackColor = true;
            // 
            // sapxep
            // 
            this.sapxep.Location = new System.Drawing.Point(36, 245);
            this.sapxep.Name = "sapxep";
            this.sapxep.Size = new System.Drawing.Size(75, 23);
            this.sapxep.TabIndex = 12;
            this.sapxep.Text = "sắp xếp";
            this.sapxep.UseVisualStyleBackColor = true;
            this.sapxep.Click += new System.EventHandler(this.sapxep_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(36, 189);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 11;
            this.sua.Text = "sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(36, 131);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 10;
            this.xoa.Text = "xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(36, 80);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 9;
            this.luu.Text = "lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(36, 31);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 8;
            this.them.Text = "thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "danh sách phóng viên";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MANV,
            this.HOTEN,
            this.GIOITINH,
            this.DIENTHOAI,
            this.NVL,
            this.SGLT,
            this.PHUCAP});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MANV
            // 
            this.MANV.Text = "MÃ NV";
            // 
            // HOTEN
            // 
            this.HOTEN.Text = "HỌ TÊN";
            // 
            // GIOITINH
            // 
            this.GIOITINH.Text = "GIOITINH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.Text = "ĐIỆN THOẠI";
            // 
            // NVL
            // 
            this.NVL.Text = "NGÀY VÀO LÀM";
            // 
            // SGLT
            // 
            this.SGLT.Text = "SỐ GIỜ LÀM THÊM";
            // 
            // PHUCAP
            // 
            this.PHUCAP.Text = "PHỤ CẤP";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "chương trình quản lý phóng viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbpc;
        private System.Windows.Forms.Label lbsglt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker datenvl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtt;
        private System.Windows.Forms.RadioButton rbtts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.TextBox txtsglt;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.Button sapxep;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MANV;
        private System.Windows.Forms.ColumnHeader HOTEN;
        private System.Windows.Forms.ColumnHeader GIOITINH;
        private System.Windows.Forms.ColumnHeader DIENTHOAI;
        private System.Windows.Forms.ColumnHeader NVL;
        private System.Windows.Forms.ColumnHeader SGLT;
        private System.Windows.Forms.ColumnHeader PHUCAP;
        private System.Windows.Forms.Label label7;
    }
}

