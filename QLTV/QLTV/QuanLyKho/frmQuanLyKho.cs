using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DangNhap;

namespace QLTV.QuanLyKho
{
    public partial class frmQuanLyKho : Form
    {
        public string tenNhanVienDangNhap { get; set; }
        public frmQuanLyKho()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            //
            this.Width = widthScreen;
            this.Height = heightScreen;
            float widthPerscpective = (float)Width / 1366;
            float heightPerscpective = (float)Height / 768;
            //
            resizeAllControls(this, widthPerscpective, heightPerscpective);
        }
        private void resizeAllControls(Control recussiveControl, float widthPerscpective, float heightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {
                if (control.Controls.Count != 0)
                {
                    resizeAllControls(control, widthPerscpective, heightPerscpective);
                }
                control.Left = (int)(control.Left * widthPerscpective);
                control.Top = (int)(control.Top * heightPerscpective);
                control.Width = (int)(control.Width * widthPerscpective);
                control.Height = (int)(control.Height * heightPerscpective);
            }
        }
        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            DateTime dateTime = DateTime.Now;
            lblNgayGio.Text = dateTime.ToString("  HH:mm:ss \ndd/MM/yyyy");
            lblNhanVienDangNhap.Text = "Xin chào,  " + tenNhanVienDangNhap;
            //
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
            this.Close();
        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblNgayGio.Text = dateTime.ToString("  HH:mm:ss \ndd/MM/yyyy");
        }
    }
}
