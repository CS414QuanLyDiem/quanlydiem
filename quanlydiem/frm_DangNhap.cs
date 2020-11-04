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
    public partial class frm_DangNhap : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
         
            string caseSql1 = "SELECT COUNT(*) FROM TAIKHOAN WHERE TaiKhoan='" + txt_TaiKhoan.Text + "' AND MatKhau='" + txt_MatKhau.Text + "' AND MaPhanQuyen=1";
            string caseSql2 = "SELECT COUNT(*) FROM TAIKHOAN WHERE TaiKhoan='" + txt_TaiKhoan.Text + "' AND MatKhau='" + txt_MatKhau.Text + "' AND MaPhanQuyen=2";
            if(connectionDB.ScalaCommand<int>(caseSql1) > 0)
            {
                this.Hide();
                frm_Main frmMain = new frm_Main(txt_TaiKhoan.Text);
                frmMain.sm_GiaoVien.Enabled = false;
                frmMain.Show();
                frmMain.Text = "Quản lý điểm trường trung học phổ thông - ADMIN";
            }else if(connectionDB.ScalaCommand<int>(caseSql2) > 0)
            {
                this.Hide();
                frm_Main frmMain = new frm_Main(txt_TaiKhoan.Text);
                frmMain.sm_Admin.Enabled = false;
                frmMain.Show();
                frmMain.Text = "Quản lý điểm trường trung học phổ thông - GIAO VIEN";
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                txt_MatKhau.Text = "";
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
           
        }
    }
}
    