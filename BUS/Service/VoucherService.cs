using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class VoucherService
    {
        VoucherRep _Repos = new VoucherRep();
        public VoucherService()
        {

        }
        public List<Voucher> CNShow() {

            return _Repos.GetAll();

        }
        public string CNthem(int idvc, string tenvc, string tenthuonghieu, decimal phantram, decimal gia,  string dieukien)
        {
            Voucher vc = new Voucher()
            {

                MaVoucher = idvc,
                TenVoucher = tenvc,
                TenThuongHieu = tenthuonghieu,
                PhanTramGiam = phantram,
                GiaTri = gia,
               
                DieuKienSuDung = dieukien,
                
            };
            if (_Repos.AddSP(vc))
            {
                return "thêm thành công";
            }
            else
            {
                return "thêm thất bại";
            }
        }
        public string CNsua(int idvc, string tenvc, string tenthuonghieu, decimal phantram, decimal gia,  string dieukien)
        {
            Voucher vc = new Voucher()
            {

                MaVoucher = idvc,
                TenVoucher = tenvc,
                TenThuongHieu = tenthuonghieu,
                PhanTramGiam = phantram,
                GiaTri = gia,
                
                DieuKienSuDung = dieukien,

            };
            if (_Repos.UpdateSP(vc))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

    }
}
