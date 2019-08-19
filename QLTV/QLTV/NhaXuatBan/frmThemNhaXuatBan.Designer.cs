namespace QLTV.NhaXuatBan
{
    partial class frmThemNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhaXuatBan));
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtMaNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTenNhaXuatBan = new System.Windows.Forms.Label();
            this.lblMaNhaXuatBan = new System.Windows.Forms.Label();
            this.lblThemNhaXuatBan = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ilsIcon
            // 
            this.ilsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcon.ImageStream")));
            this.ilsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcon.Images.SetKeyName(0, "check.png");
            this.ilsIcon.Images.SetKeyName(1, "cancel32.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check.png");
            this.imageList1.Images.SetKeyName(1, "cancel32.png");
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.imageList2;
            this.btnThem.Location = new System.Drawing.Point(247, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 16;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "check.png");
            this.imageList2.Images.SetKeyName(1, "cancel32.png");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(117, 132);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(224, 20);
            this.txtTenNhaXuatBan.TabIndex = 14;
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(117, 102);
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.ReadOnly = true;
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(224, 20);
            this.txtMaNhaXuatBan.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblTenNhaXuatBan
            // 
            this.lblTenNhaXuatBan.AutoSize = true;
            this.lblTenNhaXuatBan.Location = new System.Drawing.Point(12, 139);
            this.lblTenNhaXuatBan.Name = "lblTenNhaXuatBan";
            this.lblTenNhaXuatBan.Size = new System.Drawing.Size(91, 13);
            this.lblTenNhaXuatBan.TabIndex = 11;
            this.lblTenNhaXuatBan.Text = "Tên nhà xuất bản";
            // 
            // lblMaNhaXuatBan
            // 
            this.lblMaNhaXuatBan.AutoSize = true;
            this.lblMaNhaXuatBan.Location = new System.Drawing.Point(12, 109);
            this.lblMaNhaXuatBan.Name = "lblMaNhaXuatBan";
            this.lblMaNhaXuatBan.Size = new System.Drawing.Size(87, 13);
            this.lblMaNhaXuatBan.TabIndex = 10;
            this.lblMaNhaXuatBan.Text = "Mã nhà xuất bản";
            // 
            // lblThemNhaXuatBan
            // 
            this.lblThemNhaXuatBan.AutoSize = true;
            this.lblThemNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemNhaXuatBan.ForeColor = System.Drawing.Color.Red;
            this.lblThemNhaXuatBan.Location = new System.Drawing.Point(30, 33);
            this.lblThemNhaXuatBan.Name = "lblThemNhaXuatBan";
            this.lblThemNhaXuatBan.Size = new System.Drawing.Size(299, 31);
            this.lblThemNhaXuatBan.TabIndex = 9;
            this.lblThemNhaXuatBan.Text = "THÊM NHÀ XUẤT BẢN";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.imageList2;
            this.btnHuy.Location = new System.Drawing.Point(301, 199);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenNhaXuatBan);
            this.Controls.Add(this.txtMaNhaXuatBan);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTenNhaXuatBan);
            this.Controls.Add(this.lblMaNhaXuatBan);
            this.Controls.Add(this.lblThemNhaXuatBan);
            this.Controls.Add(this.btnHuy);
            this.KeyPreview = true;
            this.Name = "frmThemNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.frmThemNhaXuatBan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemNhaXuatBan_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.TextBox txtMaNhaXuatBan;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTenNhaXuatBan;
        private System.Windows.Forms.Label lblMaNhaXuatBan;
        private System.Windows.Forms.Label lblThemNhaXuatBan;
        private System.Windows.Forms.Button btnHuy;
    }
}