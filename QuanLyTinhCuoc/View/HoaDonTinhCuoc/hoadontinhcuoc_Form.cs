namespace QuanLyTinhCuoc.View.HoaDonTinhCuoc
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;
    
    public partial class hoadontinhcuoc_Form : DevExpress.XtraEditors.XtraUserControl
    {
        HDTC_BUS hdtc_BUS = new HDTC_BUS();
        ThongTinSIMBUS thongTinSIMBUS = new ThongTinSIMBUS();
        public hoadontinhcuoc_Form()
        {
            InitializeComponent();
        }
        private void gchoadontinhcuoc_Load(object sender, EventArgs e)
        {
            Load_HDTC();
            Load_SIM();
        }

        private void Load_HDTC()
        {
            gchoadontinhcuoc.DataSource = hdtc_BUS.LoadHDTC();
        }

        private void Load_SIM()
        {
            gcSIM.DataSource = thongTinSIMBUS.LoadThongTinSim();
        }

        private void gvSIM_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.ThongTinSIM> sims = ((List<DTO.ThongTinSIM>)gcSIM.DataSource);
            DTO.ThongTinSIM sim = sims[gvSIM.FocusedRowHandle];
            gchoadontinhcuoc.DataSource = hdtc_BUS.LoadHDTC(sim.IDSIM);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Load_HDTC();
            txt_idhd.Text = String.Empty;
            txt_idsim.Text = String.Empty;
            txt_phihangthang.Text = String.Empty;
            txt_tongtien.Text = String.Empty;
            txt_tungay.Text = String.Empty;
            txt_denngay.Text = String.Empty;
            txt_ngayxuat.Text = String.Empty;
        }

        private void gvhoadontinhcuoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.HoaDonTinhCuoc> hds = ((List<DTO.HoaDonTinhCuoc>)gchoadontinhcuoc.DataSource);
            DTO.HoaDonTinhCuoc hd = hds[gvhoadontinhcuoc.FocusedRowHandle];
            txt_idhd.Text = hd.MaHDTC.ToString();
            txt_idsim.Text = hd.IDSIM;
            txt_phihangthang.Text = hd.PhiHangThang.ToString();
            txt_tongtien.Text = hd.TongTien.ToString();
            txt_tungay.Text = hd.TuNgay.ToString();
            txt_denngay.Text = hd.DenNgay.ToString();
            txt_ngayxuat.Text = hd.NgayXuat.ToString();
            ce_trangthai.Checked = hd.ThanhToan.Value;
            if (hd.ThanhToan.Value)
            {
                ce_trangthai.Enabled = false;
                btn_luu.Enabled = false;
            }
            else
            {
                ce_trangthai.Enabled = true;
                btn_luu.Enabled = true;
            }
        }

        private void btn_themthongtinsim_Click(object sender, EventArgs e)
        {
            if (ce_trangthai.Checked)
            {
                if (hdtc_BUS.ThanhToan(Int32.Parse(txt_idhd.Text)))
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải thay đổi tình trạng hóa đơn.", "Thông báo");
            }
            
        }
    }
}
