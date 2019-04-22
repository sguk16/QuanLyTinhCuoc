namespace QuanLyTinhCuoc.View.ChiTietSuDung
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class chitietsudung_Form : DevExpress.XtraEditors.XtraUserControl
    {
        ChiTietSuDungBUS chitietbus = new ChiTietSuDungBUS();
        public chitietsudung_Form()
        {
            InitializeComponent();
        }
        public void Load_CHITIET()
        {
            gcchitietsudung.DataSource = chitietbus.LoadChiTietSuDung();
        }

        private void chitietsudung_Form_Load(object sender, EventArgs e)
        {
            Load_CHITIET();
        }

        private void gvchitietsudung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<DTO.ChiTietSuDung> chitiets = ((List<DTO.ChiTietSuDung>)gvchitietsudung.DataSource);
            DTO.ChiTietSuDung chitiet = chitiets[gvchitietsudung.FocusedRowHandle];
            tbxIDSIM.Text = chitiet.IDSIM;
            tbxMaCTSD.Text = chitiet.ID.ToString();
            tbxPhiCuocGoi.Text = (chitiet.SoPhutSD7h23h * 200 + chitiet.SoPhutSD23h7h * 150).ToString();
            tbxSoPhutSD.Text = (chitiet.SoPhutSD23h7h + chitiet.SoPhutSD7h23h).ToString();
            tbxTGBD.Text = chitiet.TGBD.ToString();
            tbxTGKT.Text = chitiet.TGKT.ToString();
        }

        private void btn_nhapfilelog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != String.Empty)
            {
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                bool tmp = chitietbus.Import(lines);
                if (tmp == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
                Load_CHITIET();
            }
        }
    }
}
