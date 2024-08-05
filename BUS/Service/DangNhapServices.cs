using DAL.Models;
using DAL.Repsitory;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Repsitory.DangNhapRep;

namespace BUS.Service
{
    public class DangNhapServices
    {
        DangNhapRep _dangnhaprep = new DangNhapRep();

        // Phương thức xác thực người dùng
        public bool ValidateUser(string username, string password)
        {
            return _dangnhaprep.ValidateUser(username, password);
        }
        private string connectionString = "Data Source=DUONG;Initial Catalog=Du_An_Nhom4;User ID=sa;Password=123456;TrustServerCertificate=True";

        public List<NguoiDung> GetNguoiDungByEmail(string email)
        {
            List<NguoiDung> nguoiDungs = new List<NguoiDung>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM NguoiDung WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NguoiDung nguoiDung = new NguoiDung
                            {
                                Email = reader["Email"].ToString(),
                                MatKhauMaHoa = reader["MatKhauMaHoa"].ToString()
                            };
                            nguoiDungs.Add(nguoiDung);
                        }
                    }
                }
            }

            return nguoiDungs;
        }

    }
}
