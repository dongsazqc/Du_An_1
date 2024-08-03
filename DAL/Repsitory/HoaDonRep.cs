using DAL.Models;
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
                updateitem.PhuongThucThanhToan= hd.PhuongThucThanhToan;
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



    }
}
