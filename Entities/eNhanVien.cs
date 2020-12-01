using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        public String idNhanVien { get; set; }
        public String tenNhanVien { get; set; }
        public String diaChi { get; set; }
        public String sdt { get; set; }
        public int chucVu { get; set; }
        public String idPhongBan { get; set; }
        public bool isDelete { get; set; }
        public int stt { get; set; }

        public eNhanVien(String IdNhanVien,String TenNhanVien,String DiaChi,String Sdt, int ChucVu,String IdPhongBan, bool IsDelete)
        {
            idNhanVien = IdNhanVien;
            tenNhanVien = TenNhanVien;
            diaChi = DiaChi;
            sdt = Sdt;
            chucVu = ChucVu;
            idPhongBan = IdPhongBan;
            isDelete = IsDelete;

        }

        public eNhanVien(String TenNhanVien, String DiaChi, String Sdt, int ChucVu, String IdPhongBan)
        {
            tenNhanVien = TenNhanVien;
            diaChi = DiaChi;
            sdt = Sdt;
            chucVu = ChucVu;
            idPhongBan = IdPhongBan;
        }
        public eNhanVien(String IdNhanVien, String TenNhanVien, String DiaChi, String Sdt)
        {
            idNhanVien = IdNhanVien;
            tenNhanVien = TenNhanVien;
            diaChi = DiaChi;
            sdt = sdt;
        }
        public eNhanVien(String IdNhanVien,String TenNhanVien, int Stt)
        {
            idNhanVien = IdNhanVien;
            tenNhanVien = TenNhanVien;
            stt = Stt;
        }
        public eNhanVien()
        {

        }

    }
}
