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
        public bool CNThemHDTT(string hoaDonId ,string tenKH, string DiaC,string Gmail,string soDT)
        {// Kiểm tra hóa đơn có tồn tại không
            HoaDon hoaDon = _repos.GetHoaDonById(hoaDonId);
            if (hoaDon == null)
            {
                return false; // Hóa đơn không tồn tại
            }

            // Cập nhật thông tin hóa đơn
            hoaDon.TenKhachHang = tenKH;
            hoaDon.DiaChi = DiaC;
            hoaDon.Gmail = Gmail;
            hoaDon.SoDienThoai = soDT;

            // Lưu hóa đơn đã cập nhật
            return _repos.UpdateHoaDon(hoaDon);
        }
        public HoaDon GetHoaDonById(string hoaDonId)
        {
                return _repos.GetHoaDonById(hoaDonId);
        }
    }
}
