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
    public partial class frm_PhanCongGiaoVien : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public frm_PhanCongGiaoVien()
        {
            InitializeComponent();
        }

        public void loadComBoMaGV()
        {
            cb_MaGiaoVien.DataSource = connectionDB.fillDataTable("SELECT * FROM GIAOVIEN");
            cb_MaGiaoVien.DisplayMember = "MaGV";
            cb_MaGiaoVien.ValueMember = "MaGV";
        }

        public void loadComboKhoi()
        {
            cb_Khoi.DataSource = connectionDB.fillDataTable("SELECT * FROM KHOILOP");
            cb_Khoi.DisplayMember = "TenKhoi";
            cb_Khoi.ValueMember = "MaKhoi";
        }

        public void loadComBoNamHoc()
        {
            cb_NamHoc.DataSource = connectionDB.fillDataTable("SELECT * FROM NAMHOC");
            cb_NamHoc.DisplayMember = "TenNamHoc";
            cb_NamHoc.ValueMember = "MaNamHoc";
        }

        public void loadBang()
        {
            dgv_DanhSachPhanCong.DataSource = connectionDB.fillDataTable("SELECT * FROM LOP");
        }

        private void frm_PhanCongGiaoVien_Load(object sender, EventArgs e)
        {
            loadComBoMaGV();
            loadComboKhoi();
            loadComBoNamHoc();
            loadBang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO LOP VALUES ('"+txt_MaLop.Text+"',N'"+txt_TenLop.Text+"','"+cb_MaGiaoVien.SelectedValue+"','"+cb_Khoi.SelectedValue+"','"+cb_NamHoc.SelectedValue+"')";
            int temp = connectionDB.NonQueryCommand(sql);
            if(temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            }
            loadBang();
        }

        private void dgv_DanhSachPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_Khoi.SelectedValue = dgv_DanhSachPhanCong.CurrentRow.Cells["MaKhoi"].Value.ToString();
            cb_MaGiaoVien.SelectedValue = dgv_DanhSachPhanCong.CurrentRow.Cells["MaGV"].Value.ToString();
            cb_NamHoc.SelectedValue = dgv_DanhSachPhanCong.CurrentRow.Cells["MaNamHoc"].Value.ToString();
            txt_MaLop.Text = dgv_DanhSachPhanCong.CurrentRow.Cells["MaLop"].Value.ToString();
            txt_TenLop.Text = dgv_DanhSachPhanCong.CurrentRow.Cells["TenLop"].Value.ToString();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE LOP SET TenLop=N'" + txt_TenLop.Text + "',MaGV='" + cb_MaGiaoVien.SelectedValue + "',MaKhoi='" + cb_Khoi.SelectedValue + "',MaNamHoc='" + cb_NamHoc.SelectedValue + "' WHERE MaLop='"+txt_MaLop.Text+"'";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            }
            loadBang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Lop WHERE MaLop='" + txt_MaLop.Text+ "'";
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
    }
}
