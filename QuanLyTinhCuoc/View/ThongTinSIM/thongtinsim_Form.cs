namespace QuanLyTinhCuoc.View.ThongTinSIM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class thongtinsim_Form : DevExpress.XtraEditors.XtraUserControl
    {
        ThongTinSIMBUS thongtinBUS = new ThongTinSIMBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        const string pphone = @"^0[35789]\d{8}$";
        public thongtinsim_Form()
        {
            InitializeComponent();
        }

        private void thongtinsim_Form_Load(object sender, EventArgs e)
        {
            txt_idsim.Text = thongtinBUS.XuLyIDSIM();
            cbbMaKH.Properties.Items.AddRange(thongtinBUS.LoadMaKH());
            XuLyDate();
            Load_KHACHHANG();
            Load_SIM();
        }
        public void Load_KHACHHANG()
        {
            gcKhachHang.DataSource = khachHangBUS.LoadKhachHang();
        }
        public void Load_SIM()
        {
            gcSim.DataSource = thongtinBUS.LoadThongTinSim();
        }
        private void XuLyDate()
        {
            dtpNgayDangKy.Text = DateTime.Now.ToString();
            dtpNgayHetHan.Text = DateTime.Now.AddYears(+1).ToString();
        }

        private void btn_themthongtinsim_Click(object sender, EventArgs e)
        {
            Regex phone = new Regex(pphone);
            if (txt_sdt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (!phone.Match(txt_sdt.Text).Success)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
            }
            else if (!cbbMaKH.Properties.Items.Contains(cbbMaKH.Text))
            {
                MessageBox.Show("Mã Khách Hàng không đúng!", "Thông báo");
            }
            else
            {
                DTO.ThongTinSIM thongtinSIM = new DTO.ThongTinSIM();

                thongtinSIM.IDSIM = txt_idsim.Text;
                thongtinSIM.MaKH = cbbMaKH.Text;
                thongtinSIM.SoDienThoai = txt_sdt.Text;
                thongtinSIM.NgayDangKy = Convert.ToDateTime(dtpNgayDangKy.Text);
                thongtinSIM.NgayHetHan = Convert.ToDateTime(dtpNgayHetHan.Text);
                thongtinSIM.Flag = ce_trangthai.Checked;
                if (thongtinBUS.ThemThongTinSim(thongtinSIM))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }

            }
        }
        private void ThemSim_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbbMaKH.Properties.Items.Clear();
            cbbMaKH.Properties.Items.AddRange(thongtinBUS.LoadMaKH());
        }
        private void btn_themkh_Click(object sender, EventArgs e)
        {
            KhachHang.ThemKhachHang form = new KhachHang.ThemKhachHang();
            form.FormClosing += new FormClosingEventHandler(this.ThemSim_FormClosing);
            form.Show();
        }

        private void gvKhachhang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.KhachHang> khs = ((List<DTO.KhachHang>)gvKhachhang.DataSource);
            DTO.KhachHang kh = khs[gvKhachhang.FocusedRowHandle];
            string makh = kh.MaKH;
            List<DTO.ThongTinSIM> ds = thongtinBUS.loadtheokh(makh);
            gcSim.DataSource = ds.ToList();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Load_SIM();
            txt_idsim.Text = thongtinBUS.XuLyIDSIM();
            cbbMaKH.SelectedItem = null;
            txt_sdt.Text = String.Empty;
            XuLyDate();
            btn_luukh.Enabled = false;
            btn_themthongtinsim.Enabled = true;
        }

        private void gvSim_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.ThongTinSIM> thongtinsims = ((List<DTO.ThongTinSIM>)gvSim.DataSource);
            DTO.ThongTinSIM thongtinsim = thongtinsims[gvSim.FocusedRowHandle];
            txt_idsim.Text = thongtinsim.IDSIM;
            cbbMaKH.Text = thongtinsim.MaKH;
            txt_sdt.Text = thongtinsim.SoDienThoai;
            dtpNgayDangKy.Text = thongtinsim.NgayDangKy.ToString();
            dtpNgayHetHan.Text = thongtinsim.NgayHetHan.ToString();
            ce_trangthai.Checked = (bool) thongtinsim.Flag.HasValue;
            btn_luukh.Enabled = true;
            btn_themthongtinsim.Enabled = false;
        }

        private void btn_luukh_Click(object sender, EventArgs e)
        {
            Regex phone = new Regex(pphone);
            if (txt_sdt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (!phone.Match(txt_sdt.Text).Success)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
            }
            else if (!cbbMaKH.Properties.Items.Contains(cbbMaKH.Text))
            {
                MessageBox.Show("Mã Khách Hàng không đúng!", "Thông báo");
            }
            else
            {
                DTO.ThongTinSIM thongtinSIM = new DTO.ThongTinSIM();

                thongtinSIM.IDSIM = txt_idsim.Text;
                thongtinSIM.MaKH = cbbMaKH.Text;
                thongtinSIM.SoDienThoai = txt_sdt.Text;
                thongtinSIM.NgayDangKy = Convert.ToDateTime(dtpNgayDangKy.Text);
                thongtinSIM.NgayHetHan = Convert.ToDateTime(dtpNgayHetHan.Text);
                thongtinSIM.Flag = ce_trangthai.Checked;
                if (thongtinBUS.SuaThongTinSim(thongtinSIM))
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!", "Thông báo");
                }
                Load_SIM();
            }
        }
    }
}
