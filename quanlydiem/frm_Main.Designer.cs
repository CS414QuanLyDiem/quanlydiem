﻿namespace quanlydiem
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_GiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_NhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_QuanLyHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timHocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timGiaoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_QuanLyGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_QuanLyNamHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_QuanLyKhoi = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_PhanCongGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_QuanLyMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuâtToolStripMenuItem,
            this.sm_GiaoVien,
            this.timKiêmToolStripMenuItem,
            this.sm_Admin,
            this.sm_TroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem1,
            this.thoatToolStripMenuItem});
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.đăngXuâtToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // đăngXuâtToolStripMenuItem1
            // 
            this.đăngXuâtToolStripMenuItem1.Name = "đăngXuâtToolStripMenuItem1";
            this.đăngXuâtToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.đăngXuâtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuâtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem1_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // sm_GiaoVien
            // 
            this.sm_GiaoVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_NhapDiem,
            this.sm_QuanLyHocSinh});
            this.sm_GiaoVien.Name = "sm_GiaoVien";
            this.sm_GiaoVien.Size = new System.Drawing.Size(68, 20);
            this.sm_GiaoVien.Text = "Giáo viên";
            // 
            // sm_NhapDiem
            // 
            this.sm_NhapDiem.Name = "sm_NhapDiem";
            this.sm_NhapDiem.Size = new System.Drawing.Size(180, 22);
            this.sm_NhapDiem.Text = "Nhập điểm";
            this.sm_NhapDiem.Click += new System.EventHandler(this.sm_NhapDiem_Click);
            // 
            // sm_QuanLyHocSinh
            // 
            this.sm_QuanLyHocSinh.Name = "sm_QuanLyHocSinh";
            this.sm_QuanLyHocSinh.Size = new System.Drawing.Size(180, 22);
            this.sm_QuanLyHocSinh.Text = "Quản lý học sinh";
            this.sm_QuanLyHocSinh.Click += new System.EventHandler(this.sm_QuanLyHocSinh_Click);
            // 
            // timKiêmToolStripMenuItem
            // 
            this.timKiêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timHocSinhToolStripMenuItem,
            this.timGiaoViênToolStripMenuItem});
            this.timKiêmToolStripMenuItem.Name = "timKiêmToolStripMenuItem";
            this.timKiêmToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.timKiêmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // timHocSinhToolStripMenuItem
            // 
            this.timHocSinhToolStripMenuItem.Name = "timHocSinhToolStripMenuItem";
            this.timHocSinhToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.timHocSinhToolStripMenuItem.Text = "Tìm học sinh";
            // 
            // timGiaoViênToolStripMenuItem
            // 
            this.timGiaoViênToolStripMenuItem.Name = "timGiaoViênToolStripMenuItem";
            this.timGiaoViênToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.timGiaoViênToolStripMenuItem.Text = "Tìm giáo viên";
            // 
            // sm_Admin
            // 
            this.sm_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_QuanLyGiaoVien,
            this.quanLyTaiKhoanToolStripMenuItem,
            this.sm_QuanLyNamHoc,
            this.sm_QuanLyKhoi,
            this.sm_PhanCongGiaoVien,
            this.sm_QuanLyMonHoc});
            this.sm_Admin.Name = "sm_Admin";
            this.sm_Admin.Size = new System.Drawing.Size(55, 20);
            this.sm_Admin.Text = "Admin";
            // 
            // sm_QuanLyGiaoVien
            // 
            this.sm_QuanLyGiaoVien.Name = "sm_QuanLyGiaoVien";
            this.sm_QuanLyGiaoVien.Size = new System.Drawing.Size(182, 22);
            this.sm_QuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.sm_QuanLyGiaoVien.Click += new System.EventHandler(this.sm_QuanLyGiaoVien_Click);
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quanLyTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.quanLyTaiKhoanToolStripMenuItem_Click);
            // 
            // sm_QuanLyNamHoc
            // 
            this.sm_QuanLyNamHoc.Name = "sm_QuanLyNamHoc";
            this.sm_QuanLyNamHoc.Size = new System.Drawing.Size(182, 22);
            this.sm_QuanLyNamHoc.Text = "Quản lý năm học";
            this.sm_QuanLyNamHoc.Click += new System.EventHandler(this.sm_QuanLyNamHoc_Click);
            // 
            // sm_QuanLyKhoi
            // 
            this.sm_QuanLyKhoi.Name = "sm_QuanLyKhoi";
            this.sm_QuanLyKhoi.Size = new System.Drawing.Size(182, 22);
            this.sm_QuanLyKhoi.Text = "Quản lý khối";
            this.sm_QuanLyKhoi.Click += new System.EventHandler(this.sm_QuanLyKhoi_Click);
            // 
            // sm_PhanCongGiaoVien
            // 
            this.sm_PhanCongGiaoVien.Name = "sm_PhanCongGiaoVien";
            this.sm_PhanCongGiaoVien.Size = new System.Drawing.Size(182, 22);
            this.sm_PhanCongGiaoVien.Text = "Phân công giáo viên";
            this.sm_PhanCongGiaoVien.Click += new System.EventHandler(this.sm_PhanCongGiaoVien_Click);
            // 
            // sm_QuanLyMonHoc
            // 
            this.sm_QuanLyMonHoc.Name = "sm_QuanLyMonHoc";
            this.sm_QuanLyMonHoc.Size = new System.Drawing.Size(182, 22);
            this.sm_QuanLyMonHoc.Text = "Quản lý môn học";
            this.sm_QuanLyMonHoc.Click += new System.EventHandler(this.sm_QuanLyMonHoc_Click);
            // 
            // sm_TroGiup
            // 
            this.sm_TroGiup.Name = "sm_TroGiup";
            this.sm_TroGiup.Size = new System.Drawing.Size(62, 20);
            this.sm_TroGiup.Text = "Trợ giúp";
            this.sm_TroGiup.Click += new System.EventHandler(this.sm_TroGiup_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm trường trung học phổ thông";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sm_GiaoVien;
        public System.Windows.Forms.ToolStripMenuItem sm_Admin;
        private System.Windows.Forms.ToolStripMenuItem sm_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem sm_NhapDiem;
        public System.Windows.Forms.ToolStripMenuItem sm_QuanLyHocSinh;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sm_QuanLyMonHoc;
        private System.Windows.Forms.ToolStripMenuItem sm_PhanCongGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem timKiêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timHocSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timGiaoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sm_QuanLyGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem sm_QuanLyNamHoc;
        private System.Windows.Forms.ToolStripMenuItem sm_QuanLyKhoi;
    }
}