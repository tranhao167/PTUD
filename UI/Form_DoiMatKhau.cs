using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace UI
{
    public partial class Form_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public static string tenTK = null;

        TaiKhoanBLL taiKhoanBLL;
        public Form_DoiMatKhau()
        {
            taiKhoanBLL = new TaiKhoanBLL();
            InitializeComponent();
        }

        private void Form_DoiMatKhau_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void Form_DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_DoiMatKhau = true;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                bool kq = taiKhoanBLL.DoiMatKhau(tenTK,tbMatKhauCu.Text, tbMatKhauMoi.Text, tbNhapLaiMK.Text);
                if (kq)
                {
                    XtraMessageBox.Show("Đổi mật khẩu thành công");
                    tbMatKhauCu.ResetText();
                    tbMatKhauMoi.ResetText();
                    tbNhapLaiMK.ResetText();
                }
                else
                {
                    XtraMessageBox.Show("Đổi mật khẩu thất bại");
                }
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }
    }
}