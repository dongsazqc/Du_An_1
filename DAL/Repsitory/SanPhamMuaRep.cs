using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
   
    public class SanPhamMuaRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public SanPhamMuaRep()
        {
            
        }
        public void ThemChiTietSP(string tenSanPham, string tenThuongHieu, decimal gia, decimal tongGia,int soluong)
        {
            using (var context = new  DuAnNhom4Context())
            {
                // Tạo đối tượng ChiTietSanPham
                var chiTietSanPham = new SanPhamMua
                {
                    TenSanPham = tenSanPham,
                    TenThuongHieu = tenThuongHieu,
                    Gia = gia,
                    TongGia = tongGia,
                    SoLuong = soluong, // Giả sử mỗi sản phẩm thêm vào có số lượng 1, bạn có thể thay đổi theo yêu cầu
                };

                // Thêm đối tượng vào cơ sở dữ liệu
                context.SanPhamMuas.Add(chiTietSanPham);
            }
        }
    }
}
