using BLL;
using DevExpress.XtraEditors;
using Entities;
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
    public partial class Form_QLNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public int trangthai = 0;
        NhanVienBLL nhanVienBLL;
        PhongBanBLL PhongBanBLL;
        public Form_QLNhanVien()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
            PhongBanBLL = new PhongBanBLL();
            dataGridView1.AutoGenerateColumns = false;
            comboBox1.Items.Add("Nhân Viên");
            comboBox1.Items.Add("Quản Lý");
            dataGridView1.DataSource = nhanVienBLL.getAllNhanVien();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Hủy Thêm Mới")
            {
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
                btnLuu.Enabled = false;
                txtNV.Enabled = false;
                txtDiaChi.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                txtSDT.Enabled = false;
                btnThem.Text = "Thêm Mới";

            }
            else
            {
                trangthai = 0;
                comboBox2.DataSource = PhongBanBLL.getAllPhongBan();
                comboBox2.DisplayMember = "tenPhongBan";
                comboBox2.ValueMember = "idPhongBan";
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
                btnLuu.Enabled = true;
                txtNV.Enabled = true;
                txtDiaChi.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                txtSDT.Enabled = true;
                txtNV.ResetText();
                txtDiaChi.ResetText();
                txtSDT.ResetText();
                comboBox1.ResetText();
                comboBox2.ResetText();
                btnThem.Text = "Hủy Thêm Mới";
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            trangthai = 1;
            if (btnCapNhat.Text == "Hủy Cập nhật")
            {
                txtNV.Enabled = false;
                txtDiaChi.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                txtSDT.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnCapNhat.Text = "Cập nhật";
            }
            else
            {
                //int row = dataGridView1.CurrentCell.RowIndex;
                //comboBox2.Text = nhanVienBLL.gettenPhongBan(dataGridView1.Rows[row].Cells[5].Value.ToString());
                comboBox2.DataSource = PhongBanBLL.getAllPhongBan();
                comboBox2.DisplayMember = "tenPhongBan";
                comboBox2.ValueMember = "idPhongBan";
                txtNV.Enabled = true;
                txtDiaChi.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                txtSDT.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnCapNhat.Text = "Hủy Cập nhật";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.DataSource == null)
                return;
            int row = dataGridView1.CurrentCell.RowIndex;
            object idnv = dataGridView1.Rows[row].Cells[0].Value;
            if (idnv == null)
            {
                return;
            }
            string IDNV = idnv.ToString();
            txtNV.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            comboBox2.Text = nhanVienBLL.gettenPhongBan(dataGridView1.Rows[row].Cells[5].Value.ToString());
            if (dataGridView1.Rows[row].Cells[3].Value.ToString() == "1")
            {
                comboBox1.Text = "Nhân Viên";
            }
            else { comboBox1.Text = "Quản Lý"; }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            var kq= nhanVienBLL.timdsnhanvientheophongban(txtTim.Text);
            if (kq != null)
            {
                dataGridView1.DataSource = kq;
            }
            else XtraMessageBox.Show("Không Tìm Thấy");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                try
                {
                    if (txtNV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
                    {
                        MessageBox.Show("Xin Nhập Đầy đủ thông tin");
                    }
                    else
                    {
                        int chucVu;
                        if (comboBox1.Text == "Nhân Viên")
                        {
                            chucVu = 1;
                        }
                        else chucVu = 0;
                        eNhanVien a = new eNhanVien(txtNV.Text, txtDiaChi.Text, txtSDT.Text, chucVu, comboBox2.SelectedValue.ToString());
                        bool kq = nhanVienBLL.themNhanVien(a);

                        if (kq)
                        {
                            XtraMessageBox.Show("Thêm Nhân Viên thành công");
                            btnXoa.Enabled = true;
                            btnCapNhat.Enabled = true;
                            btnLuu.Enabled = false;
                            txtNV.Enabled = false;
                            txtDiaChi.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                            txtSDT.Enabled = false;
                            btnThem.Text = "Thêm Mới";
                            dataGridView1.DataSource = nhanVienBLL.getAllNhanVien();
                            btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                            btnLuu.Enabled = false;
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm Nhân Viên thất bại !!!");
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                if (txtNV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Xin Nhập Đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        if (dataGridView1.DataSource == null)
                            return;
                        int row = dataGridView1.CurrentCell.RowIndex;
                        object idnv = dataGridView1.Rows[row].Cells[0].Value;
                        if (idnv == null)
                        {
                            return;
                        }
                        string IDNV = idnv.ToString();
                        int chucVu;
                        if (comboBox1.Text == "Nhân Viên")
                        {
                            chucVu = 1;
                        }
                        else chucVu = 0;
                        eNhanVien a = new eNhanVien(IDNV, txtNV.Text, txtDiaChi.Text, txtSDT.Text, chucVu, comboBox2.SelectedValue.ToString(), false);
                        bool kq = nhanVienBLL.capnhatNhanVien(a);
                        if (kq)
                        {
                            XtraMessageBox.Show("Cập nhật Nhân Viên thành công");
                            btnXoa.Enabled = true;
                            btnCapNhat.Enabled = true;
                            btnLuu.Enabled = false;
                            txtNV.Enabled = false;
                            txtDiaChi.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                            txtSDT.Enabled = false;
                            btnCapNhat.Text = "Cập nhật";
                            dataGridView1.DataSource = nhanVienBLL.getAllNhanVien();
                            btnCapNhat.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                            btnLuu.Enabled = false;
                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật Nhân Viên thất bại !!!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            object idnv = dataGridView1.Rows[row].Cells[0].Value;
            if (idnv == null)
            {
                return;
            }
            string IDNV = idnv.ToString();
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Bạn có muốn xóa công trình này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bool kq = nhanVienBLL.xoaNhanVien(IDNV);

                if (kq)
                {
                    XtraMessageBox.Show("Xóa nhân viên thành công");
                    dataGridView1.DataSource = nhanVienBLL.getAllNhanVien();
                }
                else
                {
                    XtraMessageBox.Show("Xóa công trình thất bại !!");
                    dataGridView1.DataSource = nhanVienBLL.getAllNhanVien();
                }
            }
            else
            {
                dialog = DialogResult.Cancel;

            }
        }

        private void Form_QLNhanVien_Load(object sender, EventArgs e)
        {
        }
    }
}