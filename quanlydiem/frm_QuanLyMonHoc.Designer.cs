namespace quanlydiem
{
    partial class frm_QuanLyMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txt_MaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.txt_TenMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(371, 141);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(84, 41);
            this.btn_Dong.TabIndex = 32;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(260, 141);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 41);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(34, 141);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 41);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(149, 141);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 41);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txt_TenMH);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.txt_MaMH);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(34, 45);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Size = new System.Drawing.Size(675, 80);
            this.grbThongTin.TabIndex = 26;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin môn học";
            // 
            // txt_MaMH
            // 
            this.txt_MaMH.Location = new System.Drawing.Point(173, 27);
            this.txt_MaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaMH.Name = "txt_MaMH";
            this.txt_MaMH.Size = new System.Drawing.Size(146, 24);
            this.txt_MaMH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgv_DanhSachMonHoc);
            this.grbDanhSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSach.Location = new System.Drawing.Point(34, 201);
            this.grbDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDanhSach.Size = new System.Drawing.Size(675, 285);
            this.grbDanhSach.TabIndex = 28;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách môn học";
            // 
            // dgv_DanhSachMonHoc
            // 
            this.dgv_DanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachMonHoc.Location = new System.Drawing.Point(3, 19);
            this.dgv_DanhSachMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DanhSachMonHoc.Name = "dgv_DanhSachMonHoc";
            this.dgv_DanhSachMonHoc.ReadOnly = true;
            this.dgv_DanhSachMonHoc.RowTemplate.Height = 24;
            this.dgv_DanhSachMonHoc.Size = new System.Drawing.Size(669, 264);
            this.dgv_DanhSachMonHoc.TabIndex = 99;
            this.dgv_DanhSachMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMonHoc_CellClick);
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Location = new System.Drawing.Point(470, 27);
            this.txt_TenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Size = new System.Drawing.Size(146, 24);
            this.txt_TenMH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(349, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn học";
            // 
            // frm_QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 501);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbDanhSach);
            this.Name = "frm_QuanLyMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.frm_QuanLyMonHoc_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txt_MaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgv_DanhSachMonHoc;
        private System.Windows.Forms.TextBox txt_TenMH;
        private System.Windows.Forms.Label label3;
    }
}