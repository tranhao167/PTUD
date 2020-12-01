namespace UI
{
    partial class Form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.tbMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.tbTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(232, 273);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(217, 79);
            this.btnDangNhap.TabIndex = 36;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.EditValue = "123";
            this.tbMatKhau.Location = new System.Drawing.Point(232, 215);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Properties.UseSystemPasswordChar = true;
            this.tbMatKhau.Size = new System.Drawing.Size(304, 22);
            this.tbMatKhau.TabIndex = 35;
            this.tbMatKhau.EditValueChanged += new System.EventHandler(this.tbMatKhau_EditValueChanged);
            this.tbMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMatKhau_KeyDown);
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.EditValue = "NV0001";
            this.tbTaiKhoan.Location = new System.Drawing.Point(232, 159);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(304, 22);
            this.tbTaiKhoan.TabIndex = 34;
            this.tbTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTaiKhoan_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(146, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(146, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 38);
            this.label1.TabIndex = 31;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ LAO ĐỘNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 446);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form_DangNhap.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_DangNhap_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_DangNhap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.TextEdit tbMatKhau;
        private DevExpress.XtraEditors.TextEdit tbTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}