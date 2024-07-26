using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class HoaDonRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public HoaDonRep()
        {
             
        }
        public List<HoaDon> GetAll()
        {
            return _context.HoaDons.ToList();
        }


        public bool AddHD(HoaDon hd)
        {
            try
            {
                _context.HoaDons.Add(hd);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }


    }
}
