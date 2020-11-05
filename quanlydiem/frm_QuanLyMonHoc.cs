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
    public partial class frm_QuanLyMonHoc : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public frm_QuanLyMonHoc()
        {
            InitializeComponent();
        }

        public void loadBang()
        {
            dgv_DanhSachMonHoc.DataSource = connectionDB.fillDataTable("SELECT * FROM MONHOC");
         
        }

        private void frm_QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            loadBang();
        }

        private void dgv_DanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMH.Text = dgv_DanhSachMonHoc.CurrentRow.Cells["MaMH"].Value.ToString();
            txt_TenMH.Text = dgv_DanhSachMonHoc.CurrentRow.Cells["TenMH"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO MONHOC VALUES ('"+txt_MaMH.Text+"',N'"+txt_TenMH.Text+"')";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            }
            loadBang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM MONHOC WHERE MaMH='" + txt_MaMH.Text + "'";
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
            string sql = "UPDATE MONHOC SET TenMH=N'" + txt_TenMH.Text + "' WHERE MaMH ='" + txt_MaMH.Text + "'";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            }
            loadBang();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
