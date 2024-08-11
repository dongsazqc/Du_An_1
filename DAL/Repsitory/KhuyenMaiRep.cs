using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class KhuyenMaiRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public KhuyenMaiRep()
        {
           
        }
        public List<KhuyenMai> GetAll()
        {
            return _context.KhuyenMais.ToList();
        }
        // lấy sản phẩm theo tên
        public List<KhuyenMai> GetKM(string ten)
        {
            return _context.KhuyenMais.Where(p => p.TenKhuyenMai.Contains(ten)).ToList();
        }
        public bool AddSP(KhuyenMai km)
        {
            try
            {
                _context.KhuyenMais.Add(km);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        // sửa sản phẩm


    }
}
