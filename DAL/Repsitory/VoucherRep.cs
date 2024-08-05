using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class VoucherRep
    {
        DuAnNhom4Context _context = new DuAnNhom4Context();
        public VoucherRep()
        {
           
        }
        public List<Voucher> GetAll()
        {
            return _context.Vouchers.ToList();
        }
        public bool AddSP(Voucher vc)
        {
            try
            {
                _context.Vouchers.Add(vc);
                _context.SaveChanges(); // lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool UpdateSP(Voucher vc) //dữ liệu được truyền vào lấy từ form
        {
            try
            {
                var updateitem = _context.Vouchers.Find(vc.MaVoucher);
                updateitem.TenVoucher = vc.TenVoucher;
                updateitem.TenThuongHieu = vc.TenThuongHieu;
                updateitem.PhanTramGiam = vc.PhanTramGiam;
                updateitem.GiaTri = vc.GiaTri;
                updateitem.DieuKienSuDung = vc.DieuKienSuDung;
                
                _context.Vouchers.Update(updateitem);
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
