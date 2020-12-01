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
    public partial class Form_PhanCong : DevExpress.XtraEditors.XtraForm
    {

        PhongBanBLL pbBLL;
        NhanVienBLL nvBLL;
        CongViecBLL cvBLL;
        CongTrinhBLL ctBLL;

        public Form_PhanCong()
        {
            InitializeComponent();

            pbBLL = new PhongBanBLL();
            nvBLL = new NhanVienBLL();
            cvBLL = new CongViecBLL();
            ctBLL = new CongTrinhBLL();

            dataGridView_CongViecCuaNhanVien.AutoGenerateColumns = dataGridView_DanhSachCongTrinh.AutoGenerateColumns = dataGridView_DanhSachCongViecCuaCongTrinh.AutoGenerateColumns = dataGridView_NhanVienTrongPhongBan.AutoGenerateColumns = dataGridView_PhongBan.AutoGenerateColumns = false;

            dataGridView_PhongBan.DataSource = pbBLL.getAllPhongBan();
            dataGridView_DanhSachCongTrinh.DataSource = ctBLL.getAllCongTrinh();
           
        }

        private void reloadGridDanhSachPhongBan()
        {
            dataGridView_PhongBan.DataSource = null;
            dataGridView_PhongBan.DataSource = pbBLL.getAllPhongBan();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_NhanVienTrongPhongBan.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = null;
            if(nvBLL.getNhanVienByIdPhongBan(dataGridView_PhongBan.CurrentRow.Cells[0].Value.ToString()).Count() > 0)
            {
                dataGridView_NhanVienTrongPhongBan.DataSource = nvBLL.getNhanVienByIdPhongBan(dataGridView_PhongBan.CurrentRow.Cells[0].Value.ToString());
                if (cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString()).Count() > 0)
                {
                    dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
                }
            }
        }

        private void dataGridView_NhanVienTrongPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
        }

        private void Form_PhanCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_PhanCong = true;
        }

        private void Form_PhanCong_Load(object sender, EventArgs e)
        {
            if(pbBLL.getAllPhongBan().Count() > 0)
            {
               dataGridView_NhanVienTrongPhongBan.DataSource = nvBLL.getNhanVienByIdPhongBan(dataGridView_PhongBan.CurrentRow.Cells[0].Value.ToString());

                if(nvBLL.getNhanVienByIdPhongBan(dataGridView_PhongBan.CurrentRow.Cells[0].Value.ToString()).Count() > 0)
                {
                    dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
                }
            }

            if(ctBLL.getAllCongTrinh().Count() > 0)
            {
                dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void dataGridView_DanhSachCongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = null;
            dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnPhanCongViec_Click(object sender, EventArgs e)
        {
            string idNhanVien = dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString();
            string idCongTrinh = dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString();
            string idCongViec = dataGridView_DanhSachCongViecCuaCongTrinh.CurrentRow.Cells[0].Value.ToString();

            string tenNhanVien = dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[1].Value.ToString();

            bool kq = nvBLL.phanCongNhanVien(idNhanVien, idCongTrinh, idCongViec);

            if (kq)
            {
                dataGridView_CongViecCuaNhanVien.DataSource = null;
                dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
                XtraMessageBox.Show("Phân công thành công");
            }
            else
            {
                XtraMessageBox.Show("Nhân viên " + tenNhanVien + " đã được phân công vào công việc này !!!");

            }
        }

        private void btnXoaPhanCongCongViec_Click(object sender, EventArgs e)
        {
            bool kq = nvBLL.xoaPhanCongCongViec((int)dataGridView_CongViecCuaNhanVien.CurrentRow.Cells[3].Value);

            if (kq)
            {
                dataGridView_CongViecCuaNhanVien.DataSource = null;
                dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(dataGridView_NhanVienTrongPhongBan.CurrentRow.Cells[0].Value.ToString());
                XtraMessageBox.Show("Thao tác thành công");
            }
            else
            {
                XtraMessageBox.Show("Thao tác thất bại !!!");
            }
        }

        private void tbTimKiemNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tbTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            string idNV = "";
            foreach (DataGridViewRow row in dataGridView_NhanVienTrongPhongBan.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(tbTimKiemNhanVien.Text))
                {
                    row.Selected = true;
                    idNV =  row.Cells[0].Value.ToString();
                }
            }

            dataGridView_CongViecCuaNhanVien.DataSource = null;
            dataGridView_CongViecCuaNhanVien.DataSource = cvBLL.getCongViecByIdNhanVien(idNV);
        }

        private void dataGridView_NhanVienTrongPhongBan_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView_NhanVienTrongPhongBan_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

    
    }
}