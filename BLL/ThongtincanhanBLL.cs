using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ThongtincanhanBLL
    {
        QLLaoDongDataContext db;

        public ThongtincanhanBLL()
        {
            db = new QLLaoDongDataContext();
        }
        public List<eNhanVien> getthongtinNhanVien(string idNV)
        {
            List<NhanVien> list = db.NhanViens.Where(p => p.idNhanVien == idNV).ToList();
            List<eNhanVien> eList = new List<eNhanVien>();
            foreach (NhanVien item in list)
            {
                eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu, item.idPhongBan, (bool)item.isDelete);
                eList.Add(e);
            }
            return eList;
        }
        
    }
}
