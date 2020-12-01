using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace UI
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static bool statusLogin = false;

        public static bool f_QLCongTrinh = true;
        public static bool f_DangNhap = true;
        public static bool f_QLCongViec = true;
        public static bool f_PhanCong = true;

        //Hao
        public static bool f_QLNhanVien = true;
        public static bool f_DoiMatKhau = true;
        public static bool f_ThongTinCaNhan = true;
        public static bool f_ChamCong = true;


        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }


        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ThongTinCaNhan form = new Form_ThongTinCaNhan();

            if (f_ThongTinCaNhan == true)
            {
                form.MdiParent = this;
                form.Show();
                f_ThongTinCaNhan = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_ThongTinCaNhan)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_QuanLyCongTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QLCongTrinh form = new Form_QLCongTrinh();

            if(f_QLCongTrinh == true)
            {
                form.MdiParent = this;
                form.Show();
                f_QLCongTrinh = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_QLCongTrinh)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btn_QuanLyDanhMuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QLCongViec form = new Form_QLCongViec();

            if (f_QLCongViec == true)
            {
                form.MdiParent = this;
                form.Show();
                f_QLCongViec = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_QLCongViec)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            //this.Close();
            Form_DangNhap form = new Form_DangNhap();
            form.Show();
            Visible = false;
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_DoiMatKhau form = new Form_DoiMatKhau();

            if (f_DoiMatKhau == true)
            {
                form.MdiParent = this;
                form.Show();
                f_DoiMatKhau = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_DoiMatKhau)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void btnPhanCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_PhanCong form = new Form_PhanCong();

            if (f_PhanCong == true)
            {
                form.MdiParent = this;
                form.Show();
                f_PhanCong = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_PhanCong)
                    {
                        item.Activate();
                    }
                }
            }
        }

        private void ribbonControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_QuanLyKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QLNhanVien form = new Form_QLNhanVien();
            if (f_QLNhanVien == true)
            {
                form.MdiParent = this;
                form.Show();
                f_QLNhanVien = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_QLNhanVien)
                    {
                        item.Activate();
                    }
                }
            }

        }

        private void btnChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ChamCong form = new Form_ChamCong();
            if (f_ChamCong == true)
            {
                form.MdiParent = this;
                form.Show();
                f_ChamCong = false;
            }
            else
            {
                foreach (XtraForm item in this.MdiChildren)
                {
                    if (item is Form_ChamCong)
                    {
                        item.Activate();
                    }
                }
            }
        }
    }
}