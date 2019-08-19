namespace QLTV.TacGia
{
    partial class frmThemTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTacGia));
            this.lblThemTacGia = new System.Windows.Forms.Label();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThemTacGia
            // 
            this.lblThemTacGia.AutoSize = true;
            this.lblThemTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemTacGia.ForeColor = System.Drawing.Color.Red;
            this.lblThemTacGia.Location = new System.Drawing.Point(80, 33);
            this.lblThemTacGia.Name = "lblThemTacGia";
            this.lblThemTacGia.Size = new System.Drawing.Size(207, 31);
            this.lblThemTacGia.TabIndex = 0;
            this.lblThemTacGia.Text = "THÊM TÁC GIẢ";
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Location = new System.Drawing.Point(22, 109);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(57, 13);
            this.lblMaTacGia.TabIndex = 1;
            this.lblMaTacGia.Text = "Mã tác giả";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Location = new System.Drawing.Point(22, 139);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(61, 13);
            this.lblTenTacGia.TabIndex = 2;
            this.lblTenTacGia.Text = "Tên tác giả";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(117, 102);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.ReadOnly = true;
            this.txtMaTacGia.Size = new System.Drawing.Size(224, 20);
            this.txtMaTacGia.TabIndex = 4;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(117, 132);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(224, 20);
            this.txtTenTacGia.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.ilsIcon;
            this.btnThem.Location = new System.Drawing.Point(247, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 7;
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
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(301, 199);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(117, 163);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(224, 20);
            this.txtDienThoai.TabIndex = 6;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(22, 170);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // frmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.lblMaTacGia);
            this.Controls.Add(this.lblThemTacGia);
            this.KeyPreview = true;
            this.Name = "frmThemTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tác giả";
            this.Load += new System.EventHandler(this.frmThemTacGia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemTacGia_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThemTacGia;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDienThoai;
    }
}