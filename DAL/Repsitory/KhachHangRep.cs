using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class KhachHangRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public KhachHangRep()
        {
            _context = new DuAnNhom4Context();
        }
        public List<KhachHang> GetAll()
        {
            return _context.KhachHangs.ToList();
        }
        public List<KhachHang> GetCH(string ten)
        {
            return _context.KhachHangs.Where(p => p.TenKhachHang == ten).ToList();
        }

        public bool AddKH(KhachHang ch)
        {
            try
            {
                _context.KhachHangs.Add(ch);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateKH(KhachHang kh)
        {
            try
            {
                var updateItem = _context.KhachHangs.Find(kh.TenKhachHang);
                updateItem.TenKhachHang = kh.TenKhachHang;
                updateItem.Email = kh.Email;
                updateItem.SoDienThoai = kh.SoDienThoai;
                updateItem.DiaChi = kh.DiaChi;

                _context.KhachHangs.Update(kh);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteKH(string maKH)
        {
            try
            {
                var deleteItem = _context.KhachHangs.Find(maKH);

                _context.KhachHangs.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
