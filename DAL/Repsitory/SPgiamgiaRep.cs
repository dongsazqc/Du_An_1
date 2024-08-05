using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class SPgiamgiaRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public SPgiamgiaRep()
        {
            _context = new DuAnNhom4Context();
        }
        public List<SanPhamGiamGium> GetAll()
        {
            return _context.SanPhamGiamGia.ToList();
        }
        // lấy sản phẩm theo tên

        // thêm sản phẩm
        public bool AddSP(SanPhamGiamGium spgg)
        {
            try
            {
                _context.SanPhamGiamGia.Add(spgg);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool UpdateSP(SanPhamGiamGium spgg) //dữ liệu được truyền vào lấy từ form
        {
            try
            {
                var updateitem = _context.SanPhamGiamGia.Find(spgg.MaSanPham);
                updateitem.TenSanPham = spgg.TenSanPham;
                updateitem.GiaBan = spgg.GiaBan;
                updateitem.PhanTramGiam = spgg.PhanTramGiam;
                updateitem.GiaGiam = spgg.GiaGiam;
                updateitem.NgayBatDauGiamGia = spgg.NgayBatDauGiamGia;
                updateitem.NgayKetThucGiamGia = spgg.NgayKetThucGiamGia;
                updateitem.MoTa = spgg.MoTa;
                
                _context.SanPhamGiamGia.Update(updateitem);
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
