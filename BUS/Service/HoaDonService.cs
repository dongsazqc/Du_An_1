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
        public List<HoaDon> CNShowHDThanhToan()
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
        public bool ThanhToanHoaDon(string hoaDonId)
        {
            // Lấy hóa đơn theo ID
            var hoaDon = _repos.GetHoaDonById(hoaDonId);

            if (hoaDon != null)
            {
                // Cập nhật trạng thái thanh toán của hóa đơn
                return _repos.ThanhToanHoaDon(hoaDonId);
            }
            return false;
        }
        public List<HoaDon> CNShowHDTT()
        {
            using (var context = new DuAnNhom4Context())
            {
                // Trả về danh sách hóa đơn đã thanh toán
                return context.HoaDons.Where(hd => hd.TrangThai == "Đã thanh toán").ToList();
            }
        }
    }
}
