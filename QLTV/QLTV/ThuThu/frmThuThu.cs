using System;
using System.Windows.Forms;
using BEL;
using BAL;
using QLTV.DangNhap;
using System.Data;
using QLTV.LoaiNhanVien;
using QLTV.LoaiDocGia;
using QLTV.ThuThu;
using QLTV.TacGia;
using QLTV.NhaXuatBan;
using QLTV.DocGia;
using QLTV.NgonNgu;
using QLTV.LoaiSach;


namespace QLTV.ThuThu
{
    public partial class frmThuThu : Form
    {
        public string tenNhanVienDangNhap { get; set; }
        public frmThuThu()
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
        private void frmThuThu_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            DateTime dateTime = DateTime.Now;
            lblNgayGio.Text = dateTime.ToString("  HH:mm:ss \ndd/MM/yyyy");
            lblNhanVienDangNhap.Text = "Xin chào,  " + tenNhanVienDangNhap;
            //
            khoaTextBoxThongTinTimKiem(true);
            //
            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
            //
        }
        //private void frmThuThu_Activated(object sender, EventArgs e)
        //{
        //    //loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.Load());
        //    //loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.Load());
        //    //loadDanhSachSach(dgvDanhSachSach, BAL_Sach.Load());
        //    loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
        //    loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
        //    loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
        //    loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
        //}
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
        //
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvDanhSachDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvDanhSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvDanhSachTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maTacGia = dgvDanhSachTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString().Trim();
            BEL_TacGia tacGia = BAL_TacGia.GetObjectById(maTacGia);
            txtMaTacGia.Text = tacGia.Ma;
            txtTenTacGia.Text = tacGia.Ten;
            txtDienThoaiTacGia.Text = tacGia.DienThoai;
        }
        private void dgvDanhSachNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNhaXuatBan = dgvDanhSachNhaXuatBan.CurrentRow.Cells["MaNhaXuatBan"].Value.ToString().Trim();
            BEL_NhaXuatBan nhaXuatBan = BAL_NhaXuatBan.GetObjectById(maNhaXuatBan);
            txtMaNhaXuatBan.Text = nhaXuatBan.Ma;
            txtTenNhaXuatBan.Text = nhaXuatBan.Ten;
            txtEmailNhaXuatBan.Text = nhaXuatBan.Email;
        }
        private void dgvDanhSachNgonNgu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNgonNgu = dgvDanhSachNgonNgu.CurrentRow.Cells["MaNgonNgu"].Value.ToString().Trim();
            BEL_NgonNgu ngonNgu = BAL_NgonNgu.GetObjectById(maNgonNgu);
            txtMaNgonNgu.Text = ngonNgu.Ma;
            txtTenNgonNgu.Text = ngonNgu.Ten;
        }
        private void dgvDanhSachLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLoaiSach = dgvDanhSachLoaiSach.CurrentRow.Cells["MaLoai"].Value.ToString().Trim();
            BEL_LoaiSach loaiSach = BAL_LoaiSach.GetObjectById(maLoaiSach);
            txtMaLoaiSach.Text = loaiSach.Ma;
            txtTenLoaiSach.Text = loaiSach.Ten;
        }
        //
        private void khoaTextBoxThongTinTimKiem(bool value)
        {
            txtThongTinTimKiemNhanVien.Enabled = !value;
            txtThongTinTimKiemDocGia.Enabled = !value;
            txtThongTinTimKiemSach.Enabled = !value;
            txtThongTinTiemKiemTacGia.Enabled = !value;
            txtThongTinTimKiemNhaXuatBan.Enabled = !value;
            txtThongTinTimKiemNgonNgu.Enabled = !value;
            txtThongTinTimKiemLoaiSach.Enabled = !value;
        }
        //
        private void loadDanhSachNhanVien(DataGridView dgv, DataTable dtb)
        { }
        private void loadDanhSachDocGia(DataGridView dgv, DataTable dtb)
        { }
        private void loadDanhSachSach(DataGridView dgv, DataTable dtb)
        { }
        private void loadDanhSachTacGia(DataGridView dgv, DataTable dtb)
        {
            dgv.DataSource = dtb;
            dgv.Columns["MaTacGia"].HeaderText = "Mã tác giả";
            dgv.Columns["TenTacGia"].HeaderText = "Tên tác giả";
            dgv.Columns["DienThoai"].HeaderText = "Điện thoại";
            //
            dgv.Columns["MaTacGia"].Width = (int)dgvDanhSachTacGia.Width / 3;
            dgv.Columns["TenTacGia"].Width = (int)dgvDanhSachTacGia.Width / 3;
            dgv.Columns["DienThoai"].Width = (int)dgvDanhSachTacGia.Width / 3;
        }
        private void loadDanhSachNhaXuatBan(DataGridView dgv, DataTable dtb)
        {
            dgv.DataSource = dtb;
            dgv.Columns["MaNhaXuatBan"].HeaderText = "Mã nhà xuất bản";
            dgv.Columns["TenNhaXuatBan"].HeaderText = "Tên nhà xuất bản";
            dgv.Columns["Email"].HeaderText = "Email";
            //
            dgv.Columns["MaNhaXuatBan"].Width = (int)dgvDanhSachTacGia.Width / 3;
            dgv.Columns["TenNhaXuatBan"].Width = (int)dgvDanhSachTacGia.Width / 3;
            dgv.Columns["Email"].Width = (int)dgvDanhSachTacGia.Width / 3;
        }
        private void loadDanhSachNgonNgu(DataGridView dgv, DataTable dtb)
        {
            dgv.DataSource = dtb;
            dgv.Columns["MaNgonNgu"].HeaderText = "Mã ngôn ngữ";
            dgv.Columns["TenNgonNgu"].HeaderText = "Tên ngôn ngữ";
            //
            dgv.Columns["MaNgonNgu"].Width = (int)dgvDanhSachTacGia.Width / 2;
            dgv.Columns["TenNgonNgu"].Width = (int)dgvDanhSachTacGia.Width / 2;
        }
        private void loadDanhSachLoaiSach(DataGridView dgv, DataTable dtb)
        {
            dgv.DataSource = dtb;
            dgv.Columns["MaLoai"].HeaderText = "Mã loại sách";
            dgv.Columns["TenLoai"].HeaderText = "Tên loại sách";
            //
            dgv.Columns["MaLoai"].Width = (int)dgvDanhSachTacGia.Width / 2;
            dgv.Columns["TenLoai"].Width = (int)dgvDanhSachTacGia.Width / 2;
        }
        //
        private void txtThongTinTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtThongTinTimKiemDocGia_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtThongTinTimKiemSach_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtThongTinTiemKiemTacGia_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTiemKiemTacGia.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemTacGia.SelectedItem.ToString() == "Tìm kiếm theo mã tác giả")
                    {
                        if (BAL_TacGia.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
                        }
                    }
                    else if (cboPhuongThucTimKiemTacGia.SelectedItem.ToString() == "Tìm kiếm theo tên tác giả")
                    {
                        if (BAL_TacGia.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
            }
        }
        private void txtThongTinTimKiemNhaXuatBan_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemNhaXuatBan.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemNhaXuatBan.SelectedItem.ToString() == "Tìm kiếm theo mã nhà xuất bản")
                    {
                        if (BAL_NhaXuatBan.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
                        }
                    }
                    else if (cboPhuongThucTimKiemNhaXuatBan.SelectedItem.ToString() == "Tìm kiếm theo tên nhà xuất bản")
                    {
                        if (BAL_NhaXuatBan.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
            }
        }
        private void txtThongTinTimKiemNgonNgu_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemNgonNgu.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemNgonNgu.SelectedItem.ToString() == "Tìm kiếm theo mã ngôn ngữ")
                    {
                        if (BAL_NgonNgu.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
                        }
                    }
                    else if (cboPhuongThucTimKiemNgonNgu.SelectedItem.ToString() == "Tìm kiếm theo tên ngôn ngữ")
                    {
                        if (BAL_NgonNgu.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
            }
        }
        private void txtThongTinTimKiemLoaiSach_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemLoaiSach.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemLoaiSach.SelectedItem.ToString() == "Tìm kiếm theo mã loại sách")
                    {
                        if (BAL_LoaiSach.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
                        }
                    }
                    else if (cboPhuongThucTimKiemLoaiSach.SelectedItem.ToString() == "Tìm kiếm theo tên loại sách")
                    {
                        if (BAL_LoaiSach.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
            }
        }
        //
        private void cboPhuongThucTimKiemNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemNhanVien.Enabled = true;
            txtThongTinTimKiemNhanVien.Focus();
        }
        private void cboPhuongThucTimKiemDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemDocGia.Enabled = true;
            txtThongTinTimKiemDocGia.Focus();
        }
        private void cboPhuongThucTimKiemSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemSach.Enabled = true;
            txtThongTinTimKiemLoaiSach.Focus();
        }
        private void cboPhuongThucTimKiemTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTiemKiemTacGia.Enabled = true;
            txtThongTinTiemKiemTacGia.Focus();
        }
        private void cboPhuongThucTimKiemNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemNhaXuatBan.Enabled = true;
            txtThongTinTimKiemNhaXuatBan.Focus();
        }
        private void cboPhuongThucTimKiemNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemNgonNgu.Enabled = true;
            txtThongTinTimKiemNgonNgu.Focus();
        }
        private void cboPhuongThucTimKiemLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemLoaiSach.Enabled = true;
            txtThongTinTimKiemLoaiSach.Focus();
        }
        //
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

        }
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemTacGia frmThemTacGia = new frmThemTacGia();
            frmThemTacGia.ShowDialog();
        }
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            frmThemTacGia frmThemTacGia = new frmThemTacGia();
            frmThemTacGia.ShowDialog();
            //
            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
            for (int i = 0; i < dgvDanhSachTacGia.RowCount; i++)
            {
                if (dgvDanhSachTacGia["MaTacGia", i].Value.ToString() == ("TG" + BAL_TacGia.Count()))
                {
                    dgvDanhSachTacGia["TenTacGia", i].Selected = true;
                }
            }
        }
        private void btnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmThemNhaXuatBan frmThemNhaXuatBan = new frmThemNhaXuatBan();
            frmThemNhaXuatBan.ShowDialog();
            //
            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
            for (int i = 0; i < dgvDanhSachNhaXuatBan.RowCount; i++)
            {
                if (dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Value.ToString() == ("NXB" + BAL_NhaXuatBan.Count()))
                {
                    dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Selected = true;
                }
            }
        }
        private void btnThemNgonNgu_Click(object sender, EventArgs e)
        {
            frmThemNgonNgu frmThemNgonNgu = new frmThemNgonNgu();
            frmThemNgonNgu.ShowDialog();
            //
            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
            for (int i = 0; i < dgvDanhSachNgonNgu.RowCount; i++)
            {
                if (dgvDanhSachNgonNgu["MaNgonNgu", i].Value.ToString() == ("NN" + BAL_NgonNgu.Count()))
                {
                    dgvDanhSachNgonNgu["MaNgonNgu", i].Selected = true;
                }
            }
        }
        private void btnThemLoaiSach_Click(object sender, EventArgs e)
        {
            frmThemLoaiSach frmThemLoaiSach = new frmThemLoaiSach();
            frmThemLoaiSach.ShowDialog();
            //
            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
            for (int i = 0; i < dgvDanhSachLoaiSach.RowCount; i++)
            {
                if (dgvDanhSachLoaiSach["MaLoai", i].Value.ToString() == ("LS" + BAL_LoaiSach.Count()))
                {
                    dgvDanhSachLoaiSach["MaLoai", i].Selected = true;
                }
            }
        }
        //
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {

        }
        private void btnSuaDocGia_Click(object sender, EventArgs e)
        {

        }
        private void btnSuaSach_Click(object sender, EventArgs e)
        {

        }
        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            string maTacGia = txtMaTacGia.Text;
            string tenTacGia = txtTenTacGia.Text;
            string dienThoai = txtDienThoaiTacGia.Text;
            string trangThai = "Tồn tại";
            BEL_TacGia tacGia = new BEL_TacGia(maTacGia, tenTacGia, dienThoai, trangThai);
            try
            {
                if (BAL_TacGia.Update(tacGia))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
                    //
                    for(int i = 0; i< dgvDanhSachTacGia.RowCount; i++)
                    {
                        if(dgvDanhSachTacGia["MaTacGia", i].Value.ToString() == maTacGia)
                        {
                            dgvDanhSachTacGia["MaTacGia", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaNhaXuatBan_Click(object sender, EventArgs e)
        {
            string maNhaXuatBan = txtMaNhaXuatBan.Text;
            string tenNhaXuatBan = txtTenNhaXuatBan.Text;
            string email = txtEmailNhaXuatBan.Text;
            string trangThai = "Tồn tại";
            BEL_NhaXuatBan nhaXuatBan = new BEL_NhaXuatBan(maNhaXuatBan, tenNhaXuatBan, email, trangThai);
            try
            {
                if (BAL_NhaXuatBan.Update(nhaXuatBan))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
                    //
                    for (int i = 0; i < dgvDanhSachNhaXuatBan.RowCount; i++)
                    {
                        if (dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Value.ToString() == maNhaXuatBan)
                        {
                            dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaNgonNgu_Click(object sender, EventArgs e)
        {
            string maNgonNgu = txtMaNgonNgu.Text;
            string tenNgonNgu = txtTenNgonNgu.Text;
            string trangThai = "Tồn tại";
            BEL_NgonNgu ngonNgu = new BEL_NgonNgu(maNgonNgu, tenNgonNgu, trangThai);
            try
            {
                if (BAL_NgonNgu.Update(ngonNgu))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
                    //
                    for (int i = 0; i < dgvDanhSachNgonNgu.RowCount; i++)
                    {
                        if (dgvDanhSachNgonNgu["MaNgonNgu", i].Value.ToString() == maNgonNgu)
                        {
                            dgvDanhSachNgonNgu["TenNgonNgu", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaLoaiSach_Click(object sender, EventArgs e)
        {
            string maLoaiSach = txtMaLoaiSach.Text;
            string tenLoaiSach = txtTenLoaiSach.Text;
            string trangThai = "Tồn tại";
            BEL_LoaiSach loaiSach = new BEL_LoaiSach(maLoaiSach, tenLoaiSach, trangThai);
            try
            {
                if (BAL_LoaiSach.Update(loaiSach))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
                    //
                    for (int i = 0; i < dgvDanhSachLoaiSach.RowCount; i++)
                    {
                        if (dgvDanhSachLoaiSach["MaLoai", i].Value.ToString() == maLoaiSach)
                        {
                            dgvDanhSachLoaiSach["TenLoai", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            string maTacGia = txtMaTacGia.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_TacGia.Delete(maTacGia))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
                        //
                        txtMaTacGia.Text = "";
                        txtTenTacGia.Text = "";
                        txtDienThoaiTacGia.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaNhaXuatBan_Click(object sender, EventArgs e)
        {
            string maNhaXuatBan = txtMaNhaXuatBan.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_NhaXuatBan.Delete(maNhaXuatBan))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
                        //
                        txtMaNhaXuatBan.Text = "";
                        txtTenNhaXuatBan.Text = "";
                        txtEmailNhaXuatBan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaNgonNgu_Click(object sender, EventArgs e)
        {
            string maNgonNgu = txtMaNgonNgu.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_NgonNgu.Delete(maNgonNgu))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
                        //
                        txtMaNgonNgu.Text = "";
                        txtTenNgonNgu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaLoaiSach_Click(object sender, EventArgs e)
        {
            string maLoaiSach = txtMaLoaiSach.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_LoaiSach.Delete(maLoaiSach))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
                        //
                        txtMaLoaiSach.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        private void txtThongTinTimKiemNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemNhanVien.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemDocGia.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemSach.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTiemKiemTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTiemKiemTacGia.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemNhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemNhaXuatBan.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemNgonNgu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemNgonNgu.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemLoaiSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemLoaiSach.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        //
    }
    //
    //
}
