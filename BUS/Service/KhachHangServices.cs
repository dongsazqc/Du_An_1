﻿using DAL.Models;
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

        public string CNThemOrUpdateKhachHang(string tenKH, string email, string sdt, string diaChi, int diemTichLuy, string capDoThanhVien)
        {
            // Tìm khách hàng dựa trên số điện thoại
            var existingCustomer = _repo.GetKhachHangBySoDienThoai(sdt);

            if (existingCustomer != null)
            {
                // Khách hàng đã tồn tại, cập nhật điểm tích lũy
                int diemTichLuyHienTai = existingCustomer.DiemTichLuy ?? 0  ; // Chuyển đổi từ int? sang int
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
            }
            else
            {
                KhachHang kh = new KhachHang
                {
                    TenKhachHang = tenKH,
                    Email = email,
                    SoDienThoai = sdt,
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



        private string DetermineMembershipLevel(int points)
        {
            if (points >= 50) return "Vàng";

            if (points >= 20) return "Bạc";

            return "Đồng";

        }

        public string CNSua( string tenkhachhang, string email, string sdt,  string diachi)
        {
            KhachHang kh = new KhachHang()
            {
                TenKhachHang = tenkhachhang,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diachi
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

        public KhachHang GetKhachHangBySoDienThoai(string sdt)
        {
            return _repo.GetKhachHangBySoDienThoai(sdt);
        }
    }
}