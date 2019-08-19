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

namespace QLTV.LoaiSach
{
    public partial class frmThemLoaiSach : Form
    {
        public frmThemLoaiSach()
        {
            InitializeComponent();
        }
        private void frmThemLoaiSach_KeyDown(object sender, KeyEventArgs e)
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
        private void frmThemLoaiSach_Load(object sender, EventArgs e)
        {
            txtMaLoaiSach.Text = "LS" + (BAL_LoaiSach.Count() + 1);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLoaiSach = txtMaLoaiSach.Text;
            string tenLoaiSach = txtTenLoaiSach.Text;
            string trangThai = "Tồn tại";
            BEL_LoaiSach loaiSach = new BEL_LoaiSach(maLoaiSach, tenLoaiSach, trangThai);
            //
            try
            {
                if (BAL_LoaiSach.Add(loaiSach))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtMaLoaiSach.Text = "LS" + (BAL_LoaiSach.Count() + 1);
                    txtTenLoaiSach.Focus();
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
    }
}
