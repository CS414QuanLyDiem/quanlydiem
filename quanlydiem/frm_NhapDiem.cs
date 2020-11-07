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
    public partial class frm_NhapDiem : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();
        string taiKhoan;
        public frm_NhapDiem(string taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
        }

        public void loadComboLop()
        {
            cb_Lop.DataSource = connectionDB.fillDataTable("SELECT * FROM LOP,TAIKHOAN WHERE LOP.MaGV=TAIKHOAN.MAGV AND TaiKhoan='" + taiKhoan + "'");
            cb_Lop.DisplayMember = "TenLop";
            cb_Lop.ValueMember = "MaLop";
        }

        public void loadBangDSHS()
        {
            string sql = "SELECT MaHS,TenHS FROM HOCSINH WHERE MaLop='" + cb_Lop.SelectedValue + "'";
            dgv_DanhSachHocSinh.DataSource = connectionDB.fillDataTable(sql);
        }

        public void loadComBoMonHoc()
        {
            cb_MonHoc.DataSource = connectionDB.fillDataTable("SELECT * FROM MONHOC");
            cb_MonHoc.DisplayMember = "TenMH";
            cb_MonHoc.ValueMember = "MaMH";
        }

        public void loadComBoHocKy()
        {
            cb_HocKy.DataSource = connectionDB.fillDataTable("SELECT * FROM HOCKY");
            cb_HocKy.DisplayMember = "TenHK";
            cb_HocKy.ValueMember = "MaHK";
        }

        public void loadBangDiem()
        {
            string sql = "SELECT DiemMieng,Diem15Phut,Diem1Tiet,DiemHK FROM BANGDIEM WHERE MaHK = '"+cb_HocKy.SelectedValue+"' AND MaHS ='"+ dgv_DanhSachHocSinh.CurrentRow.Cells["MaHS"].Value.ToString() + "' AND MaMH='"+cb_MonHoc.SelectedValue+"'";
            dgv_Diem.DataSource = connectionDB.fillDataTable(sql);
        }

        private void frm_NhapDiem_Load(object sender, EventArgs e)
        {
            loadComBoHocKy();
            loadComboLop();
            loadComBoMonHoc();
            loadBangDSHS();
        }

        private void dgv_DanhSachHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                loadBangDiem();
                txt_DiemMieng.Text = dgv_Diem.CurrentRow.Cells["DiemMieng"].Value.ToString();
                txt_Diem15Phut.Text = dgv_Diem.CurrentRow.Cells["Diem15Phut"].Value.ToString();
                txt_Diem1Tiet.Text = dgv_Diem.CurrentRow.Cells["Diem1Tiet"].Value.ToString();
                txt_DiemHK.Text = dgv_Diem.CurrentRow.Cells["DiemHK"].Value.ToString();
            }
            catch (System.NullReferenceException) { }
            
        }

        private void cb_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM HOCSINH WHERE MaLop='" + cb_Lop.SelectedValue + "'";
            dgv_DanhSachHocSinh.DataSource = connectionDB.fillDataTable(sql);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO BANGDIEM VALUES('" + dgv_DanhSachHocSinh.CurrentRow.Cells["MaHS"].Value.ToString() + "','" + cb_MonHoc.SelectedValue + "'," + txt_DiemMieng.Text + "," + txt_Diem15Phut.Text + "," + txt_Diem1Tiet.Text + "," + txt_DiemHK.Text + ",'" + cb_HocKy.SelectedValue + "')";
                int temp = connectionDB.NonQueryCommand(sql);
                NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
                loadBangDiem();
            }
            catch (NullReferenceException) { }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE BANGDIEM SET DiemMieng=" + txt_DiemMieng.Text + ",Diem15Phut=" + txt_Diem15Phut.Text + ",Diem1Tiet=" + txt_Diem1Tiet.Text + ",DiemHK=  " + txt_DiemHK.Text + " WHERE MaHK = '" + cb_HocKy.SelectedValue + "' AND MaHS ='" + dgv_DanhSachHocSinh.CurrentRow.Cells["MaHS"].Value.ToString() + "' AND MaMH='" + cb_MonHoc.SelectedValue + "' ";
                int temp = connectionDB.NonQueryCommand(sql);
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
                loadBangDiem();
            }
            catch (NullReferenceException) { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM BANGDIEM WHERE MaHK = '" + cb_HocKy.SelectedValue + "' AND MaHS ='" + dgv_DanhSachHocSinh.CurrentRow.Cells["MaHS"].Value.ToString() + "' AND MaMH='" + cb_MonHoc.SelectedValue + "'";
                int temp = connectionDB.NonQueryCommand(sql);
                NotifiationUtils.NotificationCRUD(temp, CRUD.XOA);
                loadBangDiem();
            }
            catch (NullReferenceException) { }
        }

        private void cb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadBangDiem();
            }
            catch (Exception)
            {

            }
        }

        private void cb_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadBangDiem();
                clearTextBox();
            }
            catch (Exception)
            {

            }
        }

        public void clearTextBox()
        {
            txt_DiemMieng.Text = "";
            txt_Diem15Phut.Text = "";
            txt_Diem1Tiet.Text = "";
            txt_DiemHK.Text = "";
        }

    }
}
