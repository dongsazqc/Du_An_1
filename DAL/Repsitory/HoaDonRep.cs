using DAL.Models;
using Microsoft.EntityFrameworkCore;
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
        public List<HoaDon> GetALLHDTT()
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

        public bool UpdateHD(HoaDon hd) //dữ liệu được truyền vào lấy từ form
        {
            try
            {
                var updateitem = _context.HoaDons.Find(hd.HoaDonId);
                updateitem.TenKhachHang = hd.TenKhachHang;
                updateitem.Gmail = hd.Gmail;
                updateitem.TongTien = hd.TongTien;
                updateitem.Gmail = hd.Gmail;
                updateitem.SoDienThoai = hd.SoDienThoai;
                updateitem.TrangThai = hd.TrangThai;
                updateitem.DiaChi = hd.DiaChi;
                updateitem.PhuongThucThanhToan = hd.PhuongThucThanhToan;
                updateitem.NgayLapHoaDon = hd.NgayLapHoaDon;
                _context.HoaDons.Update(updateitem);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

        public HoaDon GetHoaDonById(string hoaDonId)
        {
            using (var context = new DuAnNhom4Context())
            {
                // Lấy hóa đơn từ database theo ID
                return context.HoaDons.SingleOrDefault(hd => hd.HoaDonId == hoaDonId);
            }
        }
        public bool ThanhToanHoaDon(string hoaDonId)
        {
            using (var context = new DuAnNhom4Context())
            {
                var hoaDon = context.HoaDons.SingleOrDefault(hd => hd.HoaDonId == hoaDonId);
                if (hoaDon != null)
                {
                    hoaDon.TrangThai = "Đã thanh toán"; // Cập nhật trạng thái thanh toán
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
