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
        public bool AddSP(Voucher vc)
        {
            try
            {
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
