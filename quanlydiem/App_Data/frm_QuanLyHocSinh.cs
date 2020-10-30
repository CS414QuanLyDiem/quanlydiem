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

namespace quanlydiem.App_Data
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int temp = connectionDB.NonQueryCommand("INSERT INTO HOCSINH VALUES ('"+ txt_Mahs.Text+ "',N'"
                +txt_Hoten.Text+"','"
                +cb_Lop.SelectedValue +"',CONVERT(datetime,'"+dtp_NgaySinh.Text+"',103),N'"
                + gioiTinh+"',N'"
                +txt_DiaChi.Text+"')");
            NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            loadDataGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int temp = connectionDB.NonQueryCommand("UPDATE HOCSINH SET ( MaHS ='" + txt_Mahs.Text + "TenHS = ',N'"
                  + txt_Hoten.Text + "', MaLop = '"
                  + cb_Lop.SelectedValue + " NgaySinh = ',CONVERT(datetime,'" + dtp_NgaySinh.Text + "',103),GioiTinh = N'"
                  + gioiTinh + "',DiaChi = N'"
                  + txt_DiaChi.Text + "')");
            NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            loadDataGridView();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int temp = connectionDB.NonQueryCommand("DELET");
            NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            loadDataGridView();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (NotifiationUtils.NotificationClose() == DialogResult.Yes) {
                Close();
            }
        }

        private void frm_QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            loadComboboxLop();
            loadDataGridView();
        }

        private void loadComboboxLop() {
            cb_Lop.DataSource = connectionDB.fillDataTable("SELECT * FROM LOP");
            cb_Lop.DisplayMember = "TenLop";
            cb_Lop.ValueMember = "MaLop";
        }
        private void loadDataGridView() {
            dgv_DanhSachSinhVien.DataSource = connectionDB.fillDataTable("SELECT * FROM HOCSINH");
        }

        private void rdb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = rdb_Nam.Text;
        }

        private void rdb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = rdb_Nu.Text;
        }
    }
}
