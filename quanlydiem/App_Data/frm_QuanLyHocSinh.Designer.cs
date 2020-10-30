namespace quanlydiem.App_Data
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
            this.dgv_DanhSachSinhVien = new System.Windows.Forms.DataGridView();
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
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachSinhVien
            // 
            this.dgv_DanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSinhVien.Location = new System.Drawing.Point(76, 386);
            this.dgv_DanhSachSinhVien.Name = "dgv_DanhSachSinhVien";
            this.dgv_DanhSachSinhVien.Size = new System.Drawing.Size(656, 150);
            this.dgv_DanhSachSinhVien.TabIndex = 55;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(532, 324);
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
            this.dtp_NgaySinh.Location = new System.Drawing.Point(162, 179);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgaySinh.TabIndex = 52;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(381, 324);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 51;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(235, 324);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 50;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(98, 324);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(543, 29);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(160, 120);
            this.txt_DiaChi.TabIndex = 48;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(162, 76);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(121, 20);
            this.txt_Hoten.TabIndex = 46;
            // 
            // txt_Mahs
            // 
            this.txt_Mahs.Location = new System.Drawing.Point(162, 29);
            this.txt_Mahs.Name = "txt_Mahs";
            this.txt_Mahs.Size = new System.Drawing.Size(121, 20);
            this.txt_Mahs.TabIndex = 45;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(72, 185);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lb_NgaySinh.TabIndex = 44;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(481, 29);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(41, 13);
            this.lb_DiaChi.TabIndex = 43;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Location = new System.Drawing.Point(73, 131);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(25, 13);
            this.lb_Lop.TabIndex = 42;
            this.lb_Lop.Text = "Lớp";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(72, 79);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(43, 13);
            this.lb_HoTen.TabIndex = 41;
            this.lb_HoTen.Text = "Họ Tên";
            // 
            // lb_Mahs
            // 
            this.lb_Mahs.AutoSize = true;
            this.lb_Mahs.Location = new System.Drawing.Point(73, 32);
            this.lb_Mahs.Name = "lb_Mahs";
            this.lb_Mahs.Size = new System.Drawing.Size(69, 13);
            this.lb_Mahs.TabIndex = 40;
            this.lb_Mahs.Text = "Mã Học Sinh";
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(162, 128);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(121, 21);
            this.cb_Lop.TabIndex = 56;
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Location = new System.Drawing.Point(76, 241);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lb_GioiTinh.TabIndex = 57;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Location = new System.Drawing.Point(162, 227);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(50, 17);
            this.rdb_Nam.TabIndex = 58;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = " Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            this.rdb_Nam.CheckedChanged += new System.EventHandler(this.rdb_Nam_CheckedChanged);
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Location = new System.Drawing.Point(162, 261);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rdb_Nu.TabIndex = 59;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            this.rdb_Nu.CheckedChanged += new System.EventHandler(this.rdb_Nu_CheckedChanged);
            // 
            // frm_QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 565);
            this.Controls.Add(this.rdb_Nu);
            this.Controls.Add(this.rdb_Nam);
            this.Controls.Add(this.lb_GioiTinh);
            this.Controls.Add(this.cb_Lop);
            this.Controls.Add(this.dgv_DanhSachSinhVien);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhSachSinhVien;
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
        private System.Windows.Forms.ComboBox cb_Lop;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
    }
}