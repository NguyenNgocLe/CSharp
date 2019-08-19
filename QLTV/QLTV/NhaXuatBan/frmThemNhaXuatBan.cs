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

namespace QLTV.NhaXuatBan
{
    public partial class frmThemNhaXuatBan : Form
    {
        public frmThemNhaXuatBan()
        {
            InitializeComponent();
        }
        private void frmThemNhaXuatBan_KeyDown(object sender, KeyEventArgs e)
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
        private void frmThemNhaXuatBan_Load(object sender, EventArgs e)
        {
            txtMaNhaXuatBan.Text = "NXB" + (BAL_NhaXuatBan.Count() + 1);
            txtTenNhaXuatBan.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNhaXuatBan = txtMaNhaXuatBan.Text;
            string tenNhaXuatBan = txtTenNhaXuatBan.Text;
            string email = txtEmail.Text;
            string trangThai = "Tồn tại";
            BEL_NhaXuatBan nhaXuatBan = new BEL_NhaXuatBan(maNhaXuatBan, tenNhaXuatBan, email, trangThai);
            //
            try
            {
                if (BAL_NhaXuatBan.Add(nhaXuatBan))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtMaNhaXuatBan.Text = "NXB" + (BAL_NhaXuatBan.Count() + 1);
                    txtTenNhaXuatBan.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
    }
}
