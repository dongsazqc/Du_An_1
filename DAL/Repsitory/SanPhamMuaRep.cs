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
        public List<SanPhamMua> GetAll()
        {
            return _context.SanPhamMuas.ToList();
        }
        public bool AddSPM(SanPhamMua spm)
        {
            try
            {
                using (var context = new DuAnNhom4Context()) // Hoặc bất kỳ DbContext nào của bạn
                {
                    context.SanPhamMuas.Add(spm);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi vào log nếu có
                // Log.Error("Lỗi khi thêm sản phẩm mua vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
        public List<SanPhamMua> GetSanPhamByHoaDonId(string hoaDonId)
        {
            return _context.SanPhamMuas
                            .Where(sp => sp.HoaDonId == hoaDonId) // Giả sử có thuộc tính HoaDonId trong SanPhamMua
                            .ToList();
        }

        public bool ThemSanPhamMuas(IEnumerable<SanPhamMua> sanPhamMuas)
        {
            try
            {
                _context.SanPhamMuas.AddRange(sanPhamMuas);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

    }
}
