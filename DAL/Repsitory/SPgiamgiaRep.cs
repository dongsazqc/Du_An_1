using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class SPgiamgiaRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public SPgiamgiaRep()
        {
            
        }
        public List<SanPhamGiamGium> GetAll()
        {
            return _context.SanPhamGiamGia.ToList();
        }
    }
}
