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
    public partial class frm_QuanLyNamHoc : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public frm_QuanLyNamHoc()
        {
            InitializeComponent();
        }

        public void loadBang()
        {
            dgv_DanhSachNamHoc.DataSource = connectionDB.fillDataTable("SELECT * FROM NAMHOC");
        }

        private void frm_QuanLyNamHoc_Load(object sender, EventArgs e)
        {
            loadBang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO NAMHOC VALUES('" + txt_MaNamHoc.Text + "',N'" + txt_TenNamHoc.Text + "')";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            }
            loadBang();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DanhSachNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNamHoc.Text = dgv_DanhSachNamHoc.CurrentRow.Cells["MaNamHoc"].Value.ToString();
            txt_TenNamHoc.Text = dgv_DanhSachNamHoc.CurrentRow.Cells["TenNamHoc"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM NAMHOC WHERE MaNamHoc='" + txt_MaNamHoc.Text + "'";
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
            string sql = "UPDATE NAMHOC SET TenNamHoc=N'" + txt_TenNamHoc.Text + "' WHERE MaNamHoc ='" + txt_MaNamHoc.Text + "'";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            }
            loadBang();
        }
    }
}
