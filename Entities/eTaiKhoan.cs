using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTaiKhoan
    {
        public String idTaiKhoan { get; set; }
        public String matKhau { get; set; }

        public eTaiKhoan(String IdTaiKhoan,String MatKhau)
        {
            idTaiKhoan = IdTaiKhoan;
            matKhau = MatKhau;
        }

        public eTaiKhoan()
        {

        }
    }
}
