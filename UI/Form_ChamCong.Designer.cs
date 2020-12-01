
namespace UI
{
    partial class Form_ChamCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView_DanhSachCongTrinh = new System.Windows.Forms.DataGridView();
            this.idCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView_DanhSachCongViecCuaCongTrinh = new System.Windows.Forms.DataGridView();
            this.idCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView_CongViecCuaNhanVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChamCong = new DevExpress.XtraEditors.SimpleButton();
            this.btnVang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCongTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCongViecCuaCongTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CongViecCuaNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.dataGridView_DanhSachCongTrinh);
            this.groupControl3.Location = new System.Drawing.Point(12, 11);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(640, 359);
            this.groupControl3.TabIndex = 68;
            this.groupControl3.Text = "Danh Sách Công Trình";
            // 
            // dataGridView_DanhSachCongTrinh
            // 
            this.dataGridView_DanhSachCongTrinh.AllowUserToAddRows = false;
            this.dataGridView_DanhSachCongTrinh.AllowUserToDeleteRows = false;
            this.dataGridView_DanhSachCongTrinh.AllowUserToResizeRows = false;
            this.dataGridView_DanhSachCongTrinh.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_DanhSachCongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachCongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCongTrinh,
            this.isDelete,
            this.tenCongTrinh,
            this.diaChi,
            this.ngayBatDau,
            this.ngayKetThucDuKien,
            this.ngayHoanThanh,
            this.trangThai});
            this.dataGridView_DanhSachCongTrinh.Location = new System.Drawing.Point(6, 27);
            this.dataGridView_DanhSachCongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_DanhSachCongTrinh.MultiSelect = false;
            this.dataGridView_DanhSachCongTrinh.Name = "dataGridView_DanhSachCongTrinh";
            this.dataGridView_DanhSachCongTrinh.ReadOnly = true;
            this.dataGridView_DanhSachCongTrinh.RowHeadersVisible = false;
            this.dataGridView_DanhSachCongTrinh.RowHeadersWidth = 51;
            this.dataGridView_DanhSachCongTrinh.RowTemplate.Height = 24;
            this.dataGridView_DanhSachCongTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DanhSachCongTrinh.Size = new System.Drawing.Size(629, 323);
            this.dataGridView_DanhSachCongTrinh.TabIndex = 56;
            this.dataGridView_DanhSachCongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DanhSachCongTrinh_CellClick);
            // 
            // idCongTrinh
            // 
            this.idCongTrinh.DataPropertyName = "idCongTrinh";
            this.idCongTrinh.FillWeight = 95.84665F;
            this.idCongTrinh.HeaderText = "ID Công Trình";
            this.idCongTrinh.MinimumWidth = 6;
            this.idCongTrinh.Name = "idCongTrinh";
            this.idCongTrinh.ReadOnly = true;
            this.idCongTrinh.Width = 125;
            // 
            // isDelete
            // 
            this.isDelete.DataPropertyName = "isDelete";
            this.isDelete.HeaderText = "Trạng Thái XÓa";
            this.isDelete.MinimumWidth = 6;
            this.isDelete.Name = "isDelete";
            this.isDelete.ReadOnly = true;
            this.isDelete.Visible = false;
            this.isDelete.Width = 125;
            // 
            // tenCongTrinh
            // 
            this.tenCongTrinh.DataPropertyName = "tenCongTrinh";
            this.tenCongTrinh.FillWeight = 54.96075F;
            this.tenCongTrinh.HeaderText = "Tên Công Trình";
            this.tenCongTrinh.MinimumWidth = 6;
            this.tenCongTrinh.Name = "tenCongTrinh";
            this.tenCongTrinh.ReadOnly = true;
            this.tenCongTrinh.Width = 120;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.FillWeight = 186.4927F;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Visible = false;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            this.ngayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.ngayBatDau.MinimumWidth = 6;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            this.ngayBatDau.Width = 125;
            // 
            // ngayKetThucDuKien
            // 
            this.ngayKetThucDuKien.DataPropertyName = "ngayKetThucDuKien";
            this.ngayKetThucDuKien.HeaderText = "Ngày Kết Thúc Dự Kiến";
            this.ngayKetThucDuKien.MinimumWidth = 6;
            this.ngayKetThucDuKien.Name = "ngayKetThucDuKien";
            this.ngayKetThucDuKien.ReadOnly = true;
            this.ngayKetThucDuKien.Width = 125;
            // 
            // ngayHoanThanh
            // 
            this.ngayHoanThanh.DataPropertyName = "ngayHoanThanh";
            this.ngayHoanThanh.HeaderText = "Ngày Hoàn Thành";
            this.ngayHoanThanh.MinimumWidth = 6;
            this.ngayHoanThanh.Name = "ngayHoanThanh";
            this.ngayHoanThanh.ReadOnly = true;
            this.ngayHoanThanh.Visible = false;
            this.ngayHoanThanh.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.FillWeight = 48.86432F;
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 120;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl4.Controls.Add(this.dataGridView_DanhSachCongViecCuaCongTrinh);
            this.groupControl4.Location = new System.Drawing.Point(658, 11);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(694, 296);
            this.groupControl4.TabIndex = 69;
            this.groupControl4.Text = "Danh Sách Công Việc Của Công Trình";
            // 
            // dataGridView_DanhSachCongViecCuaCongTrinh
            // 
            this.dataGridView_DanhSachCongViecCuaCongTrinh.AllowUserToAddRows = false;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.AllowUserToDeleteRows = false;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCongViec,
            this.tenCV,
            this.isDe,
            this.tenCT,
            this.stt,
            this.idPhanCong});
            this.dataGridView_DanhSachCongViecCuaCongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.Location = new System.Drawing.Point(2, 28);
            this.dataGridView_DanhSachCongViecCuaCongTrinh.Name = "dataGridView_DanhSachCongViecCuaCongTrinh";
            this.dataGridView_DanhSachCongViecCuaCongTrinh.ReadOnly = true;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.RowHeadersVisible = false;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.RowHeadersWidth = 51;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.RowTemplate.Height = 24;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.Size = new System.Drawing.Size(690, 266);
            this.dataGridView_DanhSachCongViecCuaCongTrinh.TabIndex = 0;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.Visible = false;
            this.dataGridView_DanhSachCongViecCuaCongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DanhSachCongViecCuaCongTrinh_CellClick_1);
            // 
            // idCongViec
            // 
            this.idCongViec.DataPropertyName = "idCongViec";
            this.idCongViec.HeaderText = "ID Công Việc";
            this.idCongViec.MinimumWidth = 6;
            this.idCongViec.Name = "idCongViec";
            this.idCongViec.ReadOnly = true;
            // 
            // tenCV
            // 
            this.tenCV.DataPropertyName = "tenCongViec";
            this.tenCV.HeaderText = "Tên Công Việc";
            this.tenCV.MinimumWidth = 6;
            this.tenCV.Name = "tenCV";
            this.tenCV.ReadOnly = true;
            // 
            // isDe
            // 
            this.isDe.DataPropertyName = "isDelete";
            this.isDe.HeaderText = "isDelete";
            this.isDe.MinimumWidth = 6;
            this.isDe.Name = "isDe";
            this.isDe.ReadOnly = true;
            this.isDe.Visible = false;
            // 
            // tenCT
            // 
            this.tenCT.DataPropertyName = "tenCongTrinh";
            this.tenCT.HeaderText = "tenCongTrinh";
            this.tenCT.MinimumWidth = 6;
            this.tenCT.Name = "tenCT";
            this.tenCT.ReadOnly = true;
            this.tenCT.Visible = false;
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "stt";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Visible = false;
            // 
            // idPhanCong
            // 
            this.idPhanCong.DataPropertyName = "idPhanCong";
            this.idPhanCong.HeaderText = "idPhanCong";
            this.idPhanCong.MinimumWidth = 6;
            this.idPhanCong.Name = "idPhanCong";
            this.idPhanCong.ReadOnly = true;
            this.idPhanCong.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.dataGridView_CongViecCuaNhanVien);
            this.groupControl1.Location = new System.Drawing.Point(664, 317);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(693, 242);
            this.groupControl1.TabIndex = 70;
            this.groupControl1.Text = "Danh Sách Nhân Viên Thuộc Công Việc";
            // 
            // dataGridView_CongViecCuaNhanVien
            // 
            this.dataGridView_CongViecCuaNhanVien.AllowUserToAddRows = false;
            this.dataGridView_CongViecCuaNhanVien.AllowUserToDeleteRows = false;
            this.dataGridView_CongViecCuaNhanVien.AllowUserToResizeRows = false;
            this.dataGridView_CongViecCuaNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_CongViecCuaNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CongViecCuaNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.idNhanVien,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView_CongViecCuaNhanVien.Location = new System.Drawing.Point(5, 30);
            this.dataGridView_CongViecCuaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_CongViecCuaNhanVien.MultiSelect = false;
            this.dataGridView_CongViecCuaNhanVien.Name = "dataGridView_CongViecCuaNhanVien";
            this.dataGridView_CongViecCuaNhanVien.ReadOnly = true;
            this.dataGridView_CongViecCuaNhanVien.RowHeadersVisible = false;
            this.dataGridView_CongViecCuaNhanVien.RowHeadersWidth = 51;
            this.dataGridView_CongViecCuaNhanVien.RowTemplate.Height = 24;
            this.dataGridView_CongViecCuaNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CongViecCuaNhanVien.Size = new System.Drawing.Size(683, 201);
            this.dataGridView_CongViecCuaNhanVien.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn12.FillWeight = 95.84665F;
            this.dataGridViewTextBoxColumn12.HeaderText = "STT";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // idNhanVien
            // 
            this.idNhanVien.DataPropertyName = "idNhanVien";
            this.idNhanVien.HeaderText = "ID";
            this.idNhanVien.MinimumWidth = 6;
            this.idNhanVien.Name = "idNhanVien";
            this.idNhanVien.ReadOnly = true;
            this.idNhanVien.Visible = false;
            this.idNhanVien.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "tenNhanVien";
            this.dataGridViewTextBoxColumn13.FillWeight = 54.96075F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Tên Nhân Viên";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 400;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnChamCong.Appearance.Options.UseFont = true;
            this.btnChamCong.Location = new System.Drawing.Point(12, 404);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(640, 58);
            this.btnChamCong.TabIndex = 58;
            this.btnChamCong.Text = "Có Mặt";
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnVang
            // 
            this.btnVang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnVang.Appearance.Options.UseFont = true;
            this.btnVang.Location = new System.Drawing.Point(12, 501);
            this.btnVang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVang.Name = "btnVang";
            this.btnVang.Size = new System.Drawing.Size(640, 58);
            this.btnVang.TabIndex = 71;
            this.btnVang.Text = "Vắng";
            this.btnVang.Click += new System.EventHandler(this.btnVang_Click);
            // 
            // Form_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 570);
            this.Controls.Add(this.btnVang);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Name = "Form_ChamCong";
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.Form_ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCongTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCongViecCuaCongTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CongViecCuaNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachCongTrinh;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView_CongViecCuaNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private DevExpress.XtraEditors.SimpleButton btnVang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachCongViecCuaCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhanCong;
    }
}