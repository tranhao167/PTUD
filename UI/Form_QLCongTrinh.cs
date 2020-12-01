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
    public partial class Form_QLCongTrinh : DevExpress.XtraEditors.XtraForm
    {
        CongTrinhBLL ctBLL;
        CongViecBLL cvBLL;
        public Form_QLCongTrinh()
        {
            InitializeComponent();
            ctBLL = new CongTrinhBLL();
            cvBLL = new CongViecBLL();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            dataGridView1.DataSource = ctBLL.getAllCongTrinh();
            dataGridView2.DataSource = cvBLL.getCongViecByIdCongTrinh(ctBLL.getIdCongTrinhFirst());
        }

        private int trangThaiLuu = -1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_QLCongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_QLCongTrinh = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form_QLCongTrinh_Load(object sender, EventArgs e)
        {
            loadDataCellCongTrinh();
        }

        private void enableOptions(bool e)
        {
            tbTenCongTrinh.Enabled = tbDiaChi.Enabled = dateNgayHoanThanh.Enabled = dateNgayBatDau.Enabled = dateNgayKetThuc.Enabled = comboBoxTrangThai.Enabled = e;
        }

        private void clearAll()
        {
            tbTenCongTrinh.Text = tbDiaChi.Text ="";
            dateNgayHoanThanh.Value = new DateTime(1900, 1, 1);
            comboBoxTrangThai.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(trangThaiLuu == -1)
            {
                trangThaiLuu = 0;
                btnThem.Text = "Hủy";
                enableOptions(true);
                dateNgayHoanThanh.Enabled = false;
                comboBoxTrangThai.Enabled = false;
                btnLuu.Enabled = true;
                btnCapNhat.Enabled = btnXoa.Enabled = false;
                clearAll();
            }
            else
            {
                trangThaiLuu = -1;
                btnThem.Text = "Thêm mới";
                enableOptions(false);
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = btnXoa.Enabled = true;
                loadDataCellCongTrinh();
            }

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(trangThaiLuu == 0) // Thêm
            {
                eCongTrinh a = new eCongTrinh(tbTenCongTrinh.Text, tbDiaChi.Text, (DateTime)dateNgayBatDau.Value, (DateTime)dateNgayKetThuc.Value);
                bool kq = ctBLL.themCongTrinh(a);

                if (kq)
                {
                    XtraMessageBox.Show("Thêm công trình thành công");

                }
                else
                {
                    XtraMessageBox.Show("Thêm công trình thất bại !!!");
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ctBLL.getAllCongTrinh();
                loadDataCellCongTrinh();
                btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                btnLuu.Enabled = false;
                enableOptions(false);
                trangThaiLuu = -1;
                btnThem.Text = "Thêm mới";
            }
            else //Cập nhật
            {
                eCongTrinh a = new eCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString(), tbTenCongTrinh.Text, tbDiaChi.Text, (DateTime)dateNgayBatDau.Value, (DateTime)dateNgayKetThuc.Value, (DateTime)dateNgayHoanThanh.Value, comboBoxTrangThai.Text);
                bool kq = ctBLL.capNhatCongTrinh(a);

                if (kq)
                {
                    XtraMessageBox.Show("Cập nhật công trình thành công");

                }
                else
                {
                    XtraMessageBox.Show("Cập nhật công trình thất bại !!!");
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ctBLL.getAllCongTrinh();
                loadDataCellCongTrinh();
                btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                btnLuu.Enabled = false;
                enableOptions(false);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            trangThaiLuu = 1;
            btnCapNhat.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            enableOptions(true);

        }

        private void loadDataCellCongTrinh()
        {
            if(dataGridView1.DataSource != null)
            {
                loadDataCongViec(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                tbTenCongTrinh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateNgayBatDau.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
                dateNgayKetThuc.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                dateNgayHoanThanh.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
                if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Đang Thực Hiện")
                {
                    comboBoxTrangThai.SelectedIndex = 0;
                }
                else
                {
                    if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Hoàn Thành")
                    {
                        comboBoxTrangThai.SelectedIndex = 1;
                    }
                    else
                    {
                        comboBoxTrangThai.SelectedIndex = 2;
                    }
                }
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataCellCongTrinh();
            btnXoa.Enabled = btnCapNhat.Enabled = btnThem.Enabled = true;
            enableOptions(false);
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Bạn có muốn xóa công trình này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                bool kq = ctBLL.xoaCongTrinh(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                if (kq)
                {
                    XtraMessageBox.Show("Xóa công trình thành công");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ctBLL.getAllCongTrinh();
                    loadDataCellCongTrinh();
                }
                else
                {
                    XtraMessageBox.Show("Xóa công trình thất bại !!");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ctBLL.getAllCongTrinh();
                    loadDataCellCongTrinh();
                }
            }
            else
            {
                dialog = DialogResult.Cancel;
               
            }
        }
    }
}