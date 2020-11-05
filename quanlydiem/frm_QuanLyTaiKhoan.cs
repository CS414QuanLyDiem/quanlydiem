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
    public partial class frm_QuanLyTaiKhoan : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public frm_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadComBoMaGV()
        {
            cb_MaGiaoVien.DataSource = connectionDB.fillDataTable("SELECT * FROM GIAOVIEN");
            cb_MaGiaoVien.DisplayMember = "MaGV";
            cb_MaGiaoVien.ValueMember = "MaGV";
        }

        public void loadComBoQuyen()
        {
            cb_Quyen.DataSource = connectionDB.fillDataTable("SELECT * FROM PHANQUYEN");
            cb_Quyen.DisplayMember = "TenPhanQuyen";
            cb_Quyen.ValueMember = "MaPhanQuyen";
        }

        public void loadBang()
        {
            dgv_DanhSachTaiKhoan.DataSource = connectionDB.fillDataTable("SELECT * FROM TAIKHOAN");
        }

        private void frm_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadComBoMaGV();
            loadComBoQuyen();
            loadBang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO TAIKHOAN VALUES ('"+txt_TenDangNhap.Text+"','"+txt_MatKhau.Text+"','"+cb_Quyen.SelectedValue+"','"+cb_MaGiaoVien.SelectedValue + "')";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            }
            loadBang();
        }

        private void dgv_DanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaGiaoVien.SelectedValue = dgv_DanhSachTaiKhoan.CurrentRow.Cells["MaGV"].Value.ToString();
            try
            {
                cb_Quyen.SelectedValue = dgv_DanhSachTaiKhoan.CurrentRow.Cells["MaPhanQuyen"].Value.ToString();
            }catch(System.FormatException){ }
            txt_TenDangNhap.Text = dgv_DanhSachTaiKhoan.CurrentRow.Cells["TaiKhoan"].Value.ToString();
            txt_MatKhau.Text = dgv_DanhSachTaiKhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TAIKHOAN WHERE MaGV='" + cb_MaGiaoVien.SelectedValue + "'";
            DialogResult dl = MessageBox.Show("Bạn thật sự có xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                int temp = connectionDB.NonQueryCommand(sql);
                if (temp > 0)
                {
                        NotifiationUtils.NotificationCRUD(temp, CRUD.XOA);
                }
            }
            loadBang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE TAIKHOAN SET MaPhanQuyen="+cb_Quyen.SelectedValue+" WHERE MaGV='"+cb_MaGiaoVien.SelectedValue+"'";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            }
            loadBang();
        }
    }
}
