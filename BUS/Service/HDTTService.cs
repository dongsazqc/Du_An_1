using DAL.Models;
using DAL.Repsitory;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HDTTService
    {
        HDTTRep _repos = new HDTTRep();
        public HDTTService()
        {
            
        }
        public List<HoaDonDaThanhToan> CNShowHoaDonThanhToan()
        {
            return _repos.GetAll();
        }
        public string CNThemHoaDonThanhToan(string HoaDonID, string Tenkhachhang, string email, string sdt, string diachi)
        {
            HoaDonDaThanhToan hd = new HoaDonDaThanhToan()
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
        public HoaDonDaThanhToan GetHoaDonById(string hoaDonId)
        {
            return _repos.GetHoaDonById(hoaDonId);
        }

        public bool CNXoaHoaDon(string hoaDonId)
        {
            // Giả sử bạn có một phương thức trong dịch vụ để xóa hóa đơn khỏi cơ sở dữ liệu
            return _repos.XoaHoaDon(hoaDonId);
        }

        public bool KiemTraHoaDonTonTai(string hoaDonId)
        {
            return _repos.KiemTraHoaDonTonTai(hoaDonId);
        }
    }
}
