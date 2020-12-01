using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class AuthBLL
    {
        QLLaoDongDataContext db;

        public AuthBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public int XuLyDangNhap(string tenTK,string matKhau)
        {
            TaiKhoan tk = db.TaiKhoans.Where(a => a.idTaiKhoan == tenTK).SingleOrDefault();

            if(tk == null)
            {
                return 0; //tài khoản không tồn tại
            }
            else
            {
                if(tk.matKhau != matKhau)
                {
                    return 1; // mật khẩu không chính xác
                }
                else
                {
                    return 2; // tài khoản hợp lệ
                }
            }
        }

    }
}
