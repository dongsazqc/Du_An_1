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

<<<<<<< HEAD
        public string CNThemOrUpdateKhachHang(string tenKH, string sdt, string email, string diaChi, int diemTichLuy, string capDoThanhVien)
=======
<<<<<<< HEAD
        public string CNThem(int Khanhhangid, string tenkhachhang, string email, string sdt, string diachi)
=======
        public string CNThemOrUpdateKhachHang(string tenKH, string email, string sdt, string diaChi, int diemTichLuy, string capDoThanhVien)
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
>>>>>>> 0d9e37deb638c4f8394010932271075c14b18377
        {
            // Tìm khách hàng dựa trên số điện thoại
            var existingCustomer = _repo.GetKhachHangBySoDienThoai(sdt);

            if (existingCustomer != null)
            {
<<<<<<< HEAD
                KhachHangId = Khanhhangid,
                TenKhachHang = tenkhachhang,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diachi,
          
            };
            if (_repo.AddKH(kh))
            {
                return "Thêm thành công";
=======
                // Khách hàng đã tồn tại, cập nhật điểm tích lũy
                int diemTichLuyHienTai = existingCustomer.DiemTichLuy ?? 0; // Chuyển đổi từ int? sang int
                diemTichLuyHienTai += diemTichLuy; // Cộng dồn điểm tích lũy
                existingCustomer.DiemTichLuy += diemTichLuy; // Cộng dồn điểm tích lũy
                // Tính lại cấp độ thành viên dựa trên điểm tích lũy mới
                existingCustomer.CapDoThanhVien = DetermineMembershipLevel(diemTichLuyHienTai);


                if (_repo.Update(existingCustomer))
                {
                    return "Cập nhật điểm thành công";
                }
                else
                {
                    return "Cập nhật điểm thất bại";
                }
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
            }
            else
            {
                // Khách hàng mới, tạo mới
                KhachHang kh = new KhachHang
                {
                    TenKhachHang = tenKH,
                    SoDienThoai = sdt,
                    Email = email,
                    DiaChi = diaChi,
                    DiemTichLuy = diemTichLuy,
                    CapDoThanhVien = capDoThanhVien
                };

                if (_repo.AddKH(kh))
                {
                    return "Thêm khách hàng thành công";
                }
                else
                {
                    return "Thêm khách hàng thất bại";
                }
            }
        }
<<<<<<< HEAD
=======

<<<<<<< HEAD
=======
>>>>>>> 0d9e37deb638c4f8394010932271075c14b18377
        private string DetermineMembershipLevel(int points)
        {
            if (points >= 50) return "Vàng";

            if (points >= 20) return "Bạc";

            return "Đồng";

        }

<<<<<<< HEAD
        public string CNSua(int Khanhhangid, string tenkhachhang, string sdt, string email, string diachi)
=======
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
        public string CNSua(int Khanhhangid, string tenkhachhang, string email, string sdt, string diachi)
>>>>>>> 0d9e37deb638c4f8394010932271075c14b18377
        {
            KhachHang kh = new KhachHang()
            {
                KhachHangId = Khanhhangid,
                TenKhachHang = tenkhachhang,
                SoDienThoai = sdt,
                Email = email,
                DiaChi = diachi
<<<<<<< HEAD
                
=======
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
            };
            if (_repo.Update(kh))
            {
                return "Sửa khách hàng thành công";
            }
            else
            {
                return "Sửa khách hàng thất bại";
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
