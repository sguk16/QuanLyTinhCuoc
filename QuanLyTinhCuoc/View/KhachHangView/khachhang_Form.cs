using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.View.KhachHangView
{
    public partial class khachhang_Form : DevExpress.XtraEditors.XtraUserControl
    {
        QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
        public khachhang_Form()
        {
            InitializeComponent();
        }
        public void Load_KHACHHANG()
        {
            gcKhachHang.DataSource = db.KhachHangs.ToList();
        }

        private void khachhang_Form_Load(object sender, EventArgs e)
        {
            Load_KHACHHANG();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string makh = txtmakhachhang.EditValue.ToString();
            DTO.KhachHang temp = db.KhachHangs.FirstOrDefault(i => i.MaKH == makh);

            if (temp != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string Tenkhachhang = txttenkhachhang.Text;
                string Chucvu = txtchucvu.Text;
                string Nghenghiep = txtnghenghiep.Text;
                string Email = txtemail.Text;
                string diachi = txtdiachi.Text;
                string CMND = txtcmnd.Text;
                try
                {
                    db.KhachHangs.Add(new DTO.KhachHang() { MaKH = makh, TenKH = Tenkhachhang, CMND = CMND, NgheNghiep = Nghenghiep, ChucVu = Chucvu, DiaChi = diachi, Flag=true});
                    db.SaveChanges();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm khách hàng không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Load_KHACHHANG();

            }
        }
    }
}
