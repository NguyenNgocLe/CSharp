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


namespace QLTV.NgonNgu
{
    public partial class frmThemNgonNgu : Form
    {
        public frmThemNgonNgu()
        {
            InitializeComponent();
        }
        private void frmThemNgonNgu_KeyDown(object sender, KeyEventArgs e)
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
        private void frmThemNgonNgu_Load(object sender, EventArgs e)
        {
            txtMaNgonNgu.Text = "NN" + (BAL_NgonNgu.Count() + 1);
            txtTenNgonNgu.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNgonNgu = txtMaNgonNgu.Text;
            string tenNgonNgu = txtTenNgonNgu.Text;
            string trangThai = "Tồn tại";
            BEL_NgonNgu ngonNgu = new BEL_NgonNgu(maNgonNgu, tenNgonNgu, trangThai);
            //
            try
            {
                if (BAL_NgonNgu.Add(ngonNgu))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtMaNgonNgu.Text = "NN" + (BAL_NgonNgu.Count() + 1);
                    txtTenNgonNgu.Focus();
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
