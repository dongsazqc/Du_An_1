using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SanPhamService
    {
        SanPhamRep _repos = new SanPhamRep();
        public SanPhamService()
        {
            
        }
        public List<SanPham> CNShow()
        {
            return _repos.GetAll();
        }
    }
}
