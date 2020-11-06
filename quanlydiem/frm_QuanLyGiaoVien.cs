using quanlydiem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiem
{
    public partial class btn_NhapAnh : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\IMAGE\\";
        private string gioiTinh = "";

        public btn_NhapAnh()
        {
            InitializeComponent();
        }

        public void loadBang()
        {
            string sql = "select * from GIAOVIEN";
            dgv_DanhSachGiaoVien.DataSource = connectionDB.fillDataTable(sql);
        }

        private void frm_QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            loadBang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO GIAOVIEN VALUES (N'"+txt_MaGV.Text+"',N'"+txt_HoTen.Text+"',CONVERT(datetime,'"+dtp_NgaySinh.Text+"',103),N'"+gioiTinh+"','"+txt_SoDienThoai.Text+"',N'"+txt_DiaChi.Text+"',N'"+txt_HinhAnh.Text+"')";
            int temp = connectionDB.NonQueryCommand(sql);
            try
            {
                pb_HinhAnh.Image.Save(duongdan + txt_HinhAnh.Text);
            }
            catch (System.Runtime.InteropServices.ExternalException) { }
            NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            loadBang();
        }

        private void rb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = rb_Nam.Text;
        }

        private void rb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = rb_Nu.Text;
        }

        private void btn_HinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn hình cho giáo viên";
            open.Filter = "Ảnh dạng JPG|*.JPG|Ảnh dạng PNG|*.PNG|Tất cả|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pb_HinhAnh.Image = Image.FromFile(open.FileName);
            }
        }

        private void dgv_DanhSachGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGV.Text = dgv_DanhSachGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
            txt_HoTen.Text = dgv_DanhSachGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString();
            dtp_NgaySinh.Text = dgv_DanhSachGiaoVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dgv_DanhSachGiaoVien.CurrentRow.Cells["GioiTinh"].Value.ToString().Equals("Nam"))
            {
                rb_Nam.Checked = true;
                rb_Nu.Checked = false;
            }
            else
            {
                rb_Nam.Checked = false;
                rb_Nu.Checked = true;
            }
            txt_SoDienThoai.Text = dgv_DanhSachGiaoVien.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txt_DiaChi.Text = dgv_DanhSachGiaoVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_HinhAnh.Text = dgv_DanhSachGiaoVien.CurrentRow.Cells["HinhAnh"].Value.ToString();
            pb_HinhAnh.ImageLocation = duongdan + dgv_DanhSachGiaoVien.CurrentRow.Cells["HinhAnh"].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE GIAOVIEN SET TenGV=N'" + txt_HoTen.Text + "',NgaySinh=CONVERT(datetime,'" + dtp_NgaySinh.Text + "',103),GioiTinh=N'" + gioiTinh + "',SoDienThoai='" + txt_SoDienThoai.Text + "',DiaChi=N'" + txt_DiaChi.Text + "',HinhAnh=N'" + txt_HinhAnh.Text + "' WHERE MaGV='"+txt_MaGV.Text+"'";
            int temp = connectionDB.NonQueryCommand(sql);
            try
            {
                pb_HinhAnh.Image.Save(duongdan + txt_HinhAnh.Text);
            }catch (System.Runtime.InteropServices.ExternalException)
            {
            }
            NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            loadBang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql1 = "DELETE FROM TAIKHOAN WHERE MaGV='" + txt_MaGV.Text + "'";
            string sql2 = "DELETE FROM GIAOVIEN WHERE MaGV='" + txt_MaGV.Text + "'";
            DialogResult dl = MessageBox.Show("Bạn thật sự có xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dl == DialogResult.Yes)
            {
                int temp1 = connectionDB.NonQueryCommand(sql1);
                int temp2 = connectionDB.NonQueryCommand(sql2);
                if (temp1 > 0)
                {
                    if (temp2 > 0)
                    {
                        File.Delete(duongdan + txt_HinhAnh.Text);
                        NotifiationUtils.NotificationCRUD(temp2, CRUD.XOA);
                    }
                }
            }
            loadBang();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
