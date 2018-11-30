using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.View.HoaDonDangKy
{
    public partial class hoadondangky_Form : DevExpress.XtraEditors.XtraUserControl
    {
        QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
        public hoadondangky_Form()
        {
            InitializeComponent();
        }
        public void Load_HDDK()
        {
            gcHDDK.DataSource = db.HoaDonDangKies.ToList();
        }
        private void hoadondangky_Form_Load(object sender, EventArgs e)
        {
            Load_HDDK();
        }


        private void btn_xoahddk_Click(object sender, EventArgs e)
        {
            DTO.HoaDonDangKy hddk = db.HoaDonDangKies.Find(tbxMaHHDK.Text);

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + hddk.MaHDDK + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                hddk.Flag = false;

                db.Entry(hddk).State = EntityState.Modified;
                db.SaveChanges();
            }
            Load_HDDK();
        }

        private void gvHDDK_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gvHDDK_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.HoaDonDangKy> hOADONs = ((List<DTO.HoaDonDangKy>)gvHDDK.DataSource);
            DTO.HoaDonDangKy hOADON = hOADONs[gvHDDK.FocusedRowHandle];
            tbxMaHHDK.Text = hOADON.MaHDDK;
            tbxChiPhiDK.Text = hOADON.ChiPhiDangKy.ToString();
            tbxIDSIM.Text = hOADON.IDSIM;
            tbxTenKH.Text = hOADON.ThongTinSIM.KhachHang.TenKH;
        }

        private void gcHDDK_Click(object sender, EventArgs e)
        {
            List<DTO.HoaDonDangKy> hOADONs = ((List<DTO.HoaDonDangKy>)gvHDDK.DataSource);
            DTO.HoaDonDangKy hOADON = hOADONs[gvHDDK.FocusedRowHandle];
            tbxMaHHDK.Text = hOADON.MaHDDK;
            tbxChiPhiDK.Text = hOADON.ChiPhiDangKy.ToString();
            tbxIDSIM.Text = hOADON.IDSIM;
            tbxTenKH.Text = hOADON.ThongTinSIM.KhachHang.TenKH;
        }
    }
}
