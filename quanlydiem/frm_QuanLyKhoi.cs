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
    public partial class frm_QuanLyKhoi : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public frm_QuanLyKhoi()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO KHOILOP VALUES('"+txt_MaKhoi.Text+"',N'"+txt_TenKhoi.Text+"')";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.THEM);
            }
            loadBang();
        }

        public void loadBang()
        {
            dgv_DanhSachKhoi.DataSource = connectionDB.fillDataTable("SELECT * FROM KHOILOP");
        }

        private void frm_QuanLyKhoi_Load(object sender, EventArgs e)
        {
            loadBang();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM KHOILOP WHERE MaKhoi='" + txt_MaKhoi.Text + "'";
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

        private void dgv_DanhSachKhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhoi.Text = dgv_DanhSachKhoi.CurrentRow.Cells["MaKhoi"].Value.ToString();
            txt_TenKhoi.Text = dgv_DanhSachKhoi.CurrentRow.Cells["TenKhoi"].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE KHOILOP SET TenKhoi=N'" + txt_TenKhoi.Text + "' WHERE MaKhoi ='" + txt_MaKhoi.Text + "'";
            int temp = connectionDB.NonQueryCommand(sql);
            if (temp > 0)
            {
                NotifiationUtils.NotificationCRUD(temp, CRUD.SUA);
            }
            loadBang();
        }
    }
}
