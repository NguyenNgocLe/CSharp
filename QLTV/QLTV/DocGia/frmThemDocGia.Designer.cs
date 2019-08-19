namespace QLTV.DocGia
{
    partial class frmThemDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemDocGia));
            this.btnThem = new System.Windows.Forms.Button();
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.lblThemDocGia = new System.Windows.Forms.Label();
            this.txtTrangThaiDocGia = new System.Windows.Forms.TextBox();
            this.lblTrangThaiNhaXuatBan = new System.Windows.Forms.Label();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinhDocGia = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiDocGia = new System.Windows.Forms.TextBox();
            this.txtDienThoaiDocGia = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblMaLoaiDocGia = new System.Windows.Forms.Label();
            this.txtMatKhauDocGia = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.cboMaLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.ilsIcon;
            this.btnThem.Location = new System.Drawing.Point(586, 244);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 27;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ilsIcon
            // 
            this.ilsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcon.ImageStream")));
            this.ilsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcon.Images.SetKeyName(0, "check.png");
            this.ilsIcon.Images.SetKeyName(1, "cancel32.png");
            // 
            // lblThemDocGia
            // 
            this.lblThemDocGia.AutoSize = true;
            this.lblThemDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemDocGia.ForeColor = System.Drawing.Color.Red;
            this.lblThemDocGia.Location = new System.Drawing.Point(243, 9);
            this.lblThemDocGia.Name = "lblThemDocGia";
            this.lblThemDocGia.Size = new System.Drawing.Size(213, 31);
            this.lblThemDocGia.TabIndex = 20;
            this.lblThemDocGia.Text = "THÊM ĐỘC GIẢ";
            this.lblThemDocGia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTrangThaiDocGia
            // 
            this.txtTrangThaiDocGia.Location = new System.Drawing.Point(462, 214);
            this.txtTrangThaiDocGia.Name = "txtTrangThaiDocGia";
            this.txtTrangThaiDocGia.Size = new System.Drawing.Size(229, 20);
            this.txtTrangThaiDocGia.TabIndex = 30;
            // 
            // lblTrangThaiNhaXuatBan
            // 
            this.lblTrangThaiNhaXuatBan.AutoSize = true;
            this.lblTrangThaiNhaXuatBan.Location = new System.Drawing.Point(369, 217);
            this.lblTrangThaiNhaXuatBan.Name = "lblTrangThaiNhaXuatBan";
            this.lblTrangThaiNhaXuatBan.Size = new System.Drawing.Size(62, 13);
            this.lblTrangThaiNhaXuatBan.TabIndex = 29;
            this.lblTrangThaiNhaXuatBan.Text = "Trạng Thái ";
            this.lblTrangThaiNhaXuatBan.Click += new System.EventHandler(this.lblTrangThaiNhaXuatBan_Click);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(118, 108);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(224, 20);
            this.txtTenDocGia.TabIndex = 25;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(118, 78);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(224, 20);
            this.txtMaDocGia.TabIndex = 24;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(23, 146);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 23;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Location = new System.Drawing.Point(23, 115);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(68, 13);
            this.lblTenDocGia.TabIndex = 22;
            this.lblTenDocGia.Text = "Tên Độc Giả";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(22, 78);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(64, 13);
            this.lblMaDocGia.TabIndex = 21;
            this.lblMaDocGia.Text = "Mã Độc Giả";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(645, 244);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(371, 78);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 31;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(371, 115);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(59, 13);
            this.lblDienThoai.TabIndex = 32;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(22, 187);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 33;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinhDocGia
            // 
            this.dtpNgaySinhDocGia.Location = new System.Drawing.Point(118, 180);
            this.dtpNgaySinhDocGia.Name = "dtpNgaySinhDocGia";
            this.dtpNgaySinhDocGia.Size = new System.Drawing.Size(220, 20);
            this.dtpNgaySinhDocGia.TabIndex = 34;
            // 
            // txtDiaChiDocGia
            // 
            this.txtDiaChiDocGia.Location = new System.Drawing.Point(462, 78);
            this.txtDiaChiDocGia.Name = "txtDiaChiDocGia";
            this.txtDiaChiDocGia.Size = new System.Drawing.Size(229, 20);
            this.txtDiaChiDocGia.TabIndex = 35;
            // 
            // txtDienThoaiDocGia
            // 
            this.txtDienThoaiDocGia.Location = new System.Drawing.Point(462, 115);
            this.txtDienThoaiDocGia.Name = "txtDienThoaiDocGia";
            this.txtDienThoaiDocGia.Size = new System.Drawing.Size(229, 20);
            this.txtDienThoaiDocGia.TabIndex = 36;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(369, 146);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(53, 13);
            this.lblMatKhau.TabIndex = 37;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblMaLoaiDocGia
            // 
            this.lblMaLoaiDocGia.AutoSize = true;
            this.lblMaLoaiDocGia.Location = new System.Drawing.Point(369, 180);
            this.lblMaLoaiDocGia.Name = "lblMaLoaiDocGia";
            this.lblMaLoaiDocGia.Size = new System.Drawing.Size(87, 13);
            this.lblMaLoaiDocGia.TabIndex = 38;
            this.lblMaLoaiDocGia.Text = "Mã Loại Độc Giả";
            // 
            // txtMatKhauDocGia
            // 
            this.txtMatKhauDocGia.Location = new System.Drawing.Point(462, 146);
            this.txtMatKhauDocGia.Name = "txtMatKhauDocGia";
            this.txtMatKhauDocGia.Size = new System.Drawing.Size(229, 20);
            this.txtMatKhauDocGia.TabIndex = 39;
            this.txtMatKhauDocGia.UseSystemPasswordChar = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(118, 147);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 41;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(206, 147);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 42;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // cboMaLoaiDocGia
            // 
            this.cboMaLoaiDocGia.FormattingEnabled = true;
            this.cboMaLoaiDocGia.Location = new System.Drawing.Point(461, 178);
            this.cboMaLoaiDocGia.Name = "cboMaLoaiDocGia";
            this.cboMaLoaiDocGia.Size = new System.Drawing.Size(229, 21);
            this.cboMaLoaiDocGia.TabIndex = 43;
            this.cboMaLoaiDocGia.SelectedIndexChanged += new System.EventHandler(this.cboMaLoaiDocGia_SelectedIndexChanged);
            // 
            // frmThemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 296);
            this.Controls.Add(this.cboMaLoaiDocGia);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtMatKhauDocGia);
            this.Controls.Add(this.lblMaLoaiDocGia);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtDienThoaiDocGia);
            this.Controls.Add(this.txtDiaChiDocGia);
            this.Controls.Add(this.dtpNgaySinhDocGia);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThemDocGia);
            this.Controls.Add(this.txtTrangThaiDocGia);
            this.Controls.Add(this.lblTrangThaiNhaXuatBan);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTenDocGia);
            this.Controls.Add(this.lblMaDocGia);
            this.Controls.Add(this.btnHuy);
            this.KeyPreview = true;
            this.Name = "frmThemDocGia";
            this.Text = "Độc Giả";
            this.Load += new System.EventHandler(this.frmThemDocGia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemDocGia_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.Label lblThemDocGia;
        private System.Windows.Forms.TextBox txtTrangThaiDocGia;
        private System.Windows.Forms.Label lblTrangThaiNhaXuatBan;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhDocGia;
        private System.Windows.Forms.TextBox txtDiaChiDocGia;
        private System.Windows.Forms.TextBox txtDienThoaiDocGia;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblMaLoaiDocGia;
        private System.Windows.Forms.TextBox txtMatKhauDocGia;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ComboBox cboMaLoaiDocGia;
    }
}