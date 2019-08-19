namespace QLTV.QuanLyKho
{
    partial class frmQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKho));
            this.lblNgayGio = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblNhanVienDangNhap = new System.Windows.Forms.Label();
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblQuanLyThuVien = new System.Windows.Forms.Label();
            this.tabSach = new System.Windows.Forms.TabPage();
            this.tabQuanLyThuVien = new System.Windows.Forms.TabControl();
            this.tabQuanLyThuVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNgayGio
            // 
            this.lblNgayGio.AutoSize = true;
            this.lblNgayGio.Location = new System.Drawing.Point(1250, 53);
            this.lblNgayGio.Name = "lblNgayGio";
            this.lblNgayGio.Size = new System.Drawing.Size(0, 13);
            this.lblNgayGio.TabIndex = 9;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblNhanVienDangNhap
            // 
            this.lblNhanVienDangNhap.AutoSize = true;
            this.lblNhanVienDangNhap.ForeColor = System.Drawing.Color.Green;
            this.lblNhanVienDangNhap.Location = new System.Drawing.Point(12, 40);
            this.lblNhanVienDangNhap.Name = "lblNhanVienDangNhap";
            this.lblNhanVienDangNhap.Size = new System.Drawing.Size(55, 13);
            this.lblNhanVienDangNhap.TabIndex = 7;
            this.lblNhanVienDangNhap.Text = "Xin chào, ";
            // 
            // ilsIcon
            // 
            this.ilsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcon.ImageStream")));
            this.ilsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcon.Images.SetKeyName(0, "nv32.png");
            this.ilsIcon.Images.SetKeyName(1, "dg32.png");
            this.ilsIcon.Images.SetKeyName(2, "s32.png");
            this.ilsIcon.Images.SetKeyName(3, "tg32.png");
            this.ilsIcon.Images.SetKeyName(4, "nxb32.png");
            this.ilsIcon.Images.SetKeyName(5, "nn32.png");
            this.ilsIcon.Images.SetKeyName(6, "tl32.png");
            this.ilsIcon.Images.SetKeyName(7, "csm32.png");
            this.ilsIcon.Images.SetKeyName(8, "add32.png");
            this.ilsIcon.Images.SetKeyName(9, "delete32.png");
            this.ilsIcon.Images.SetKeyName(10, "update32.png");
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(8, 61);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblQuanLyThuVien
            // 
            this.lblQuanLyThuVien.AutoSize = true;
            this.lblQuanLyThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyThuVien.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyThuVien.Location = new System.Drawing.Point(550, 30);
            this.lblQuanLyThuVien.Name = "lblQuanLyThuVien";
            this.lblQuanLyThuVien.Size = new System.Drawing.Size(268, 31);
            this.lblQuanLyThuVien.TabIndex = 5;
            this.lblQuanLyThuVien.Text = "QUẢN LÝ THƯ VIỆN";
            this.lblQuanLyThuVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabSach
            // 
            this.tabSach.ImageIndex = 2;
            this.tabSach.Location = new System.Drawing.Point(4, 39);
            this.tabSach.Name = "tabSach";
            this.tabSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabSach.Size = new System.Drawing.Size(1352, 607);
            this.tabSach.TabIndex = 4;
            this.tabSach.Text = "Sách";
            this.tabSach.UseVisualStyleBackColor = true;
            // 
            // tabQuanLyThuVien
            // 
            this.tabQuanLyThuVien.Controls.Add(this.tabSach);
            this.tabQuanLyThuVien.ImageList = this.ilsIcon;
            this.tabQuanLyThuVien.Location = new System.Drawing.Point(4, 90);
            this.tabQuanLyThuVien.Name = "tabQuanLyThuVien";
            this.tabQuanLyThuVien.SelectedIndex = 0;
            this.tabQuanLyThuVien.Size = new System.Drawing.Size(1360, 650);
            this.tabQuanLyThuVien.TabIndex = 6;
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.lblNgayGio);
            this.Controls.Add(this.lblNhanVienDangNhap);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.tabQuanLyThuVien);
            this.Controls.Add(this.lblQuanLyThuVien);
            this.Name = "frmQuanLyKho";
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            this.tabQuanLyThuVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayGio;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblNhanVienDangNhap;
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblQuanLyThuVien;
        private System.Windows.Forms.TabPage tabSach;
        private System.Windows.Forms.TabControl tabQuanLyThuVien;
    }
}