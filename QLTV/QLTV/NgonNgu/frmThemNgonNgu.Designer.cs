namespace QLTV.NgonNgu
{
    partial class frmThemNgonNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNgonNgu));
            this.btnThem = new System.Windows.Forms.Button();
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.txtTenNgonNgu = new System.Windows.Forms.TextBox();
            this.txtMaNgonNgu = new System.Windows.Forms.TextBox();
            this.lblTenNgonNgu = new System.Windows.Forms.Label();
            this.lblMaNgonNgu = new System.Windows.Forms.Label();
            this.lblThemNgonNgu = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.ilsIcon;
            this.btnThem.Location = new System.Drawing.Point(247, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 16;
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
            // txtTenNgonNgu
            // 
            this.txtTenNgonNgu.Location = new System.Drawing.Point(117, 132);
            this.txtTenNgonNgu.Name = "txtTenNgonNgu";
            this.txtTenNgonNgu.Size = new System.Drawing.Size(224, 20);
            this.txtTenNgonNgu.TabIndex = 14;
            // 
            // txtMaNgonNgu
            // 
            this.txtMaNgonNgu.Location = new System.Drawing.Point(117, 102);
            this.txtMaNgonNgu.Name = "txtMaNgonNgu";
            this.txtMaNgonNgu.ReadOnly = true;
            this.txtMaNgonNgu.Size = new System.Drawing.Size(224, 20);
            this.txtMaNgonNgu.TabIndex = 13;
            // 
            // lblTenNgonNgu
            // 
            this.lblTenNgonNgu.AutoSize = true;
            this.lblTenNgonNgu.Location = new System.Drawing.Point(22, 139);
            this.lblTenNgonNgu.Name = "lblTenNgonNgu";
            this.lblTenNgonNgu.Size = new System.Drawing.Size(74, 13);
            this.lblTenNgonNgu.TabIndex = 11;
            this.lblTenNgonNgu.Text = "Tên ngôn ngữ";
            // 
            // lblMaNgonNgu
            // 
            this.lblMaNgonNgu.AutoSize = true;
            this.lblMaNgonNgu.Location = new System.Drawing.Point(22, 109);
            this.lblMaNgonNgu.Name = "lblMaNgonNgu";
            this.lblMaNgonNgu.Size = new System.Drawing.Size(70, 13);
            this.lblMaNgonNgu.TabIndex = 10;
            this.lblMaNgonNgu.Text = "Mã ngôn ngữ";
            // 
            // lblThemNgonNgu
            // 
            this.lblThemNgonNgu.AutoSize = true;
            this.lblThemNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemNgonNgu.ForeColor = System.Drawing.Color.Red;
            this.lblThemNgonNgu.Location = new System.Drawing.Point(60, 33);
            this.lblThemNgonNgu.Name = "lblThemNgonNgu";
            this.lblThemNgonNgu.Size = new System.Drawing.Size(248, 31);
            this.lblThemNgonNgu.TabIndex = 9;
            this.lblThemNgonNgu.Text = "THÊM NGÔN NGỮ";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(301, 199);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNgonNgu);
            this.Controls.Add(this.txtMaNgonNgu);
            this.Controls.Add(this.lblTenNgonNgu);
            this.Controls.Add(this.lblMaNgonNgu);
            this.Controls.Add(this.lblThemNgonNgu);
            this.Controls.Add(this.btnHuy);
            this.KeyPreview = true;
            this.Name = "frmThemNgonNgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNgonNgu";
            this.Load += new System.EventHandler(this.frmThemNgonNgu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemNgonNgu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.TextBox txtTenNgonNgu;
        private System.Windows.Forms.TextBox txtMaNgonNgu;
        private System.Windows.Forms.Label lblTenNgonNgu;
        private System.Windows.Forms.Label lblMaNgonNgu;
        private System.Windows.Forms.Label lblThemNgonNgu;
        private System.Windows.Forms.Button btnHuy;
    }
}