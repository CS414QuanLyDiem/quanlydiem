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
    public partial class frm_DoiMatKhau : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();
        string taiKhoan;
        public frm_DoiMatKhau(string taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE TAIKHOAN SET MatKhau='" + txt_MatKhauMoi.Text + "' WHERE TaiKhoan='"+taiKhoan+"' AND MatKhau='"+txt_MatKhauCu.Text+"'";
            if (txt_MatKhauMoi.Text.Equals(txt_NhapLaiMatKhauMoi.Text))
            {
                if (connectionDB.NonQueryCommand(sql) > 0)
                {
                    DialogResult dl = MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dl == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                }
              
            }else
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác");
            }
        }
    }
}
