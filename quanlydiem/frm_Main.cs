using quanlydiem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiem
{
    public partial class frm_Main : Form
    {
        string taiKhoan;

        public frm_Main(string taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool kiemTraForm(String nameForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(nameForm))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void đăngXuâtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (!kiemTraForm("frm_DangNhap"))
                {
                    this.Hide();
                    frm_DangNhap frmDangNhap = new frm_DangNhap();
                    frmDangNhap.Show();
                }
            }
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DoiMatKhau"] == null)
            {
                frm_DoiMatKhau frmDoiMatKhau = new frm_DoiMatKhau(taiKhoan);
                frmDoiMatKhau.MdiParent = this;
                frmDoiMatKhau.Show();
            }
            else
            {
                Application.OpenForms["frm_DoiMatKhau"].Activate();
            }
        }

        private void sm_QuanLyHocSinh_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyHocSinh"] == null) {
                frm_QuanLyHocSinh fQuanLyHocSinh= new frm_QuanLyHocSinh();
                fQuanLyHocSinh.MdiParent = this;
                fQuanLyHocSinh.Show();
            }
            else {
                Application.OpenForms["frm_QuanLyHocSinh"].Activate();
            }
        }

        private void trơGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TroGiup"] == null)
            {
                frm_TroGiup frmTroGiup = new frm_TroGiup();
                frmTroGiup.MdiParent = this;
                frmTroGiup.Show();
            }
            else
            {
                Application.OpenForms["frm_TroGiup"].Activate();
            }
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyTaiKhoan"] == null)
            {
                frm_QuanLyTaiKhoan frmQuanLyTaiKhoan = new frm_QuanLyTaiKhoan();
                frmQuanLyTaiKhoan.MdiParent = this;
                frmQuanLyTaiKhoan.Show();
            }
            else
            {
                Application.OpenForms["frm_QuanLyTaiKhoan"].Activate();
            }
        }

        private void sm_TroGiup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TroGiup"] == null)
            {
                frm_TroGiup frmTroGiup = new frm_TroGiup();
                frmTroGiup.MdiParent = this;
                frmTroGiup.Show();
            }
            else
            {
                Application.OpenForms["frm_TroGiup"].Activate();
            }
        }

        private void sm_QuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyGiaoVien"] == null)
            {
                btn_NhapAnh frmQuanLyGiaoVien = new btn_NhapAnh();
                frmQuanLyGiaoVien.MdiParent = this;
                frmQuanLyGiaoVien.Show();
            }
            else
            {
                Application.OpenForms["frm_QuanLyGiaoVien"].Activate();
            }
        }

        private void sm_QuanLyMonHoc_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyMonHoc"] == null)
            {
                frm_QuanLyMonHoc frmQLMH = new frm_QuanLyMonHoc();
                frmQLMH.MdiParent = this;
                frmQLMH.Show();
            }
            else
            {
                Application.OpenForms["frm_QuanLyMonHoc"].Activate();
            }
        }

        private void sm_PhanCongGiaoVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_PhanCongGiaoVien"] == null)
            {
                frm_PhanCongGiaoVien frmPCGV = new frm_PhanCongGiaoVien();
                frmPCGV.MdiParent = this;
                frmPCGV.Show();
            }
            else
            {
                Application.OpenForms["frm_PhanCongGiaoVien"].Activate();
            }
        }
    }
}
