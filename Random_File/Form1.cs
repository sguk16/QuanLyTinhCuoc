using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Random_File.DAL;
using Random_File.DTO;

namespace Random_File
{
    public partial class Form1 : Form
    {
         Import_logDAL dal = new Import_logDAL();

        QLTinhCuocDT2Entities db = new QLTinhCuocDT2Entities();
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime GetStartTime(Random gen)
        {
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(now.Year, 1, 1);
            return start.AddMonths(gen.Next(0, 12)).AddDays(gen.Next(0, 30)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
        private void btntaodulieu_Click(object sender, EventArgs e)
        {
            gvfilelog.Rows.Clear();

            int maxrows = 100;

            Random gen = new Random();

            List<string> IDs = dal.GetIDSIM();


            DateTime start;
            DateTime end;


            for (int i = 0; i < maxrows; i++)
            {
                gvfilelog.Rows.Add();

                gvfilelog.Rows[i].Cells["IDSIM"].Value = IDs[gen.Next(IDs.Count)];


                start = GetStartTime(gen);
                end = start.AddHours(gen.Next(0, 2)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));


                gvfilelog.Rows[i].Cells["TGBD"].Value = start.ToString("dd-MM-yyyy   HH:mm:ss");
                gvfilelog.Rows[i].Cells["TGKT"].Value = end.ToString("dd-MM-yyyy   HH:mm:ss");
            }
        }
    }
}
