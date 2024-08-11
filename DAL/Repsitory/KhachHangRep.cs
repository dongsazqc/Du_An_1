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

        //lấy ra tất cả danh sách giảng viên
        public List<KhachHang> GetAll()
        {
            return _context.KhachHangs.ToList();
        }

        //lấy ra khách hàng theo tên 
        public List<KhachHang> GetKH(string ten)
        {
            return _context.KhachHangs.Where(p => p.TenKhachHang.Contains(ten) || p.SoDienThoai.Contains(ten)).ToList();   //chứa tên
        }

        public KhachHang GetKhachHangBySoDienThoai(string soDienThoai)
        {
            return _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == soDienThoai);
        }
        //Thêm KH
        public bool AddKH(KhachHang kh)
        {
            try
            {
                _context.KhachHangs.Add(kh);
                _context.SaveChanges(); // Lưu lại
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Sửa KH
        public bool Update(KhachHang kh)  //Dữ liệu được truyền vào từ form
        {
            try
            {
                //lấy ra đối tượng để sửa
                var updateItem = _context.KhachHangs.Find(kh.KhachHangId);
                // sau khi đã tìm ra ta đi gán giá trị mới cho các thuộc tính
                updateItem.TenKhachHang = kh.TenKhachHang;
                updateItem.SoDienThoai = kh.SoDienThoai;
                updateItem.Email = kh.Email;
                updateItem.DiaChi = kh.DiaChi;
                updateItem.DiemTichLuy = kh.DiemTichLuy;
                updateItem.CapDoThanhVien = kh.CapDoThanhVien;
                _context.KhachHangs.Update(updateItem);
                _context.SaveChanges(); //lưu lại
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Xóa
        public bool Delete(int makh)  //Dữ liệu được truyền vào từ form
        {
            try
            {
                //lấy ra đối tượng để sửa
                var deleteItem = _context.KhachHangs.Find(makh);
                // sau khi đã tìm ra ta đi gán giá trị mới cho các thuộc tính
                _context.KhachHangs.Remove(deleteItem);
                _context.SaveChanges(); //lưu lại
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
