using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class SanPhamRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        
        public SanPhamRep()
        {
           _context = new DuAnNhom4Context();
        }
        

        public List<SanPham> GetAll()
        {
            return _context.SanPhams.ToList();
        }
        // lấy sản phẩm theo tên
        public List<SanPham> GetSP(string ten)
        {
            return _context.SanPhams.Where(p=>p.TenSanPham.Contains(ten)).ToList();
        }



        public List<SanPham>GetSPandTH(string tensp , string tenth)
        {
            return _context.SanPhams.Where(a=>a.TenSanPham.Contains(tensp) && a.TenThuongHieu.Contains(tenth)).ToList();
        }


        // thêm 1 sản phẩm mới
        public bool AddSP(SanPham sp) {
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception ) {
                return false;

            }
        }
        // sửa sản phẩm
        public bool UpdateSP(SanPham sp) //dữ liệu được truyền vào lấy từ form
        {
    if (sp == null) // Kiểm tra nếu sp là null
    {
        throw new ArgumentNullException(nameof(sp), "Đối tượng SanPham không thể là null");
    }

    try
    {
                // Tìm sản phẩm trong cơ sở dữ liệu theo ID
                //var updateitem = _context.SanPhams.Find(sp.SanPhamId);
                var updateitem = _context.SanPhams.Find(sp.SanPhamId);

        // Kiểm tra nếu sản phẩm không tồn tại
        if (updateitem == null)
        {
            // Sản phẩm không tìm thấy
            return false;
        }

        // Cập nhật các thuộc tính của sản phẩm
        updateitem.TenSanPham = sp.TenSanPham;
        updateitem.TenThuongHieu = sp.TenThuongHieu;
        updateitem.MoTa = sp.MoTa;
        updateitem.Gia = sp.Gia;
        updateitem.SoLuongTonKho = sp.SoLuongTonKho;
        updateitem.KichThuoc = sp.KichThuoc;
        updateitem.MauSac = sp.MauSac;
        updateitem.TrangThai = sp.TrangThai;

        // Cập nhật đối tượng trong cơ sở dữ liệu
        _context.SanPhams.Update(updateitem);
        _context.SaveChanges(); // Lưu thay đổi
        return true;
    }
    catch (Exception ex)
    {
        // Ghi log lỗi hoặc xử lý lỗi ở đây
        Console.WriteLine($"Lỗi: {ex.Message}");
        return false;
    }

        }
        //xóa 
        public bool deleteSP(int id) //dữ liệu được truyền vào lấy từ form
        {
            try
            {
                var deleteitem = _context.SanPhams.Find(id);
               
                _context.SanPhams.Remove(deleteitem);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
        public void CapNhatSoLuong(int sanPhamId, int soLuongMoi)
        {
            // Lấy sản phẩm theo ID
            var sanPham = _context.SanPhams.FirstOrDefault(sp => sp.SanPhamId == sanPhamId);
            if (sanPham != null)
            {
                // Cập nhật số lượng tồn kho
                sanPham.SoLuongTonKho = soLuongMoi;
                _context.SaveChanges();
            }
        }
        public SanPham GetById(int sanPhamId)
        {
            {
                return _context.SanPhams.FirstOrDefault(sp => sp.SanPhamId == sanPhamId);
            }
        }
    }
}
