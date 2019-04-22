namespace QuanLyTinhCuoc.View.HoaDonDangKy
{
    using System;
    using System.Collections.Generic;
    using QuanLyTinhCuoc.BUS;

    public partial class hoadondangky_Form : DevExpress.XtraEditors.XtraUserControl
    {
        HDDK_BUS hddkbus = new HDDK_BUS();
        ThongTinSIMBUS thongtinsimbus = new ThongTinSIMBUS();
        public hoadondangky_Form()
        {
            InitializeComponent();
        }
        public void Load_HDDK()
        {
            gcHDDK.DataSource = hddkbus.LoadHoaDonDangKy();
        }
        public void Load_SIM()
        {
            gcSIM.DataSource = thongtinsimbus.LoadThongTinSim();
        }
        private void hoadondangky_Form_Load(object sender, EventArgs e)
        {
            Load_HDDK();
            Load_SIM();
        }

        private void gvSIM_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.ThongTinSIM> sims = ((List<DTO.ThongTinSIM>)gvSIM.DataSource);
            DTO.ThongTinSIM sim = sims[gvSIM.FocusedRowHandle];
            string masim = sim.IDSIM;
            gcHDDK.DataSource = hddkbus.LoadHoaDonDangKy(masim);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon themHoaDon = new ThemHoaDon();
            themHoaDon.ShowDialog();
            Load_HDDK();
            Load_SIM();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Load_SIM();
        }
    }
}
