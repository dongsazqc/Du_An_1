using DAL.Models;
using DAL.Repsitory;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{

    public class SanPhamMuaSer
    {
        
        SanPhamMuaRep _repos = new SanPhamMuaRep();
        public SanPhamMuaSer()
        {
            
        }
        public List<SanPhamMua> CNShowSPmua()
        {
            return _repos.GetAll();
        }
        public string CNThemSPM(string tenSP ,string TenThuongH, int soluong, decimal gia, decimal TongGIa)
        {
            SanPhamMua SPM = new SanPhamMua()
            {
                TenSanPham = tenSP,
                TenThuongHieu = TenThuongH,
                SoLuong = soluong,
                Gia = gia,
                TongGia = TongGIa,

            };
            if (_repos.AddSPM(SPM))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public List<SanPhamMua> GetSanPhamByHoaDonId(string hoaDonId)
        {
            // Gọi phương thức GetSanPhamByHoaDonId từ lớp repository
            return _repos.GetSanPhamByHoaDonId(hoaDonId);
        }
    }
}
