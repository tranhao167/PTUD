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
using Entities;

namespace UI
{
    public partial class Form_ThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        public static string tenTK = null;
        public string idPB;
        ThongtincanhanBLL ThongtincanhanBLL;
        NhanVienBLL nhanVienBLL;
        PhongBanBLL PhongBanBLL;

        public Form_ThongTinCaNhan()
        {
            ThongtincanhanBLL = new ThongtincanhanBLL();
            PhongBanBLL = new PhongBanBLL();
            nhanVienBLL = new NhanVienBLL();
            InitializeComponent();
            var listData = ThongtincanhanBLL.getthongtinNhanVien(tenTK);
            foreach(var item in listData)
            {
                tbMaNV.Text = item.idNhanVien;
                tbTenNV.Text = item.tenNhanVien;
                tbDiaChi.Text = item.diaChi;
                tbSDT.Text = item.sdt;
                txtChucVu.Text = item.chucVu==0?"Nhân Viên":"Quản Lý";
                txtPhongBan.Text = PhongBanBLL.getTenPhongBan(item.idPhongBan);
                idPB = item.idPhongBan;
            }

        }
        private void loadTextbox()
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_ThongTinCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_ThongTinCaNhan = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Hủy")
            {
                btnLuu.Enabled = false;
                tbTenNV.Enabled=tbDiaChi.Enabled=tbSDT.Enabled = false;
                btnSua.Text = "Sửa";
            }
            else
            {
                btnLuu.Enabled = true;
                btnSua.Text = "Hủy";
                tbTenNV.Enabled = tbDiaChi.Enabled = tbSDT.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbTenNV.Text == "" || tbDiaChi.Text == "" || tbSDT.Text == "")
            {
                MessageBox.Show("Xin Nhập Đầy đủ thông tin");
            }
            else
            {
                try
                {
                    int chucVu;
                    if (txtChucVu.Text == "Nhân Viên")
                    {
                        chucVu = 1;
                    }
                    else chucVu = 0;
                    eNhanVien a = new eNhanVien(tbMaNV.Text,tbTenNV.Text, tbDiaChi.Text, tbSDT.Text,chucVu,idPB,false);
                    bool kq = nhanVienBLL.capnhatNhanVien(a);

                    if (kq)
                    {
                        XtraMessageBox.Show("Cập nhật Thông tin cá nhân thành công");
                        tbTenNV.Enabled = tbDiaChi.Enabled = tbSDT.Enabled = false;
                        btnLuu.Enabled = false;
                        btnSua.Text="Sửa";
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật Nhân Viên thất bại !!!");
                    }
                }
                catch
                {

                }
            }
        }
    }
}