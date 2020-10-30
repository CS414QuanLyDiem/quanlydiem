using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiem
{
    static class NotifiationUtilsCRUD
    {
        public static void NotificationCRUD(int temp, String CRUD)
        {
            if (temp > 0) {
                MessageBox.Show("" + CRUD + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("" + CRUD + " Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // check yes/no
        public static DialogResult NotificationClose() {
            DialogResult dialogResult =
                  MessageBox.Show("Bạn thật sự có muốn thoát hay không ?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult;
        }
    }

    public static class CRUD
    {
        public static string THEM = "Thêm";
        public static string SUA = "Sửa";
        public static string XOA = "Xóa";
    }
}
