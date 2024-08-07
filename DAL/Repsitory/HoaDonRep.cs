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
            return _context.HoaDons
            .FirstOrDefault(hd => hd.HoaDonId == hoaDonId);
        }
        public bool UpdateHoaDon(HoaDon hoaDon)
        {
            var existingHoaDon = _context.HoaDons
                .FirstOrDefault(hd => hd.HoaDonId == hoaDon.HoaDonId);

            if (existingHoaDon == null)
            {
                return false; // Hóa đơn không tồn tại
            }

            // Cập nhật các thuộc tính của hóa đơn
            existingHoaDon.TenKhachHang = hoaDon.TenKhachHang;
            existingHoaDon.DiaChi = hoaDon.DiaChi;
            existingHoaDon.Gmail = hoaDon.Gmail;
            existingHoaDon.SoDienThoai = hoaDon.SoDienThoai;

            // Lưu thay đổi
            _context.SaveChanges();
            return true;
        }
    }
}
