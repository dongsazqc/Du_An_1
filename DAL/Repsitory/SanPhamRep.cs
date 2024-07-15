using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class SanPhamRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public SanPhamRep()
        {
            
        }
        public List<SanPham> GetAll()
        {
            return _context.SanPhams.ToList();
        }
    }
}
