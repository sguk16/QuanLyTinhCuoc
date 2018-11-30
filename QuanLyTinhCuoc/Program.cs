using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QuanLyTinhCuoc.View.ChiTietSuDung;
using QuanLyTinhCuoc.View.ThongTinSIM;
using QuanLyTinhCuoc.View;

namespace QuanLyTinhCuoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            Application.Run(new Giaodienchinh());
        }
    }
}
