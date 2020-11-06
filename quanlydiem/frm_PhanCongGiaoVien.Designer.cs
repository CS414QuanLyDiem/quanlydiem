namespace quanlydiem
{
    partial class frm_PhanCongGiaoVien
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
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.cb_Khoi = new System.Windows.Forms.ComboBox();
            this.cb_MaGiaoVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhanCong = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_NamHoc = new System.Windows.Forms.ComboBox();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cb_NamHoc);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.txt_TenLop);
            this.grbThongTin.Controls.Add(this.txt_MaLop);
            this.grbThongTin.Controls.Add(this.cb_Khoi);
            this.grbThongTin.Controls.Add(this.cb_MaGiaoVien);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(26, 32);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Size = new System.Drawing.Size(590, 152);
            this.grbThongTin.TabIndex = 57;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin phân công";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(422, 65);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.PasswordChar = '*';
            this.txt_TenLop.Size = new System.Drawing.Size(146, 24);
            this.txt_TenLop.TabIndex = 4;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(422, 23);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(146, 24);
            this.txt_MaLop.TabIndex = 3;
            // 
            // cb_Khoi
            // 
            this.cb_Khoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Khoi.FormattingEnabled = true;
            this.cb_Khoi.Location = new System.Drawing.Point(164, 67);
            this.cb_Khoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Khoi.Name = "cb_Khoi";
            this.cb_Khoi.Size = new System.Drawing.Size(169, 24);
            this.cb_Khoi.TabIndex = 2;
            // 
            // cb_MaGiaoVien
            // 
            this.cb_MaGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaGiaoVien.FormattingEnabled = true;
            this.cb_MaGiaoVien.Location = new System.Drawing.Point(164, 23);
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
            this.label5.Location = new System.Drawing.Point(51, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khối";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(354, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(354, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giáo viên";
            // 
            // dgv_DanhSachPhanCong
            // 
            this.dgv_DanhSachPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhanCong.Location = new System.Drawing.Point(26, 241);
            this.dgv_DanhSachPhanCong.Name = "dgv_DanhSachPhanCong";
            this.dgv_DanhSachPhanCong.Size = new System.Drawing.Size(590, 240);
            this.dgv_DanhSachPhanCong.TabIndex = 56;
            this.dgv_DanhSachPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachPhanCong_CellClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(357, 194);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 33);
            this.btn_Dong.TabIndex = 61;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(241, 195);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_Xoa.TabIndex = 60;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(132, 195);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 33);
            this.btn_Sua.TabIndex = 59;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(30, 195);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 33);
            this.btn_Them.TabIndex = 58;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Năm học";
            // 
            // cb_NamHoc
            // 
            this.cb_NamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NamHoc.FormattingEnabled = true;
            this.cb_NamHoc.Location = new System.Drawing.Point(164, 106);
            this.cb_NamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_NamHoc.Name = "cb_NamHoc";
            this.cb_NamHoc.Size = new System.Drawing.Size(169, 24);
            this.cb_NamHoc.TabIndex = 6;
            // 
            // frm_PhanCongGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 499);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dgv_DanhSachPhanCong);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Name = "frm_PhanCongGiaoVien";
            this.Text = "Phân công giáo viên";
            this.Load += new System.EventHandler(this.frm_PhanCongGiaoVien_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhanCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.ComboBox cb_Khoi;
        private System.Windows.Forms.ComboBox cb_MaGiaoVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhanCong;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cb_NamHoc;
    }
}