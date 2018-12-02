using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random_File.DAL;
using Random_File.DTO;

namespace Random_File.DAL
{
    class Import_logDAL
    {
        QLTinhCuocDT2Entities db = null;

        public Import_logDAL()
        {
            db = new QLTinhCuocDT2Entities();
        }
        public List<string> GetIDSIM()
        {
            var IDSIM = from sim in db.ThongTinSIMs where sim.Flag == true select sim.IDSIM;
            return IDSIM.ToList();
        }
    }
}
