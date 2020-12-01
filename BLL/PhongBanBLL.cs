using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class PhongBanBLL
    {
        QLLaoDongDataContext db;

        public PhongBanBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public List<ePhongBan> getAllPhongBan()
        {
            List<PhongBan> list = db.PhongBans.ToList();
            List<ePhongBan> eList = new List<ePhongBan>();

            foreach (PhongBan item in list)
            {
                ePhongBan e = new ePhongBan(item.idPhongBan,item.tenPhongBan);
                eList.Add(e);
            }

            return eList;
        }
        public List<ePhongBan> getArrPhongBan()
        {
            List<ePhongBan> eList = new List<ePhongBan>();
            List<PhongBan> list = db.PhongBans.ToList();
            foreach (PhongBan item in list)
            {
                ePhongBan e = new ePhongBan(item.tenPhongBan);
                eList.Add(e);
            }
            return eList;
        }
        public string getTenPhongBan(string id)
        {
            var idPB = db.PhongBans.FirstOrDefault(p => p.idPhongBan == id);
            if (idPB != null)
            {
                return idPB.tenPhongBan;
            }
            else return "Không tìm thấy";
        }
    }
}
