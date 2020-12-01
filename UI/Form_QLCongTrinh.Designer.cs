namespace UI
{
    partial class Form_QLCongTrinh
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
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenCongTrinh = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelQuanLyDM = new System.Windows.Forms.Panel();
            this.dateNgayHoanThanh = new System.Windows.Forms.DateTimePicker();
            this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCongTrinh.Properties)).BeginInit();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panelQuanLyDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(257, 16);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(197, 54);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 1003;
            this.label4.Text = "Ngày Bắt đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(103, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Địa chỉ:";
            // 
            // tbTenCongTrinh
            // 
            this.tbTenCongTrinh.Enabled = false;
            this.tbTenCongTrinh.Location = new System.Drawing.Point(169, 16);
            this.tbTenCongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenCongTrinh.Name = "tbTenCongTrinh";
            this.tbTenCongTrinh.Size = new System.Drawing.Size(283, 22);
            this.tbTenCongTrinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Công trình:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(26, 87);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(190, 54);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnCapNhat);
            this.panelThaoTac.Location = new System.Drawing.Point(8, 28);
            this.panelThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(467, 159);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(257, 87);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(197, 54);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(26, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 54);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.panelThaoTac);
            this.groupControl2.Location = new System.Drawing.Point(5, 341);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(483, 192);
            this.groupControl2.TabIndex = 57;
            this.groupControl2.Text = "Thao Tác";
            // 
            // panelQuanLyDM
            // 
            this.panelQuanLyDM.Controls.Add(this.dateNgayHoanThanh);
            this.panelQuanLyDM.Controls.Add(this.dateNgayKetThuc);
            this.panelQuanLyDM.Controls.Add(this.dateNgayBatDau);
            this.panelQuanLyDM.Controls.Add(this.comboBoxTrangThai);
            this.panelQuanLyDM.Controls.Add(this.label7);
            this.panelQuanLyDM.Controls.Add(this.label6);
            this.panelQuanLyDM.Controls.Add(this.tbDiaChi);
            this.panelQuanLyDM.Controls.Add(this.label3);
            this.panelQuanLyDM.Controls.Add(this.label2);
            this.panelQuanLyDM.Controls.Add(this.label4);
            this.panelQuanLyDM.Controls.Add(this.label5);
            this.panelQuanLyDM.Controls.Add(this.tbTenCongTrinh);
            this.panelQuanLyDM.Controls.Add(this.label1);
            this.panelQuanLyDM.Location = new System.Drawing.Point(9, 28);
            this.panelQuanLyDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuanLyDM.Name = "panelQuanLyDM";
            this.panelQuanLyDM.Size = new System.Drawing.Size(465, 289);
            this.panelQuanLyDM.TabIndex = 53;
            // 
            // dateNgayHoanThanh
            // 
            this.dateNgayHoanThanh.Checked = false;
            this.dateNgayHoanThanh.CustomFormat = "dd/MM/yyyy";
            this.dateNgayHoanThanh.Enabled = false;
            this.dateNgayHoanThanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayHoanThanh.Location = new System.Drawing.Point(168, 212);
            this.dateNgayHoanThanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayHoanThanh.Name = "dateNgayHoanThanh";
            this.dateNgayHoanThanh.Size = new System.Drawing.Size(283, 23);
            this.dateNgayHoanThanh.TabIndex = 1019;
            this.dateNgayHoanThanh.Value = new System.DateTime(1900, 1, 1, 7, 0, 0, 0);
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateNgayKetThuc.Enabled = false;
            this.dateNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKetThuc.Location = new System.Drawing.Point(168, 171);
            this.dateNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(283, 23);
            this.dateNgayKetThuc.TabIndex = 1018;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateNgayBatDau.Enabled = false;
            this.dateNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBatDau.Location = new System.Drawing.Point(169, 128);
            this.dateNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(283, 23);
            this.dateNgayBatDau.TabIndex = 1017;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.Enabled = false;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(169, 252);
            this.comboBoxTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxTrangThai.Properties.Items.AddRange(new object[] {
            "Đang Thực Hiện",
            "Hoàn Thành",
            "Quá Hạn"});
            this.comboBoxTrangThai.Size = new System.Drawing.Size(283, 22);
            this.comboBoxTrangThai.TabIndex = 1016;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(79, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 1013;
            this.label7.Text = "Trạng thái:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // tbDiaChi
            // 
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Location = new System.Drawing.Point(169, 57);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(283, 61);
            this.tbDiaChi.TabIndex = 1010;
            this.tbDiaChi.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 1009;
            this.label3.Text = "Ngày Hoàn thành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1007;
            this.label2.Text = "Ngày Kết thúc Dự kiến:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyDM);
            this.groupControl1.Location = new System.Drawing.Point(5, 14);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(483, 322);
            this.groupControl1.TabIndex = 55;
            this.groupControl1.Text = "Thông Tin Công Trình";
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
            this.dataGridView1.Size = new System.Drawing.Size(847, 230);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.dataGridView1);
            this.groupControl3.Location = new System.Drawing.Point(495, 14);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(859, 265);
            this.groupControl3.TabIndex = 58;
            this.groupControl3.Text = "Danh Sách Công Trình";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl4.Controls.Add(this.dataGridView2);
            this.groupControl4.Location = new System.Drawing.Point(495, 283);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(859, 250);
            this.groupControl4.TabIndex = 59;
            this.groupControl4.Text = "Danh Sách Công Việc";
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
            this.dataGridView2.Size = new System.Drawing.Size(847, 220);
            this.dataGridView2.TabIndex = 56;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            // Form_QLCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 546);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_QLCongTrinh";
            this.Text = "Quản Lý Công Trình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QLCongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.Form_QLCongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenCongTrinh.Properties)).EndInit();
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panelQuanLyDM.ResumeLayout(false);
            this.panelQuanLyDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbTenCongTrinh;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panelQuanLyDM;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbDiaChi;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.DateTimePicker dateNgayHoanThanh;
    }
}