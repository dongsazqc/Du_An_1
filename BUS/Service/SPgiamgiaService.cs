using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SPgiamgiaService
    {
        SPgiamgiaRep _Repo = new SPgiamgiaRep();
        public SPgiamgiaService()
        {
            
        }
        public List<SanPhamGiamGium> CNShow()
        {
            return _Repo.GetAll();
        }
        public string CNthem(int masanpham, string tensanpham, decimal giaban, decimal phantramgiam, decimal giagiam, DateOnly ngaybd,DateOnly ngaykt, string mota)
        {
            SanPhamGiamGium spgg = new SanPhamGiamGium()
            {

                MaSanPham = masanpham,
                TenSanPham = tensanpham,
                GiaBan = giaban,
                MoTa = mota,
                GiaGiam = giagiam,
                PhanTramGiam  = phantramgiam,
                NgayBatDauGiamGia=ngaybd,
                NgayKetThucGiamGia = ngaykt,
                 
            };
            if (_Repo.AddSP(spgg))
            {
                return "thêm thành công";
            }
            else
            {
                return "thêm thất bại";
            }
        }
        public string CNSua(int masanpham, string tensanpham, decimal giaban, decimal phantramgiam, decimal giagiam, DateOnly ngaybd, DateOnly ngaykt,  string mota)
        {
            SanPhamGiamGium spgg = new SanPhamGiamGium()
            {

                MaSanPham = masanpham,
                TenSanPham = tensanpham,
                GiaBan = giaban,
                MoTa = mota,
                GiaGiam = giagiam,
                PhanTramGiam = phantramgiam,
                NgayBatDauGiamGia = ngaybd,
                NgayKetThucGiamGia = ngaykt

            };
            if (_Repo.UpdateSP(spgg))
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
