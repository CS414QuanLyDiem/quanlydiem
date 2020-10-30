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
    public partial class frm_QuanLyHocSinh : Form
    {
        private ConnectionDB connectionDB;
        private String gioiTinh;

        public frm_QuanLyHocSinh()
        {
            InitializeComponent();
            connectionDB = new ConnectionDB();
        }

        private void frm_QuanLyHocSinh_Load(object sender, EventArgs e){
            loadComboboxLop();
            loadDataGridView();
        }

        private void loadComboboxLop() {
            cb_Lop.DataSource = connectionDB.fillDataTable("SELECT * FROM LOP");
            cb_Lop.DisplayMember = "TenLop";
            cb_Lop.ValueMember = "MaLop";
            
        }

        private void loadDataGridView(){
            dgv_DanhSach.DataSource = connectionDB.fillDataTable("SELECT * FROM HOCSINH");
        }

        private void btn_Them_Click(object sender, EventArgs e){
            String sql = "INSERT INTO HOCSINH VALUES ('"+txt_Mahs.Text+"',N'"
                +txt_Hoten.Text+"','"
                +cb_Lop.SelectedValue + "',CONVERT(datetime,'"+ dtp_NgaySinh.Text+ "',103),N'"
                + gioiTinh + "',N'"
                +txt_DiaChi.Text+"')";
            int temp = connectionDB.NonQueryCommand(sql);
            NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            loadDataGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE HOCSINH SET TenHS = N'"+txt_Hoten.Text
                +"',MaLop = '"+txt_Mahs.Text
                + "',NgaySinh = CONVERT(datetime,'" + dtp_NgaySinh.Text + "',103)," +
                "GioiTinh = N'"+gioiTinh
                +"' ,DiaChi = N'"+ txt_DiaChi.Text + "' WHERE MaHS = '"+txt_Mahs.Text+"'";
            int temp = connectionDB.NonQueryCommand(sql);
            NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            loadDataGridView();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sql = "DELETE FROM HOCSINH WHERE MaHS =  '"+txt_Mahs.Text+"' " ;
            int temp = connectionDB.NonQueryCommand(sql);
            NotifiationUtils.NotificationCRUD(temp, CRUD.XOA);
            loadDataGridView();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (NotifiationUtils.NotificationClose() == DialogResult.Yes) {
                Close();
            }
        }

        private void rb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = rb_Nam.Text;
        }

        private void rb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = rb_Nu.Text;
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Mahs.Text = dgv_DanhSach.CurrentRow.Cells["MaHS"].Value.ToString();
            txt_Hoten.Text = dgv_DanhSach.CurrentRow.Cells["TenHS"].Value.ToString();
            cb_Lop.SelectedValue = dgv_DanhSach.CurrentRow.Cells["MaLop"].Value.ToString();
            dtp_NgaySinh.Text = dgv_DanhSach.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dgv_DanhSach.CurrentRow.Cells["GioiTinh"].Value.ToString().Equals(rb_Nam.Text)) {
                rb_Nam.Select();
            }
            else {
                rb_Nu.Select();
            }
            txt_DiaChi.Text = dgv_DanhSach.CurrentRow.Cells["DiaChi"].Value.ToString();
        }
    }
}
