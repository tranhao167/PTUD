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
using Entities;
using BLL;

namespace UI
{
    public partial class Form_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        AuthBLL authBLL;
        public Form_DangNhap()
        {
            InitializeComponent();
            authBLL = new AuthBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int ketqua = authBLL.XuLyDangNhap(tbTaiKhoan.Text, tbMatKhau.Text);

            if(ketqua == 0)
            {
                XtraMessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                if(ketqua == 1)
                {
                    XtraMessageBox.Show("Mật khẩu không chính xác");
                }
                else
                {
                    //XtraMessageBox.Show("Đăng nhập thành công");
                    this.Close();
                    Form_Main.statusLogin = true;
                    Form_ThongTinCaNhan.tenTK = tbTaiKhoan.Text;
                    Form_DoiMatKhau.tenTK = tbTaiKhoan.Text;

                }
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void Form_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form_DangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ketqua = authBLL.XuLyDangNhap(tbTaiKhoan.Text, tbMatKhau.Text);

                if (ketqua == 0)
                {
                    XtraMessageBox.Show("Tài khoản không tồn tại");
                }
                else
                {
                    if (ketqua == 1)
                    {
                        XtraMessageBox.Show("Mật khẩu không chính xác");
                    }
                    else
                    {
                        //XtraMessageBox.Show("Đăng nhập thành công");
                        this.Close();
                        Form_Main.statusLogin = true;
                        Form_ThongTinCaNhan.tenTK = tbTaiKhoan.Text;
                        Form_DoiMatKhau.tenTK = tbTaiKhoan.Text;
                    }
                }
            }
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ketqua = authBLL.XuLyDangNhap(tbTaiKhoan.Text, tbMatKhau.Text);

                if (ketqua == 0)
                {
                    XtraMessageBox.Show("Tài khoản không tồn tại");
                }
                else
                {
                    if (ketqua == 1)
                    {
                        XtraMessageBox.Show("Mật khẩu không chính xác");
                    }
                    else
                    {
                        //XtraMessageBox.Show("Đăng nhập thành công");
                        this.Close();
                        Form_Main.statusLogin = true;
                        Form_ThongTinCaNhan.tenTK = tbTaiKhoan.Text;
                        Form_DoiMatKhau.tenTK = tbTaiKhoan.Text;
                    }
                }
            }
        }
    }
}