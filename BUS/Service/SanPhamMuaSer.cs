﻿using DAL.Models;
using DAL.Repsitory;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{

    public class SanPhamMuaSer
    {
        private readonly string connectionString = "Data Source=PHAM_VAN_DONG;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True";

        SanPhamMuaRep _repos = new SanPhamMuaRep();
        public SanPhamMuaSer()
        {
            
        }
        public List<SanPhamMua> CNShowSPmua()
        {
            return _repos.GetAll();
        }
        public string CNThemSPM(string tenSP ,string TenThuongH, int soluong, decimal gia, decimal TongGIa,string HoadonIdSPM )
        {
            try
            {
                SanPhamMua spm = new SanPhamMua()
                {
                    HoaDonId = HoadonIdSPM,
                    TenSanPham = tenSP,
                    TenThuongHieu = TenThuongH,
                    SoLuong = soluong,
                    Gia = gia,
                    TongGia = gia * soluong,
                };

                bool result = _repos.AddSPM(spm);
                return result ? "Thêm thành công" : "Thêm thất bại";
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi vào log nếu có
                // Log.Error("Lỗi khi thêm sản phẩm mua: " + ex.Message);
                return "Thêm thất bại: " + ex.Message;
            }
        }
        public List<SanPhamMua> GetSanPhamByHoaDonId(string hoaDonId)
        {
            List<SanPhamMua> sanPhamList = new List<SanPhamMua>();

            string query = "SELECT * FROM SanPhamMua WHERE HoaDonID = @HoaDonId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoaDonId", hoaDonId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sanPhamList.Add(new SanPhamMua
                    {
                        TenSanPham = reader["TenSanPham"].ToString(),
                        TenThuongHieu = reader["TenThuongHieu"].ToString(),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        Gia = Convert.ToDecimal(reader["Gia"]),
                        TongGia = Convert.ToDecimal(reader["TongGia"])
                    });
                }
            }

            return sanPhamList;
        }
    }
}
