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
    public partial class Form_QLCongViec : DevExpress.XtraEditors.XtraForm
    {
        CongViecBLL cvBLL;
        CongTrinhBLL ctBLL;

        private int trangThaiLuu = -1;
        public Form_QLCongViec()
        {
            InitializeComponent();
            cvBLL = new CongViecBLL();
            ctBLL = new CongTrinhBLL();

            dataGridView1.AutoGenerateColumns = dataGridView2.AutoGenerateColumns = dataGridView3.AutoGenerateColumns = false;

            dataGridView3.DataSource = cvBLL.getAllCongViec();
            dataGridView1.DataSource = ctBLL.getAllCongTrinh();
            dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(ctBLL.getIdCongTrinhFirst());

        }

        private void loadDataDetailCongViec()
        {
            tbTenCongViec.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_QLCongViec_Load(object sender, EventArgs e)
        {
            loadDataDetailCongViec();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataDetailCongViec();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataCellCongTrinh();
        }

        private void loadDataCellCongTrinh()
        {
            if (dataGridView1.DataSource != null)
            {
                loadDataCongViec(dataGridView1.CurrentRow.Cells[0].Value.ToString());          
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu cho Công Trình");
            }
        }

        private void loadDataCongViec(string idCongTrinh)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(idCongTrinh);
        }

        private void btnThemCVCongTrinh_Click(object sender, EventArgs e)
        {
            string tenCongViecThem = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            string tenCongTrinhDuocThem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bool kq = cvBLL.themCongViecVaoCongTrinh(dataGridView3.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());

            if (kq)
            {
                XtraMessageBox.Show("Thêm công việc " + tenCongViecThem + " vào công trình " + tenCongTrinhDuocThem + " thành công");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                XtraMessageBox.Show("Đã tồn tại công việc này trong dự án !!!");
            }
        }

        private void btnXoaCVCongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Bạn có muốn xóa công việc này ra khỏi dự án ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog == DialogResult.Yes)
            {
                bool kq = cvBLL.xoaCongViecKhoiCongTrinh(dataGridView2.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());

                if (kq)
                {
                    XtraMessageBox.Show("Thao tác thành công");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
                else
                {
                    XtraMessageBox.Show("Thao tác thất bại !!!");
                }
            }
            else
            {
                dialog = DialogResult.Cancel;
            }

          
        }

        private void Form_QLCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_QLCongViec = true;
        }

        private void clearAll()
        {
            tbTenCongViec.Text = "";
        }

        private void enableOptions(bool e)
        {
            tbTenCongViec.Enabled = e;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (trangThaiLuu == -1)
            {
                trangThaiLuu = 0;
                btnThem.Text = "Hủy";
                enableOptions(true);
                btnLuu.Enabled = true;
                btnCapNhat.Enabled = btnXoa.Enabled = btnThemCVCongTrinh.Enabled = btnXoaCVCongTrinh.Enabled = false;
                clearAll();
            }
            else
            {
                trangThaiLuu = -1;
                btnThem.Text = "Thêm mới";
                enableOptions(false);
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = btnXoa.Enabled = btnThemCVCongTrinh.Enabled = btnXoaCVCongTrinh.Enabled = true;
                loadDataDetailCongViec();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Bạn có muốn xóa công việc này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bool kq = cvBLL.xoaCongViec(dataGridView3.CurrentRow.Cells[0].Value.ToString());

                if (kq)
                {
                    XtraMessageBox.Show("Xóa công việc thành công");
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = cvBLL.getAllCongViec();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    loadDataDetailCongViec();
                }
                else
                {
                    XtraMessageBox.Show("Xóa công việc thất bại !!");
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = cvBLL.getAllCongViec();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    loadDataDetailCongViec();
                }
            }
            else
            {
                dialog = DialogResult.Cancel;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangThaiLuu == 0) // Thêm
            {
                eCongViec a = new eCongViec(tbTenCongViec.Text);
                bool kq = cvBLL.themCongViec(a);

                if (kq)
                {
                    XtraMessageBox.Show("Thêm công việc thành công");

                }
                else
                {
                    XtraMessageBox.Show("Thêm công việc thất bại !!!");
                }

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = cvBLL.getAllCongViec();
                loadDataDetailCongViec();
                btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = btnThemCVCongTrinh.Enabled = btnXoaCVCongTrinh.Enabled = true;
                btnLuu.Enabled = false;
                enableOptions(false);
                trangThaiLuu = -1;
                btnThem.Text = "Thêm mới";
            }
            else //Cập nhật
            {
                eCongViec a = new eCongViec(dataGridView3.CurrentRow.Cells[0].Value.ToString(), tbTenCongViec.Text);
                bool kq = cvBLL.capNhatCongViec(a);

                if (kq)
                {
                    XtraMessageBox.Show("Cập nhật công việc thành công");

                }
                else
                {
                    XtraMessageBox.Show("Cập nhật công việc thất bại !!!");
                }

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = cvBLL.getAllCongViec();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                loadDataDetailCongViec();
                btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = btnThemCVCongTrinh.Enabled = btnXoaCVCongTrinh.Enabled = true;
                btnLuu.Enabled = false;
                enableOptions(false);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            trangThaiLuu = 1;
            btnCapNhat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnThemCVCongTrinh.Enabled = btnXoaCVCongTrinh.Enabled = false;
            btnLuu.Enabled = true;
            enableOptions(true);
        }
    }
}