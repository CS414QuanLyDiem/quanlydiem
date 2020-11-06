namespace quanlydiem
{
    partial class frm_QuanLyHocSinh
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
            if (disposing && (components != null)) {
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
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_Mahs = new System.Windows.Forms.TextBox();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_Lop = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.btn_NhapAnh = new System.Windows.Forms.Button();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TenGiaoVien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhAnh)).BeginInit();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dong.Location = new System.Drawing.Point(312, 624);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 37);
            this.btn_dong.TabIndex = 53;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Location = new System.Drawing.Point(218, 624);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 37);
            this.btn_Xoa.TabIndex = 51;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.Location = new System.Drawing.Point(122, 624);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 37);
            this.btn_Sua.TabIndex = 50;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Them.Location = new System.Drawing.Point(29, 624);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 37);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NhapAnh);
            this.groupBox1.Controls.Add(this.pb_HinhAnh);
            this.groupBox1.Controls.Add(this.txt_HinhAnh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_GioiTinh);
            this.groupBox1.Controls.Add(this.rb_Nu);
            this.groupBox1.Controls.Add(this.rb_Nam);
            this.groupBox1.Controls.Add(this.dtp_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_Hoten);
            this.groupBox1.Controls.Add(this.txt_Mahs);
            this.groupBox1.Controls.Add(this.lb_NgaySinh);
            this.groupBox1.Controls.Add(this.lb_DiaChi);
            this.groupBox1.Controls.Add(this.lb_HoTen);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(26, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 463);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(447, 37);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(166, 21);
            this.cb_Lop.TabIndex = 72;
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lb_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lb_GioiTinh.Location = new System.Drawing.Point(21, 169);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(67, 17);
            this.lb_GioiTinh.TabIndex = 71;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rb_Nu.ForeColor = System.Drawing.Color.Black;
            this.rb_Nu.Location = new System.Drawing.Point(121, 179);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(47, 21);
            this.rb_Nu.TabIndex = 70;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            this.rb_Nu.CheckedChanged += new System.EventHandler(this.rb_Nu_CheckedChanged);
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Checked = true;
            this.rb_Nam.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rb_Nam.ForeColor = System.Drawing.Color.Black;
            this.rb_Nam.Location = new System.Drawing.Point(121, 156);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(58, 21);
            this.rb_Nam.TabIndex = 69;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            this.rb_Nam.CheckedChanged += new System.EventHandler(this.rb_Nam_CheckedChanged);
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(120, 111);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(166, 24);
            this.dtp_NgaySinh.TabIndex = 68;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(119, 214);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(167, 51);
            this.txt_DiaChi.TabIndex = 67;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(120, 71);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(166, 24);
            this.txt_Hoten.TabIndex = 66;
            // 
            // txt_Mahs
            // 
            this.txt_Mahs.Location = new System.Drawing.Point(120, 24);
            this.txt_Mahs.Name = "txt_Mahs";
            this.txt_Mahs.Size = new System.Drawing.Size(166, 24);
            this.txt_Mahs.TabIndex = 65;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lb_NgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lb_NgaySinh.Location = new System.Drawing.Point(21, 117);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(78, 17);
            this.lb_NgaySinh.TabIndex = 64;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lb_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.lb_DiaChi.Location = new System.Drawing.Point(21, 214);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(56, 17);
            this.lb_DiaChi.TabIndex = 63;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Lop.ForeColor = System.Drawing.Color.Black;
            this.lb_Lop.Location = new System.Drawing.Point(407, 38);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(34, 17);
            this.lb_Lop.TabIndex = 62;
            this.lb_Lop.Text = "Lớp";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.lb_HoTen.Location = new System.Drawing.Point(21, 74);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(58, 17);
            this.lb_HoTen.TabIndex = 61;
            this.lb_HoTen.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã học sinh";
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Location = new System.Drawing.Point(119, 283);
            this.txt_HinhAnh.Multiline = true;
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(167, 22);
            this.txt_HinhAnh.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Hình Ảnh";
            // 
            // pb_HinhAnh
            // 
            this.pb_HinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_HinhAnh.Location = new System.Drawing.Point(24, 325);
            this.pb_HinhAnh.Name = "pb_HinhAnh";
            this.pb_HinhAnh.Size = new System.Drawing.Size(155, 115);
            this.pb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_HinhAnh.TabIndex = 76;
            this.pb_HinhAnh.TabStop = false;
            // 
            // btn_NhapAnh
            // 
            this.btn_NhapAnh.ForeColor = System.Drawing.Color.Black;
            this.btn_NhapAnh.Location = new System.Drawing.Point(195, 403);
            this.btn_NhapAnh.Name = "btn_NhapAnh";
            this.btn_NhapAnh.Size = new System.Drawing.Size(90, 37);
            this.btn_NhapAnh.TabIndex = 73;
            this.btn_NhapAnh.Text = "Nhập ảnh";
            this.btn_NhapAnh.UseVisualStyleBackColor = true;
            this.btn_NhapAnh.Click += new System.EventHandler(this.btn_NhapAnh_Click);
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgv_DanhSach);
            this.grbDanhSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSach.Location = new System.Drawing.Point(401, 71);
            this.grbDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDanhSach.Size = new System.Drawing.Size(756, 602);
            this.grbDanhSach.TabIndex = 73;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách học sinh";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 19);
            this.dgv_DanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(750, 581);
            this.dgv_DanhSach.TabIndex = 99;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_TenGiaoVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(26, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(361, 99);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = " Giáo viên:";
            // 
            // lb_TenGiaoVien
            // 
            this.lb_TenGiaoVien.AutoSize = true;
            this.lb_TenGiaoVien.ForeColor = System.Drawing.Color.BlueViolet;
            this.lb_TenGiaoVien.Location = new System.Drawing.Point(86, 45);
            this.lb_TenGiaoVien.Name = "lb_TenGiaoVien";
            this.lb_TenGiaoVien.Size = new System.Drawing.Size(0, 17);
            this.lb_TenGiaoVien.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(739, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 101;
            this.label4.Text = "QUẢN LÝ HỌC SINH";
            // 
            // frm_QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cb_Lop);
            this.Controls.Add(this.lb_Lop);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Name = "frm_QuanLyHocSinh";
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.frm_QuanLyHocSinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhAnh)).EndInit();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Lop;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_Mahs;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_Lop;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HinhAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NhapAnh;
        private System.Windows.Forms.PictureBox pb_HinhAnh;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TenGiaoVien;
        private System.Windows.Forms.Label label4;
    }
}