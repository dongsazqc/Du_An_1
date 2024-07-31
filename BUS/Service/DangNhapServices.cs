using DAL.Repsitory;
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

        // Phương thức lấy vai trò của người dùng
        public string GetUserRole(string username)
        {
            return _dangnhaprep.GetUserRole(username);
        }
    }
}
