    using DAL.Models;
using DAL.Repsitory;
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
        
        public SanPhamService()
        {
            
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
        public List<SanPham> CNTimTenandThuongHIeu(string tensp, string tenTH)
        {
            return _repos.GetSPandTH(tensp, tenTH);
        }
        public string CNthem(int id, string ten, string tenthuonghieu,string mota, decimal gia, int soluong, string kichthuoc,string mausac,string trangthai) {
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
                TrangThai = trangthai
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
        public string CNSua(int id, string ten, string tenthuonghieu, string mota, decimal gia, int soluong, string kichthuoc, string mausac, string trangthai)
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
                TrangThai = trangthai
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

        public SanPham GetById(int spid)
        {
            return _repos.GetById(spid);
        }

    }
}
