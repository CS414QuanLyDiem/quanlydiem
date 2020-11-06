namespace quanlydiem
{
    partial class frm_QuanLyKhoi
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
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txt_TenKhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaKhoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachKhoi = new System.Windows.Forms.DataGridView();
            this.grbThongTin.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(359, 138);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(84, 41);
            this.btn_Dong.TabIndex = 39;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(248, 138);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 41);
            this.btn_Sua.TabIndex = 38;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(22, 138);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 41);
            this.btn_Them.TabIndex = 36;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(137, 138);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 41);
            this.btn_Xoa.TabIndex = 37;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txt_TenKhoi);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.txt_MaKhoi);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(22, 11);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Size = new System.Drawing.Size(421, 111);
            this.grbThongTin.TabIndex = 33;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin khối";
            // 
            // txt_TenKhoi
            // 
            this.txt_TenKhoi.Location = new System.Drawing.Point(173, 72);
            this.txt_TenKhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenKhoi.Name = "txt_TenKhoi";
            this.txt_TenKhoi.Size = new System.Drawing.Size(146, 24);
            this.txt_TenKhoi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khối";
            // 
            // txt_MaKhoi
            // 
            this.txt_MaKhoi.Location = new System.Drawing.Point(173, 27);
            this.txt_MaKhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKhoi.Name = "txt_MaKhoi";
            this.txt_MaKhoi.Size = new System.Drawing.Size(146, 24);
            this.txt_MaKhoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khối";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgv_DanhSachKhoi);
            this.grbDanhSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSach.Location = new System.Drawing.Point(22, 198);
            this.grbDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDanhSach.Size = new System.Drawing.Size(421, 299);
            this.grbDanhSach.TabIndex = 35;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách khối";
            // 
            // dgv_DanhSachKhoi
            // 
            this.dgv_DanhSachKhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachKhoi.Location = new System.Drawing.Point(3, 19);
            this.dgv_DanhSachKhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DanhSachKhoi.Name = "dgv_DanhSachKhoi";
            this.dgv_DanhSachKhoi.ReadOnly = true;
            this.dgv_DanhSachKhoi.RowTemplate.Height = 24;
            this.dgv_DanhSachKhoi.Size = new System.Drawing.Size(415, 278);
            this.dgv_DanhSachKhoi.TabIndex = 99;
            this.dgv_DanhSachKhoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKhoi_CellClick);
            // 
            // frm_QuanLyKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 507);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbDanhSach);
            this.Name = "frm_QuanLyKhoi";
            this.Text = "Quản lý khối";
            this.Load += new System.EventHandler(this.frm_QuanLyKhoi_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txt_TenKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaKhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhoi;
    }
}