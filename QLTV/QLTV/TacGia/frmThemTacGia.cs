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
using QLTV.ThuThu;

namespace QLTV.TacGia
{
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
        }
        private void frmThemTacGia_KeyDown(object sender, KeyEventArgs e)
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
        private void frmThemTacGia_Load(object sender, EventArgs e)
        {   txtMaTacGia.Text = "TG" + (BAL_TacGia.Count() + 1);
            txtTenTacGia.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTacGia = txtMaTacGia.Text;
            string tenTacGia = txtTenTacGia.Text;
            string dienThoai = txtDienThoai.Text;
            string trangThai = "Tồn tại";
            BEL_TacGia tacGia = new BEL_TacGia(maTacGia, tenTacGia, dienThoai, trangThai);
            //
            try
            {
                if (BAL_TacGia.Add(tacGia))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtMaTacGia.Text = "TG" + (BAL_TacGia.Count() + 1);
                    txtTenTacGia.Focus();
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
