using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
   
    public class SanPhamMuaRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public SanPhamMuaRep()
        {
            
        }
        public List<SanPhamMua> GetAll()
        {
            return _context.SanPhamMuas.ToList();
        }
        public bool AddSPM(SanPhamMua spm)
        {
            try
            {
                _context.SanPhamMuas.Add(spm);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public List<SanPhamMua> GetSanPhamByHoaDonId(string hoaDonId)
        {
            return _context.SanPhamMuas
                            .Where(sp => sp.HoaDonId == hoaDonId) // Giả sử có thuộc tính HoaDonId trong SanPhamMua
                            .ToList();
        }

    }
}
