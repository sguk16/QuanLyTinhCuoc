using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.View.HoaDonTinhCuoc
{
    public partial class hoadontinhcuoc_Form : DevExpress.XtraEditors.XtraUserControl
    {
        QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
        object temp;
        public hoadontinhcuoc_Form()
        {
            InitializeComponent();
        }
        private void gchoadontinhcuoc_Load(object sender, EventArgs e)
        {
            gchoadontinhcuoc.DataSource = db.HoaDonTinhCuocs.ToList();
        }

        private void gvhoadontinhcuoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thay đổi mã cước " + e.RowHandle + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                db.SaveChanges();
            }
            else
            {
                QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
                gchoadontinhcuoc.DataSource = db.HoaDonTinhCuocs.ToList();

            }
        }
        private void gchoadontinhcuoc_Click(object sender, EventArgs e)
        {
            gchoadontinhcuoc.DataSource = db.HoaDonTinhCuocs.ToList();
        }
    }
}
