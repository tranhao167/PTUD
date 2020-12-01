using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_ChamCong : DevExpress.XtraEditors.XtraForm
    {
        CongTrinhBLL congTrinhBLL;
        CongViecBLL congViecBLL;
        NhanVienBLL nhanVienBLL;
        public Form_ChamCong()
        {
            congTrinhBLL = new CongTrinhBLL();
            congViecBLL = new CongViecBLL();
            nhanVienBLL = new NhanVienBLL();
            InitializeComponent();
            dataGridView_DanhSachCongTrinh.DataSource = congTrinhBLL.getAllCongTrinh();
        }

        private void Form_ChamCong_Load(object sender, EventArgs e)
        {
            //DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            //dgvcCheckBox.HeaderText = "Chọn";

            //dataGridView_CongViecCuaNhanVien.Columns.Add(dgvcCheckBox);
        }

        private void dataGridView_DanhSachCongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_DanhSachCongViecCuaCongTrinh.Visible = true;
            dataGridView_DanhSachCongViecCuaCongTrinh.DataSource = congViecBLL.getCongViecByIdCongTrinh(dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
        }

        

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string tenNhanvien = dataGridView_CongViecCuaNhanVien.CurrentRow.Cells[1].Value.ToString();
            string idNV = nhanVienBLL.getTenNhanVienByID(tenNhanvien);
            try
            {

                bool kq = nhanVienBLL.chamCongNhanVienCoMat(idNV, dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
                if (kq)
                {
                    XtraMessageBox.Show("Chấm công Thành Công");

                }
                else XtraMessageBox.Show("Chấm công Thất Bại");
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show("Có lỗi xảy ra");
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnVang_Click(object sender, EventArgs e)
        {
            string tenNhanvien = dataGridView_CongViecCuaNhanVien.CurrentRow.Cells[1].Value.ToString();
            string idNV = nhanVienBLL.getTenNhanVienByID(tenNhanvien);
            try
            {

                bool kq = nhanVienBLL.chamCongNhanVienVang(idNV, dataGridView_DanhSachCongTrinh.CurrentRow.Cells[0].Value.ToString());
                if (kq)
                {
                    XtraMessageBox.Show("Chấm công Vắng Thành Công");

                }
                else XtraMessageBox.Show("Chấm công Vắng Thất Bại");
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show("Có lỗi xảy ra");
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView_DanhSachCongViecCuaCongTrinh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CongViecCuaNhanVien.DataSource = congViecBLL.getNhanvienbyIDcongviec(dataGridView_DanhSachCongViecCuaCongTrinh.CurrentRow.Cells[0].Value.ToString());

        }
    }
}