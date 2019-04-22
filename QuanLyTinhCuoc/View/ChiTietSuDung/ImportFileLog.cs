namespace QuanLyTinhCuoc.View.ChiTietSuDung
{
    using System;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class ImportFileLog : DevExpress.XtraEditors.XtraForm
    {
        ChiTietSuDungBUS chitietbus = new ChiTietSuDungBUS();
        public ImportFileLog()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chitietbus.LoadChiTietSuDung();
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
            dataGridView1.DataSource = chitietbus.LoadChiTietSuDung();
        }
    }
}