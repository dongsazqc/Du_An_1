using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class HoaDonChiTiet__REP
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();

        public HoaDonChiTiet__REP()
        {
                  
        }
        //Load 
        public List<HoaDonChiTiet> GetAll()
        {
            return _context.HoaDonChiTiets.ToList();
        }
        //thêm
        public bool AddHDCT(HoaDonChiTiet hdct)
        {
            try
            {
                _context.HoaDonChiTiets.Add(hdct);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        // sỬA




    }
}
