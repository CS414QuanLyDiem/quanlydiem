namespace quanlydiem
{
    partial class frm_QuanLyTaiKhoan
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
            this.dgv_DanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.cb_Quyen = new System.Windows.Forms.ComboBox();
            this.cb_MaGiaoVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTaiKhoan)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachTaiKhoan
            // 
            this.dgv_DanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTaiKhoan.Location = new System.Drawing.Point(27, 192);
            this.dgv_DanhSachTaiKhoan.Name = "dgv_DanhSachTaiKhoan";
            this.dgv_DanhSachTaiKhoan.Size = new System.Drawing.Size(748, 240);
            this.dgv_DanhSachTaiKhoan.TabIndex = 0;
            this.dgv_DanhSachTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachTaiKhoan_CellClick);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txt_MatKhau);
            this.grbThongTin.Controls.Add(this.txt_TenDangNhap);
            this.grbThongTin.Controls.Add(this.cb_Quyen);
            this.grbThongTin.Controls.Add(this.cb_MaGiaoVien);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(27, 16);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Size = new System.Drawing.Size(748, 111);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin tài khoản";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(567, 69);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(146, 24);
            this.txt_MatKhau.TabIndex = 4;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(567, 27);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(146, 24);
            this.txt_TenDangNhap.TabIndex = 3;
            // 
            // cb_Quyen
            // 
            this.cb_Quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Quyen.FormattingEnabled = true;
            this.cb_Quyen.Location = new System.Drawing.Point(201, 68);
            this.cb_Quyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Quyen.Name = "cb_Quyen";
            this.cb_Quyen.Size = new System.Drawing.Size(169, 24);
            this.cb_Quyen.TabIndex = 2;
            // 
            // cb_MaGiaoVien
            // 
            this.cb_MaGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaGiaoVien.FormattingEnabled = true;
            this.cb_MaGiaoVien.Location = new System.Drawing.Point(201, 24);
            this.cb_MaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_MaGiaoVien.Name = "cb_MaGiaoVien";
            this.cb_MaGiaoVien.Size = new System.Drawing.Size(169, 24);
            this.cb_MaGiaoVien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(402, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(402, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giáo viên";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(242, 146);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_Xoa.TabIndex = 54;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(133, 146);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 33);
            this.btn_Sua.TabIndex = 53;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(31, 146);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 33);
            this.btn_Them.TabIndex = 52;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(358, 145);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 33);
            this.btn_Dong.TabIndex = 55;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dgv_DanhSachTaiKhoan);
            this.Name = "frm_QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTaiKhoan)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachTaiKhoan;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.ComboBox cb_Quyen;
        private System.Windows.Forms.ComboBox cb_MaGiaoVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Dong;
    }
}