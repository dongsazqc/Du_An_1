using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repsitory
{
    public class DangNhapRep
    {
        
            private string ketnoi = "Data Source=DUONG;Initial Catalog=Du_An_Nhom4;User ID=sa;Password=123456;TrustServerCertificate=True";

            public bool ValidateUser(string username, string password)
            {
                using (SqlConnection conn = new SqlConnection(ketnoi))
                {
                    string query = "SELECT COUNT(1) FROM NguoiDung WHERE TenDangNhap = @Username AND MatKhauMaHoa = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
            }

            public string GetUserRole(string username)
            {
                using (SqlConnection conn = new SqlConnection(ketnoi))
                {
                    string query = "SELECT VaiTro FROM NguoiDung WHERE TenDangNhap = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    conn.Open();
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        
    }
}
