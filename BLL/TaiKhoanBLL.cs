using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        QLLaoDongDataContext db;

        public TaiKhoanBLL()
        {
            db = new QLLaoDongDataContext();
        }
        public bool DoiMatKhau(string tentaikhoan,string matkhaucu,string matkhaumoi,string xacnhanmatkhau)
        {
            var mkDB = db.TaiKhoans.FirstOrDefault(m =>m.idTaiKhoan==tentaikhoan && m.matKhau == matkhaucu);
            if (mkDB == null)
            {
                return false;
            }
            else
            {
                if (matkhaumoi == xacnhanmatkhau)
                {
                    mkDB.matKhau = matkhaumoi;
                    db.SubmitChanges();
                    return true;
                }
                else return false;
                
            }
        }
    }
}
