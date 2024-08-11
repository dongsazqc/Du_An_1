    using DAL.Models;
using DAL.Repsitory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SanPhamService
    {
        SanPhamRep _repos = new SanPhamRep();
        DuAnNhom4Context _context = new DuAnNhom4Context();
        
        public SanPhamService()
        {
            
        }
        public bool ThemSanPham(SanPham sanPham)
        {
            // Kiểm tra sản phẩm đã tồn tại dựa trên tên sản phẩm và thương hiệu
            var existingProduct = _repos.GetSPandTH(sanPham.TenSanPham, sanPham.TenThuongHieu);

            if (existingProduct != null && existingProduct.Any())
            {
                // Sản phẩm đã tồn tại, không thêm được
                return false;
            }

            // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào cơ sở dữ liệu

            return true;
        }
        public List<SanPham> CNShow()
        {
            return _repos.GetAll();
        }
        //tìm
        public List<SanPham> CNtim(string ten)
        {
            return _repos.GetSP(ten); 
        }
        public List<SanPham> CNtim2(string tenth)
        {
            return _repos.GetSP(tenth);
        }

        public List<SanPham> CNTimTenandThuongHIeu(string tensp, string tenTH)
        {
            return _repos.GetSPandTH(tensp, tenTH);
        }
        public string CNthem(int id, string ten, string tenthuonghieu,string mota, decimal gia, int soluong, string kichthuoc,string mausac,bool trangthai, DateOnly ngaysx) {
              SanPham sp = new SanPham()
            {
                
                SanPhamId = id,
                TenSanPham = ten,
                TenThuongHieu = tenthuonghieu,
                MoTa = mota,
                Gia = gia,
                SoLuongTonKho = soluong,
                KichThuoc = kichthuoc,
                MauSac = mausac,
                  TrangThai = trangthai.ToString(),
                  NgaySanXuat = ngaysx,
              };
            if (_repos.AddSP(sp))
            {
                return "thêm thành công";
            }
            else {
                return "thêm thất bại";
                   }
        }
        // chức năng sửa
        public string CNSua(int id, string ten, string tenthuonghieu, string mota, decimal gia, int soluong, string kichthuoc, string mausac, bool trangthai, DateOnly ngaysx)
        {
            SanPham sp = new SanPham()
            {
                SanPhamId = id,
                TenSanPham = ten,
                TenThuongHieu = tenthuonghieu,
                MoTa = mota,
                Gia = gia,
                SoLuongTonKho = soluong,
                KichThuoc = kichthuoc,
                MauSac = mausac,
                TrangThai = trangthai.ToString(),
                NgaySanXuat = ngaysx
            };
            if (_repos.UpdateSP(sp))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public string CNxoa(int id)
        {
           
            if (_repos.deleteSP(id))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
           
        }
        public void CapNhatSoLuong(int sanPhamId, int soLuongMoi)
        {
            _repos.CapNhatSoLuong(sanPhamId, soLuongMoi);
        }

        public SanPham CNtIMspTheoID(int spid)
        {
            List<SanPham> spList = _repos.Getsp(spid);

            return spList.FirstOrDefault();
        }
        public List<SanPham> CntimSPTheoTen(string ten)
        {
            return _repos.GetSPtheoTEN(ten);
        }

    }
}
