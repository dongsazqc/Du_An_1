using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class KhuyenMaiServies
    {
        KhuyenMaiRep _Repos = new KhuyenMaiRep();
        public KhuyenMaiServies()
        {

        }
        public List<KhuyenMai> CNShow()
        {
            return _Repos.GetAll();
        }
        //tìm
        public List<KhuyenMai> CNtim(string ten)
        {
            return _Repos.GetKM(ten);
        }
        public string CNthem(int idkm, string tenkm, string mota,  decimal giamgia)
        {
            KhuyenMai sp = new KhuyenMai()
            {

                KhuyenMaiId = idkm,
                TenKhuyenMai = tenkm,
                GiamGia = giamgia,
                MoTa = mota,
               
            };
            if (_Repos.AddSP(sp))
            {
                return "thêm thành công";
            }
            else
            {
                return "thêm thất bại";
            }
        }
    }
}
