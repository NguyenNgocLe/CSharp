namespace QLTV.LoaiSach
{
    partial class frmThemLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiSach));
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.lblTenLoaiSach = new System.Windows.Forms.Label();
            this.lblMaLoaiSach = new System.Windows.Forms.Label();
            this.lblThemLoaiSach = new System.Windows.Forms.Label();
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
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.ilsIcon;
            this.btnThem.Location = new System.Drawing.Point(247, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 23;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(117, 132);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(224, 20);
            this.txtTenLoaiSach.TabIndex = 22;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(117, 102);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.ReadOnly = true;
            this.txtMaLoaiSach.Size = new System.Drawing.Size(224, 20);
            this.txtMaLoaiSach.TabIndex = 21;
            // 
            // lblTenLoaiSach
            // 
            this.lblTenLoaiSach.AutoSize = true;
            this.lblTenLoaiSach.Location = new System.Drawing.Point(22, 139);
            this.lblTenLoaiSach.Name = "lblTenLoaiSach";
            this.lblTenLoaiSach.Size = new System.Drawing.Size(71, 13);
            this.lblTenLoaiSach.TabIndex = 20;
            this.lblTenLoaiSach.Text = "Tên loại sách";
            // 
            // lblMaLoaiSach
            // 
            this.lblMaLoaiSach.AutoSize = true;
            this.lblMaLoaiSach.Location = new System.Drawing.Point(22, 109);
            this.lblMaLoaiSach.Name = "lblMaLoaiSach";
            this.lblMaLoaiSach.Size = new System.Drawing.Size(67, 13);
            this.lblMaLoaiSach.TabIndex = 19;
            this.lblMaLoaiSach.Text = "Mã loại sách";
            // 
            // lblThemLoaiSach
            // 
            this.lblThemLoaiSach.AutoSize = true;
            this.lblThemLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemLoaiSach.ForeColor = System.Drawing.Color.Red;
            this.lblThemLoaiSach.Location = new System.Drawing.Point(56, 33);
            this.lblThemLoaiSach.Name = "lblThemLoaiSach";
            this.lblThemLoaiSach.Size = new System.Drawing.Size(243, 31);
            this.lblThemLoaiSach.TabIndex = 18;
            this.lblThemLoaiSach.Text = "THÊM LOẠI SÁCH";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(301, 199);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLoaiSach);
            this.Controls.Add(this.txtMaLoaiSach);
            this.Controls.Add(this.lblTenLoaiSach);
            this.Controls.Add(this.lblMaLoaiSach);
            this.Controls.Add(this.lblThemLoaiSach);
            this.Controls.Add(this.btnHuy);
            this.KeyPreview = true;
            this.Name = "frmThemLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemLoaiSach";
            this.Load += new System.EventHandler(this.frmThemLoaiSach_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemLoaiSach_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label lblTenLoaiSach;
        private System.Windows.Forms.Label lblMaLoaiSach;
        private System.Windows.Forms.Label lblThemLoaiSach;
        private System.Windows.Forms.Button btnHuy;
    }
}