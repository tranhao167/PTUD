using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CongViecBLL
    {
        QLLaoDongDataContext db;

        public CongViecBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public List<eCongViec> getAllCongViec()
        {
            List<CongViec> list = db.CongViecs.Where(p => p.isDelete == false).ToList();
            List<eCongViec> eList = new List<eCongViec>();

            foreach (CongViec item in list)
            {
                eCongViec e = new eCongViec(item.idCongViec, item.tenCongViec, (bool)item.isDelete);
                eList.Add(e);
            }

            return eList;
        }

        public List<eCongViec> getCongViecByIdCongTrinh(string idCongTrinh)
        {
            List<eCongViec> eList = new List<eCongViec>();

            var query = (from a in db.CongViecs
                         join b in db.DanhSachCongViecCongTrinhs on a.idCongViec equals b.idCongViec
                         where b.idCongTrinh == idCongTrinh
                         select a).ToList();

            foreach(var item in query)
            {
                eCongViec e = new eCongViec(item.idCongViec, item.tenCongViec);
                eList.Add(e);
            }

            return eList;
        }

        public List<eCongViec> getCongViecByIdNhanVien(string idNhanVien)
        {
            List<eCongViec> eList = new List<eCongViec>();

            var query = (from a in db.NhanViens
                         join b in db.DanhSachPhanCongs on a.idNhanVien equals b.idNhanVien
                         join c in db.DanhSachCongViecCongTrinhs on b.idDSCongViecCongTrinh equals c.id
                         join d in db.CongViecs on c.idCongViec equals d.idCongViec
                         join e in db.CongTrinhs on c.idCongTrinh equals e.idCongTrinh
                         where a.idNhanVien == idNhanVien && d.isDelete == false && e.isDelete == false
                         select new { b.id, d.tenCongViec, e.tenCongTrinh }).ToList();

            int i = 1;
            foreach (var item in query)
            {
                eCongViec e = new eCongViec(item.id, item.tenCongViec, item.tenCongTrinh, i++);
                eList.Add(e);
            }

            return eList;
        }

        public List<eNhanVien> getNhanvienbyIDcongviec(string idCongviec)
        {
            List<eNhanVien> eNhanViens = new List<eNhanVien>();
            var query = (from a in db.CongViecs
                         join b in db.DanhSachCongViecCongTrinhs on a.idCongViec equals b.idCongViec
                         join c in db.DanhSachPhanCongs on b.id equals c.idDSCongViecCongTrinh
                         join d in db.NhanViens on c.idNhanVien equals d.idNhanVien
                         where a.idCongViec == idCongviec && d.isDelete == false
                         select new { d.tenNhanVien, d.idNhanVien }).ToList();
            int i = 1;
            foreach(var item in query)
            {
                eNhanVien e = new eNhanVien(item.idNhanVien,item.tenNhanVien, i++);
                eNhanViens.Add(e);
            }
            return eNhanViens;
        }

        public bool themCongViecVaoCongTrinh(string idCongViec,string idCongTrinh)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec && p.idCongTrinh == idCongTrinh).SingleOrDefault();

            if (a == null)
            {
                DanhSachCongViecCongTrinh aa = new DanhSachCongViecCongTrinh();
                aa.idCongTrinh = idCongTrinh;
                aa.idCongViec = idCongViec;

                db.DanhSachCongViecCongTrinhs.InsertOnSubmit(aa);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool xoaCongViecKhoiCongTrinh(string idCongViec, string idCongTrinh)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec && p.idCongTrinh == idCongTrinh).SingleOrDefault();

            if (a != null)
            {
                db.DanhSachCongViecCongTrinhs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getIdCongViecFirst()
        {
            CongViec a = db.CongViecs.ToList().FirstOrDefault();
            return a.idCongViec;
        }

        public string getIdCongViecLast()
        {
            CongViec a = db.CongViecs.ToList().LastOrDefault();
            return a.idCongViec;
        }

        public string idTuDongTang()
        {
            string idLast = getIdCongViecLast();
            string kq = idLast.Substring(2, 4);

            int so = Int32.Parse(kq) + 1;

            if (so < 10)
            {
                return "CV" + "000" + so.ToString();
            }
            else
            {
                if (so >= 10 && so < 100)
                {
                    return "CV" + "00" + so.ToString();
                }
                else
                {
                    if (so >= 100 && so < 1000)
                    {
                        return "CV" + "0" + so.ToString();
                    }
                    else
                    {
                        return "CV" + so.ToString();
                    }
                }
            }
        }

        public bool themCongViec(eCongViec a)
        {
            CongViec aa = new CongViec();
            aa.idCongViec = idTuDongTang();
            aa.idCongViec = a.tenCongViec;
            aa.isDelete = false;

            if (!db.CongViecs.Contains(aa))
            {
                db.CongViecs.InsertOnSubmit(aa);
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool xoaCongViec(string idCongViec)
        {
            CongViec a = db.CongViecs.Where(p => p.idCongViec == idCongViec).SingleOrDefault();

            List<DanhSachCongViecCongTrinh> list = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongViec == idCongViec).ToList();

            if (a != null)
            {
                a.isDelete = true;

                foreach(DanhSachCongViecCongTrinh item in list)
                {
                    db.DanhSachCongViecCongTrinhs.DeleteOnSubmit(item);
                }

                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool capNhatCongViec(eCongViec a)
        {
            CongViec aa = db.CongViecs.Where(p => p.idCongViec == a.idCongViec).SingleOrDefault();

            if (a != null)
            {
                aa.tenCongViec = a.tenCongViec;

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
