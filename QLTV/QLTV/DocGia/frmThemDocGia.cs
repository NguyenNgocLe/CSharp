using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace QLTV.DocGia
{
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void lblTrangThaiNhaXuatBan_Click(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDocGia = txtMaDocGia.Text;
            string tenDocGia = txtTenDocGia.Text;
            string gioiTinh;
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            DateTime ngaySinh = dtpNgaySinhDocGia.Value;
            string diaChi = txtDiaChiDocGia.Text;
            string dienThoai = txtDienThoaiDocGia.Text;
            string matKhau = txtMatKhauDocGia.Text;
            string maLoaiDocGia = cboMaLoaiDocGia.Text;
            if (maLoaiDocGia == "Trẻ em")
            {
                maLoaiDocGia = "LDG001";
            }
            else if(maLoaiDocGia == "Người lớn")
            {
                maLoaiDocGia = "LDG002";
            }
            string trangThai = txtTrangThaiDocGia.Text;
            BEL_DocGia docGia = new BEL_DocGia(maDocGia, tenDocGia, gioiTinh, ngaySinh, diaChi, dienThoai, matKhau, maLoaiDocGia, trangThai);
            try
            {
                if (!BAL_DocGia.IsExist(maDocGia))
                {
                    if (tenDocGia == "")
                    {
                        txtTenDocGia.Focus();
                    }
                    else if (gioiTinh == "")
                    {
                        radNam.Focus();
                    }
                    else if (ngaySinh == null)
                    {
                        dtpNgaySinhDocGia.Focus();
                    }
                    else if (diaChi == "")
                    {
                        txtDiaChiDocGia.Focus();
                    }
                    else if (dienThoai == "")
                    {
                        txtDienThoaiDocGia.Focus();
                    }
                    else if (matKhau == "")
                    {
                        txtMatKhauDocGia.Focus();
                    }
                    else if (maLoaiDocGia == "")
                    {
                        cboMaLoaiDocGia.Focus();
                    }
                    else if (trangThai == "")
                    {
                        txtTrangThaiDocGia.Focus();
                    }
                    if (BAL_DocGia.Add(docGia))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã độc giả đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDocGia.Focus();
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThemDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnHuy_Click(sender, e);
            }
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            cboMaLoaiDocGia.DataSource = BAL_LoaiDocGia.Load();
            cboMaLoaiDocGia.ValueMember = "MaLoaiDocGia";
            cboMaLoaiDocGia.DisplayMember = "TenLoai";
        }

        private void cboMaLoaiDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
