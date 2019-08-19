using System;
using System.Windows.Forms;
using BAL;
using QLTV.ThuThu;
using QLTV.DocGia;
using QLTV.QuanLyKho;

namespace QLTV.DangNhap
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnThoat_Click(sender, e);
            }
        }
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtMaNguoiDung.Text;
            string password = txtMatKhau.Text;
            //
            try
            {
                if (BAL_NhanVien.IsLogin(username, password))
                {
                    if (BAL_NhanVien.GetSpeciesById(username) == "LNV1")
                    {
                        frmQuanLyKho frmQuanLyKho = new frmQuanLyKho();
                        this.Hide();
                        frmQuanLyKho.tenNhanVienDangNhap = BAL_NhanVien.GetNameById(username);
                        frmQuanLyKho.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        frmThuThu frmThuThu = new frmThuThu();
                        this.Hide();
                        frmThuThu.tenNhanVienDangNhap = BAL_NhanVien.GetNameById(username);
                        frmThuThu.ShowDialog();
                        this.Close();
                    }

                }
                else if (BAL_DocGia.IsLogin(username, password))
                {
                    frmDocGia frmDocGia = new frmDocGia();
                    this.Hide();
                    frmDocGia.tenNhanVienDangNhap = BAL_DocGia.GetNameById(username);
                    frmDocGia.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã người dùng hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
