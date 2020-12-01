namespace UI
{
    partial class Form_QLCongViec
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
            this.components = new System.ComponentModel.Container();
            this.tenCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnXoaCVCongTrinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCVCongTrinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuanLyDM = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenCongViec = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelQuanLyDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
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
            // ngayBatDau
            // 
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            this.ngayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.ngayBatDau.MinimumWidth = 6;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            this.ngayBatDau.Visible = false;
            this.ngayBatDau.Width = 125;
            // 
            // ngayKetThucDuKien
            // 
            this.ngayKetThucDuKien.DataPropertyName = "ngayKetThucDuKien";
            this.ngayKetThucDuKien.HeaderText = "Ngày Kết Thúc Dự Kiến";
            this.ngayKetThucDuKien.MinimumWidth = 6;
            this.ngayKetThucDuKien.Name = "ngayKetThucDuKien";
            this.ngayKetThucDuKien.ReadOnly = true;
            this.ngayKetThucDuKien.Visible = false;
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
            this.groupControl4.Controls.Add(this.dataGridView2);
            this.groupControl4.Location = new System.Drawing.Point(630, 283);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(722, 250);
            this.groupControl4.TabIndex = 63;
            this.groupControl4.Text = "Danh Sách Công Việc Của Công Trình";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(6, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(710, 220);
            this.dataGridView2.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCongViec";
            this.dataGridViewTextBoxColumn1.FillWeight = 95.84665F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Công Việc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenCongViec";
            this.dataGridViewTextBoxColumn2.FillWeight = 54.96075F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Công Việc";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.dataGridView1);
            this.groupControl3.Location = new System.Drawing.Point(630, 14);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(722, 265);
            this.groupControl3.TabIndex = 62;
            this.groupControl3.Text = "Danh Sách Công Trình";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCongTrinh,
            this.tenCongTrinh,
            this.diaChi,
            this.ngayBatDau,
            this.ngayKetThucDuKien,
            this.ngayHoanThanh,
            this.trangThai});
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 230);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.FillWeight = 186.4927F;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.panelThaoTac);
            this.groupControl2.Location = new System.Drawing.Point(3, 341);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(619, 192);
            this.groupControl2.TabIndex = 61;
            this.groupControl2.Text = "Thao Tác";
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnXoaCVCongTrinh);
            this.panelThaoTac.Controls.Add(this.btnThemCVCongTrinh);
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnCapNhat);
            this.panelThaoTac.Location = new System.Drawing.Point(8, 28);
            this.panelThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(605, 159);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btnXoaCVCongTrinh
            // 
            this.btnXoaCVCongTrinh.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaCVCongTrinh.Appearance.Options.UseFont = true;
            this.btnXoaCVCongTrinh.Location = new System.Drawing.Point(427, 87);
            this.btnXoaCVCongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaCVCongTrinh.Name = "btnXoaCVCongTrinh";
            this.btnXoaCVCongTrinh.Size = new System.Drawing.Size(164, 54);
            this.btnXoaCVCongTrinh.TabIndex = 9;
            this.btnXoaCVCongTrinh.Text = "Xóa Công Việc \r\nKhỏi Công Trình";
            this.btnXoaCVCongTrinh.Click += new System.EventHandler(this.btnXoaCVCongTrinh_Click);
            // 
            // btnThemCVCongTrinh
            // 
            this.btnThemCVCongTrinh.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThemCVCongTrinh.Appearance.Options.UseFont = true;
            this.btnThemCVCongTrinh.Location = new System.Drawing.Point(427, 16);
            this.btnThemCVCongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCVCongTrinh.Name = "btnThemCVCongTrinh";
            this.btnThemCVCongTrinh.Size = new System.Drawing.Size(166, 54);
            this.btnThemCVCongTrinh.TabIndex = 8;
            this.btnThemCVCongTrinh.Text = "Thêm Công Việc \r\nVào Công Trình";
            this.btnThemCVCongTrinh.Click += new System.EventHandler(this.btnThemCVCongTrinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(237, 87);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(164, 54);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(14, 87);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 54);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(14, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 54);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(237, 16);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(164, 54);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl5.Appearance.Options.UseBackColor = true;
            this.groupControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl5.Controls.Add(this.dataGridView3);
            this.groupControl5.Location = new System.Drawing.Point(3, 128);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(619, 208);
            this.groupControl5.TabIndex = 64;
            this.groupControl5.Text = "Danh Sách Tất Cả Công Việc";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView3.Location = new System.Drawing.Point(6, 27);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(608, 174);
            this.dataGridView3.TabIndex = 57;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idCongViec";
            this.dataGridViewTextBoxColumn3.FillWeight = 95.84665F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Công Việc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tenCongViec";
            this.dataGridViewTextBoxColumn4.FillWeight = 54.96075F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Công Việc";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panelQuanLyDM
            // 
            this.panelQuanLyDM.Controls.Add(this.label6);
            this.panelQuanLyDM.Controls.Add(this.tbTenCongViec);
            this.panelQuanLyDM.Controls.Add(this.label1);
            this.panelQuanLyDM.Location = new System.Drawing.Point(9, 28);
            this.panelQuanLyDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuanLyDM.Name = "panelQuanLyDM";
            this.panelQuanLyDM.Size = new System.Drawing.Size(604, 60);
            this.panelQuanLyDM.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(35, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 1012;
            this.label6.Text = " ";
            // 
            // tbTenCongViec
            // 
            this.tbTenCongViec.Enabled = false;
            this.tbTenCongViec.Location = new System.Drawing.Point(131, 16);
            this.tbTenCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenCongViec.Name = "tbTenCongViec";
            this.tbTenCongViec.Size = new System.Drawing.Size(461, 22);
            this.tbTenCongViec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Công việc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyDM);
            this.groupControl1.Location = new System.Drawing.Point(3, 14);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(619, 110);
            this.groupControl1.TabIndex = 60;
            this.groupControl1.Text = "Thông Tin Công Việc";
            // 
            // Form_QLCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 546);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_QLCongViec";
            this.Text = "Quản Lý Công Việc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QLCongViec_FormClosed);
            this.Load += new System.EventHandler(this.Form_QLCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelQuanLyDM.ResumeLayout(false);
            this.panelQuanLyDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tenCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnXoaCVCongTrinh;
        private DevExpress.XtraEditors.SimpleButton btnThemCVCongTrinh;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panelQuanLyDM;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit tbTenCongViec;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}