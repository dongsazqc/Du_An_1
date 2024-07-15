using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class KhachHangServices
    {
        KhachHangRep _repo = new KhachHangRep();

        public KhachHangServices()
        {
            _repo = new KhachHangRep();
        }

        public List<KhachHang> CNShow()
        {
            return _repo.GetAll();
        }

        public List<KhachHang> CNTim(string ten)
        {
            return _repo.GetCH(ten);
        }

        public string CNThem(int id, string tenkkhachhang, string email, string sodienthoai, string diachi)
        {
            KhachHang kh = new KhachHang()
            { 
                KhachHangId = id,
                TenKhachHang = tenkkhachhang,
                Email = email,
                SoDienThoai = sodienthoai,
                DiaChi = diachi
            };

            if (_repo.AddKH(kh))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";

        }

        public string CNSua(int id, string tenkkhachhang, string email, string sodienthoai, string diachi)
        {
            KhachHang kh = new KhachHang()
            {
                KhachHangId = id,
                TenKhachHang = tenkkhachhang,
                Email = email,
                SoDienThoai = sodienthoai,
                DiaChi = diachi
            };

            if (_repo.updateKH(kh))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";

        }

        public string CNXoa(string ma)
        {

            if (_repo.DeleteKH(ma))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";

        }

        public bool checkDT(string dt)
        {
            if(dt.Length > 10  || dt.Trim().Length ==0) return false;
            else return true;
        }
    }
}
