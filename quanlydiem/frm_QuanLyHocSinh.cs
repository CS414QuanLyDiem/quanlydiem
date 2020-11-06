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
    public partial class frm_QuanLyHocSinh : Form
    {
        private ConnectionDB connectionDB;
        private string gioiTinh="";
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\IMAGE\\";

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
                +txt_DiaChi.Text+"',N'"+txt_HinhAnh.Text+"')";
            int temp = connectionDB.NonQueryCommand(sql);
            NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            loadDataGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE HOCSINH SET TenHS = N'"+txt_Hoten.Text
                +"',MaLop = '"+cb_Lop.SelectedValue
                + "',NgaySinh = CONVERT(datetime,'" + dtp_NgaySinh.Text + "',103)," +
                "GioiTinh = N'"+gioiTinh
                +"' ,DiaChi = N'"+ txt_DiaChi.Text + "',HinhAnh=N'"+txt_HinhAnh.Text+"' WHERE MaHS = '"+txt_Mahs.Text+"'";
            int temp = connectionDB.NonQueryCommand(sql);
            if(temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
                try
                {
                    pb_HinhAnh.Image.Save(duongdan + txt_HinhAnh.Text);
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                }
            }
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
            if (dgv_DanhSach.CurrentRow.Cells["GioiTinh"].Value.ToString().Equals("Nam"))
            {
                rb_Nam.Checked = true;
                rb_Nu.Checked = false;
            }
            else
            {
                rb_Nam.Checked = false;
                rb_Nu.Checked = true;
            }
            txt_DiaChi.Text = dgv_DanhSach.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_HinhAnh.Text = dgv_DanhSach.CurrentRow.Cells["HinhAnh"].Value.ToString();
            pb_HinhAnh.ImageLocation = duongdan + dgv_DanhSach.CurrentRow.Cells["HinhAnh"].Value.ToString();
        }

        private void btn_NhapAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn hình cho hoc sinh";
            open.Filter = "Ảnh dạng JPG|*.JPG|Ảnh dạng PNG|*.PNG|Tất cả|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_HinhAnh.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
