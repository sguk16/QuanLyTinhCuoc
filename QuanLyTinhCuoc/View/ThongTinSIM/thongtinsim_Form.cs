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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gcSim_Click(object sender, EventArgs e)
        {

        }

        private void gcKhachHang_Click(object sender, EventArgs e)
        {

        }
        
    }
}
