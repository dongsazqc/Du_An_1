using DAL.Models;
using DAL.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SPgiamgiaService
    {
        SPgiamgiaRep _Repo = new SPgiamgiaRep();
        public SPgiamgiaService()
        {
            
        }
        public List<SanPhamGiamGium> CNShow()
        {
            return _Repo.GetAll();
        }
    }
}
