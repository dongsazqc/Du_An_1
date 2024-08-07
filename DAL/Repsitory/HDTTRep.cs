using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class HDTTRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public HDTTRep()
        {
                
        }
        public List<HoaDonDaThanhToan> GetAll()
        {
            return _context.HoaDonDaThanhToans.ToList();
        }
        public bool AddHD(HoaDonDaThanhToan hddtt)
        {
            try
            {
                _context.HoaDonDaThanhToans.Add(hddtt);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public HoaDonDaThanhToan GetHoaDonById(string hoaDonId)
        {
            return _context.HoaDonDaThanhToans
            .FirstOrDefault(hddtt => hddtt.HoaDonId == hoaDonId);
        }
        public bool XoaHoaDon(string hoaDonId)
        {
            var hoaDon = _context.HoaDonDaThanhToans.FirstOrDefault(hd => hd.HoaDonId == hoaDonId);
            if (hoaDon != null)
            {
                _context.HoaDonDaThanhToans.Remove(hoaDon);
                return _context.SaveChanges() > 0;
            }
            return false;
        }
        public bool KiemTraHoaDonTonTai(string hoaDonId)
        {
            using (var context = new DuAnNhom4Context())
            {
                return context.HoaDonDaThanhToans.Any(hd => hd.HoaDonId == hoaDonId);
            }
        }
    }
}
