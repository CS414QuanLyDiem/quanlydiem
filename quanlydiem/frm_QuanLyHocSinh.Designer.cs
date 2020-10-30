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
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.btn_dong = new System.Windows.Forms.Button();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_Mahs = new System.Windows.Forms.TextBox();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_Lop = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_Mahs = new System.Windows.Forms.Label();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(80, 364);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.Size = new System.Drawing.Size(656, 150);
            this.dgv_DanhSach.TabIndex = 55;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(631, 315);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 53;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(156, 178);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgaySinh.TabIndex = 52;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(397, 315);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 51;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(245, 315);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 50;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(103, 315);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(576, 31);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(160, 139);
            this.txt_DiaChi.TabIndex = 48;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(156, 84);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(121, 20);
            this.txt_Hoten.TabIndex = 46;
            // 
            // txt_Mahs
            // 
            this.txt_Mahs.Location = new System.Drawing.Point(156, 32);
            this.txt_Mahs.Name = "txt_Mahs";
            this.txt_Mahs.Size = new System.Drawing.Size(121, 20);
            this.txt_Mahs.TabIndex = 45;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(66, 184);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lb_NgaySinh.TabIndex = 44;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(499, 34);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(41, 13);
            this.lb_DiaChi.TabIndex = 43;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Location = new System.Drawing.Point(66, 128);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(25, 13);
            this.lb_Lop.TabIndex = 42;
            this.lb_Lop.Text = "Lớp";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(66, 84);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(43, 13);
            this.lb_HoTen.TabIndex = 41;
            this.lb_HoTen.Text = "Họ Tên";
            // 
            // lb_Mahs
            // 
            this.lb_Mahs.AutoSize = true;
            this.lb_Mahs.Location = new System.Drawing.Point(67, 35);
            this.lb_Mahs.Name = "lb_Mahs";
            this.lb_Mahs.Size = new System.Drawing.Size(70, 13);
            this.lb_Mahs.TabIndex = 40;
            this.lb_Mahs.Text = "Mã Sinh Viên";
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Checked = true;
            this.rb_Nam.Location = new System.Drawing.Point(156, 225);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(47, 17);
            this.rb_Nam.TabIndex = 56;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            this.rb_Nam.CheckedChanged += new System.EventHandler(this.rb_Nam_CheckedChanged);
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Location = new System.Drawing.Point(156, 265);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rb_Nu.TabIndex = 57;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            this.rb_Nu.CheckedChanged += new System.EventHandler(this.rb_Nu_CheckedChanged);
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Location = new System.Drawing.Point(69, 240);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lb_GioiTinh.TabIndex = 58;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(156, 128);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(121, 21);
            this.cb_Lop.TabIndex = 59;
            // 
            // frm_QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.cb_Lop);
            this.Controls.Add(this.lb_GioiTinh);
            this.Controls.Add(this.rb_Nu);
            this.Controls.Add(this.rb_Nam);
            this.Controls.Add(this.dgv_DanhSach);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.txt_Mahs);
            this.Controls.Add(this.lb_NgaySinh);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_Lop);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_Mahs);
            this.Name = "frm_QuanLyHocSinh";
            this.Text = "frm_QuanLyHocSinh";
            this.Load += new System.EventHandler(this.frm_QuanLyHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_Mahs;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_Lop;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_Mahs;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.ComboBox cb_Lop;
    }
}