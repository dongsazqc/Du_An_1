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

        //các phương thức

        public List<KhachHang> CNShow()
        {
            return _repo.GetAll();  //vì phương thức GetAll cũng trả về list mình cần 
        }

        //tìm
        public List<KhachHang> CNTim(string id)
        {
            return _repo.GetKH(id);
        }

        public string CNThem(int Khanhhangid, string tenkhachhang, string email, string sdt, string diachi)
        {
            KhachHang kh = new KhachHang()
            {
                KhachHangId = Khanhhangid,
                TenKhachHang = tenkhachhang,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diachi,
          
            };
            if (_repo.AddKH(kh))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CNSua(int Khanhhangid, string tenkhachhang, string email, string sdt, string diachi)
        {
            KhachHang kh = new KhachHang()
            {
                KhachHangId = Khanhhangid,
                TenKhachHang = tenkhachhang,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diachi
                
            };
            if (_repo.Update(kh))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }


        //public string CNXoa(int Khanhhangid)
        //{
        //    if (_repo.Delete(Khanhhangid))
        //    {
        //        return "Xóa thành công";
        //    }
        //    else
        //    {
        //        return "Xóa thất bại";
        //    }
        //}

        public bool CheckSDT(string sdt)
        {
            if (sdt.Length > 10 || sdt.Trim().Length == 0) return false;
            else return true;
        }
    }
}
