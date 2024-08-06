using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HoaDonService
    {
        HoaDonRep _repos = new HoaDonRep();
        public HoaDonService()
        {
            
        }
        public List<HoaDon> CNShowHoaDon()
        {
            return _repos.GetAll();
        }
        public List<HoaDon> CNShowHDTT()
        {
           return _repos.GetALLHDTT();
        }
        public string CNThemHoaDon(string HoaDonID, string Tenkhachhang, string email, string sdt, string diachi)
        {
            HoaDon hd = new HoaDon()
            {
                HoaDonId = HoaDonID,
                TenKhachHang = Tenkhachhang,
                Gmail = email,
                SoDienThoai = sdt,
                DiaChi = diachi
                
            };
            if (_repos.AddHD(hd))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

    }
}
