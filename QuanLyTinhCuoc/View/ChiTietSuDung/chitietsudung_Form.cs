using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyTinhCuoc.BUS;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.View.ChiTietSuDung
{
    public partial class chitietsudung_Form : DevExpress.XtraEditors.XtraUserControl
    {
        QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
        ChiTietSuDungBUS chitietbus = new ChiTietSuDungBUS();
        public chitietsudung_Form()
        {
            InitializeComponent();
        }
        public void Load_CHITIET()
        {
            gcchitietsudung.DataSource = db.ChiTietSuDungs.ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            //string[] lines = System.IO.File.ReadAllLines(@"C:/Users/DELL/Desktop/Output.txt");
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
