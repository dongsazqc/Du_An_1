using DAL.Models;
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
            try
            {
                var updateitem = _context.SanPhams.Find(sp.SanPhamId);
                updateitem.TenSanPham = sp.TenSanPham;
                updateitem.TenThuongHieu = sp.TenThuongHieu;
                updateitem.MoTa = sp.MoTa;
                updateitem.Gia = sp.Gia;
                updateitem.SoLuongTonKho = sp.SoLuongTonKho;
                updateitem.KichThuoc = sp.KichThuoc;
                updateitem.MauSac = sp.MauSac;
                updateitem.TrangThai = sp.TrangThai;
                _context.SanPhams.Update(updateitem);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
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
    }
}
