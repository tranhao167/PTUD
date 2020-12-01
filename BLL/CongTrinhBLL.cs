using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CongTrinhBLL
    {
        QLLaoDongDataContext db;

        public CongTrinhBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public List<eCongTrinh> getAllCongTrinh()
        {
            List<CongTrinh> list = db.CongTrinhs.Where(p => p.isDelete == false).ToList();
            List<eCongTrinh> eList = new List<eCongTrinh>();

            foreach (CongTrinh item in list)
            {
                string a = item.idCongTrinh;
                eCongTrinh e = new eCongTrinh(item.idCongTrinh, item.tenCongTrinh, item.diaChi, (DateTime)item.ngayBatDau, (DateTime)item.ngayKetThucDuKien, (DateTime)item.ngayHoanThanh, item.trangThai, (bool)item.isDelete);
                eList.Add(e);
            }

            return eList;
        }

        public string getIdCongTrinhFirst()
        {
            CongTrinh a = db.CongTrinhs.ToList().FirstOrDefault();
            return a.idCongTrinh;
        }

        public string getIdCongTrinhLast()
        {
            CongTrinh a = db.CongTrinhs.ToList().LastOrDefault();
            return a.idCongTrinh;
        }

        public string idTuDongTang()
        {
            string idLast = getIdCongTrinhLast();
            string kq = idLast.Substring(2, 4);

            int so = Int32.Parse(kq) + 1;

            if (so < 10)
            {
                return "CT" + "000" + so.ToString();
            }
            else
            {
                if (so >= 10 && so < 100)
                {
                    return "CT" + "00" + so.ToString();
                }
                else
                {
                    if (so >= 100 && so < 1000)
                    {
                        return "CT" + "0" + so.ToString();
                    }
                    else
                    {
                        return "CT" + so.ToString();
                    }
                }
            }
        }

        public bool themCongTrinh(eCongTrinh a)
        {
            CongTrinh aa = new CongTrinh();
            aa.idCongTrinh = idTuDongTang();
            aa.tenCongTrinh = a.tenCongTrinh;
            aa.diaChi = a.diaChi;
            aa.ngayBatDau = (DateTime)a.ngayBatDau;
            aa.ngayKetThucDuKien = (DateTime)a.ngayKetThucDuKien;
            aa.ngayHoanThanh = new DateTime(1900, 1, 1);
            aa.trangThai = "Đang Thực Hiện";
            aa.isDelete = false;

            if (!db.CongTrinhs.Contains(aa))
            {
                db.CongTrinhs.InsertOnSubmit(aa);
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool xoaCongTrinh(string idCongTrinh)
        {
            CongTrinh a = db.CongTrinhs.Where(p => p.idCongTrinh == idCongTrinh).SingleOrDefault();

            if (a != null)
            {
                a.isDelete = true;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool capNhatCongTrinh(eCongTrinh a)
        {
            CongTrinh aa = db.CongTrinhs.Where(p => p.idCongTrinh == a.idCongTrinh).SingleOrDefault();

            if(a != null)
            {
                aa.tenCongTrinh = a.tenCongTrinh;
                aa.diaChi = a.diaChi;
                aa.ngayBatDau = (DateTime)a.ngayBatDau;
                aa.ngayKetThucDuKien = (DateTime)a.ngayKetThucDuKien;
                aa.ngayHoanThanh = (DateTime)a.ngayHoanThanh;
                aa.trangThai = a.trangThai;

                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
