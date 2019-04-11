using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyTinhCuoc.BUS;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.View.ThongTinSIM
{
    public partial class thongtinsim_Form : DevExpress.XtraEditors.XtraUserControl
    {
        QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
        ThongTinSIMBUS thongtinBUS = new ThongTinSIMBUS();
        DTO.KhachHang khachhang;
        public thongtinsim_Form()
        {
            InitializeComponent();
            khachhang = new DTO.KhachHang();
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
            gcKhachHang.DataSource = db.KhachHangs.ToList();
        }
        public void Load_SIM()
        {
            gcSim.DataSource = db.ThongTinSIMs.ToList();
        }
        private void XuLyDate()
        {
            dtpNgayDangKy.Text = DateTime.Now.ToString();
            dtpNgayHetHan.Text = DateTime.Now.AddYears(+1).ToString();
        }

        private void btn_themthongtinsim_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (txt_sdt.Text.Trim().Length != 10 || !int.TryParse(txt_sdt.Text.Trim(), out int check))
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
                thongtinSIM.Flag = true;
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
            //khi đóng form themkhachhang sẽ chạy method main_formclosing
            //form.formclosing += new formclosingeventhandler(this.main_formclosing);
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
        }
    }
}
