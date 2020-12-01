using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class NhanVienBLL
    {
        QLLaoDongDataContext db;

        public NhanVienBLL()
        {
            db = new QLLaoDongDataContext();
        }
        public List<eNhanVien> getAllNhanVien()
        {
            List<NhanVien> list = db.NhanViens.Where(p => p.isDelete == false).ToList();
            List<eNhanVien> eList = new List<eNhanVien>();

            foreach (NhanVien item in list)
            {
                //string a = item.idNhanVien;
                eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu,item.idPhongBan, (bool)item.isDelete);
                eList.Add(e);
            }

            return eList;
        }
        public List<eNhanVien> getthongtinnvByID(string idNV)
        {
            List<NhanVien> list = db.NhanViens.Where(p => p.idNhanVien == idNV).ToList();
            List<eNhanVien> eList = new List<eNhanVien>();
            foreach(NhanVien item in list)
            {
                eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu, item.idPhongBan, (bool)item.isDelete);
                eList.Add(e);
            }
            return eList;
        }
        public string gettenPhongBan(string idPB)
        {
            var nhanViens = db.PhongBans.FirstOrDefault(p => p.idPhongBan == idPB);
            if (nhanViens != null)
            {
                return nhanViens.tenPhongBan;
            }
            return null;
        }
        public List<eNhanVien> timdsnhanvientheophongban(string tenpb)
        {
            PhongBan tenpbfinded = db.PhongBans.Where(a => a.tenPhongBan.ToLower().Contains(tenpb.ToLower())).FirstOrDefault();
            string idphongBan = tenpbfinded.idPhongBan;
            List<NhanVien> nhanViens = db.NhanViens.Where(a => a.idPhongBan == idphongBan).ToList();
            if (nhanViens != null)
            {
                List<eNhanVien> eNhanViens = new List<eNhanVien>();
                foreach (NhanVien item in nhanViens)
                {
                    eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu, item.idPhongBan, (bool)item.isDelete);
                    eNhanViens.Add(e);
                }
                return eNhanViens;
            }
            else return null;
         
        }
        public List<eNhanVien> getNhanVienByIdPhongBan(string idPhongBan)
        {
            List<NhanVien> list = db.NhanViens.Where(p => p.idPhongBan == idPhongBan && p.chucVu == 1).ToList();
            List<eNhanVien> eList = new List<eNhanVien>();

            foreach (NhanVien item in list)
            {
                eNhanVien e = new eNhanVien(item.idNhanVien, item.tenNhanVien, item.diaChi, item.sdt, item.chucVu, item.idPhongBan, (bool)item.isDelete);
                eList.Add(e);
            }

            return eList;
        }
        //CHỨC NĂNG CHO QUẢN LÝ
        public bool themNhanVien(eNhanVien eNhanVien)
        {
            NhanVien nv = new NhanVien();
            nv.idNhanVien = idTuDongTang();
            nv.tenNhanVien = eNhanVien.tenNhanVien;
            nv.diaChi = eNhanVien.diaChi;
            nv.sdt = eNhanVien.sdt;
            nv.chucVu = eNhanVien.chucVu;
            nv.idPhongBan = eNhanVien.idPhongBan;
            nv.isDelete = false;
            
            if (!db.NhanViens.Contains(nv))
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }

            return false;
        }
        public bool capnhatNhanVien(eNhanVien eNhanVien)
        {
            NhanVien nhanVien = db.NhanViens.Where(p => p.idNhanVien == eNhanVien.idNhanVien).SingleOrDefault();

            if (eNhanVien != null)
            {
                nhanVien.tenNhanVien = eNhanVien.tenNhanVien;
                nhanVien.diaChi = eNhanVien.diaChi;
                nhanVien.sdt = eNhanVien.sdt;
                nhanVien.chucVu = eNhanVien.chucVu;
                nhanVien.idPhongBan = eNhanVien.idPhongBan;
                nhanVien.isDelete = eNhanVien.isDelete;

                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool xoaNhanVien(string idNV)
        {
            NhanVien nv = db.NhanViens.Where(p => p.idNhanVien == idNV).SingleOrDefault();

            if (nv != null)
            {
                nv.isDelete = true;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool phanCongNhanVien(string idNhanVien,string idCongTrinh,string idCongViec)
        {
            DanhSachCongViecCongTrinh a = db.DanhSachCongViecCongTrinhs.Where(p => p.idCongTrinh == idCongTrinh && p.idCongViec == idCongViec).SingleOrDefault();

            DanhSachPhanCong aa = db.DanhSachPhanCongs.Where(p => p.idDSCongViecCongTrinh == a.id && p.idNhanVien == idNhanVien).SingleOrDefault();

            if(aa == null)
            {
                DanhSachPhanCong aaa = new DanhSachPhanCong();
                aaa.idDSCongViecCongTrinh = a.id;
                aaa.idNhanVien = idNhanVien;

                db.DanhSachPhanCongs.InsertOnSubmit(aaa);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool xoaPhanCongCongViec(int idPhanCong)
        {
            DanhSachPhanCong a = db.DanhSachPhanCongs.Where(p => p.id == idPhanCong).SingleOrDefault();

            if(a != null)
            {
                db.DanhSachPhanCongs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //KẾT THÚC CHỨC NĂNG CHO QUẢN LÝ

        //CHỨC NĂNG CHO NHÂN VIÊN
        
        //KẾT THÚC CHỨC NĂNG CHO NHÂN VIÊN

        //CHỨC NĂNG CHO CHẤM CÔNG
        public string getTenNhanVienByID(string tenNV)
        {
            var ten = db.NhanViens.FirstOrDefault(p => p.tenNhanVien == tenNV);
            if (ten != null)
            {
                return ten.idNhanVien;
            }
            else return "";
        }
        public bool chamCongNhanVienCoMat(string idNhanVien, string idCongTrinh)
        {
            CongTrinh congTrinh = db.CongTrinhs.FirstOrDefault(p => p.idCongTrinh == idCongTrinh);
            NhanVien nhanVien = db.NhanViens.FirstOrDefault(a => a.idNhanVien == idNhanVien);
            DanhSachChamCong danhSachChamCong = db.DanhSachChamCongs.FirstOrDefault(cc => cc.idNhanVien == idNhanVien && cc.idCongTrinh == idCongTrinh);
            if (danhSachChamCong == null)
            {
                
                DanhSachChamCong aaa = new DanhSachChamCong();
                aaa.idNhanVien = nhanVien.idNhanVien;
                aaa.idCongTrinh = congTrinh.idCongTrinh;
                aaa.ngayChamcong = DateTime.Now;
                aaa.trangThaiChamCong = true;

                db.DanhSachChamCongs.InsertOnSubmit(aaa);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool chamCongNhanVienVang(string idNhanVien, string idCongTrinh)
        {
            CongTrinh congTrinh = db.CongTrinhs.FirstOrDefault(p => p.idCongTrinh == idCongTrinh);
            NhanVien nhanVien = db.NhanViens.FirstOrDefault(a => a.idNhanVien == idNhanVien);
            DanhSachChamCong danhSachChamCong = db.DanhSachChamCongs.FirstOrDefault(cc => cc.idNhanVien == idNhanVien && cc.idCongTrinh == idCongTrinh);
            if (danhSachChamCong == null)
            {
                DanhSachChamCong aaa = new DanhSachChamCong();
                aaa.idNhanVien = nhanVien.idNhanVien;
                aaa.idCongTrinh = congTrinh.idCongTrinh;
                aaa.ngayChamcong = DateTime.Now;
                aaa.trangThaiChamCong = false;

                db.DanhSachChamCongs.InsertOnSubmit(aaa);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        //KẾT THÚC CHỨC NĂNG CHẤM CÔNG
        public string getIdNhanVienLast()
        {
            NhanVien a = db.NhanViens.ToList().LastOrDefault();
            return a.idNhanVien;
        }
        public string idTuDongTang()
        {
            string idLast = getIdNhanVienLast();
            string kq = idLast.Substring(2, 4);

            int so = Int32.Parse(kq) + 1;

            if (so < 10)
            {
                return "NV" + "000" + so.ToString();
            }
            else
            {
                if (so >= 10 && so < 100)
                {
                    return "NV" + "00" + so.ToString();
                }
                else
                {
                    if (so >= 100 && so < 1000)
                    {
                        return "NV" + "0" + so.ToString();
                    }
                    else
                    {
                        return "NV" + so.ToString();
                    }
                }
            }
        }
    }
}
