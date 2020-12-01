using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCongTrinh
    {
        public String idCongTrinh { get; set; }
        public String tenCongTrinh { get; set; }
        public String diaChi { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThucDuKien { get; set; }
        public DateTime ngayHoanThanh { get; set; }
        public String trangThai { get; set; }
        public bool isDelete { get; set; }

        public eCongTrinh(String IdCongTrinh,String TenCongTrinh,String DiaChi, DateTime NgayBatDau,DateTime NgayKetThucDuKien,DateTime NgayHoanThanh, String TrangThai,bool IsDelete)
        {
            idCongTrinh = IdCongTrinh;
            tenCongTrinh = TenCongTrinh;
            diaChi = DiaChi;
            ngayBatDau = NgayBatDau;
            ngayKetThucDuKien = NgayKetThucDuKien;
            ngayHoanThanh = NgayHoanThanh;
            trangThai = TrangThai;
            isDelete = IsDelete;
        }

        public eCongTrinh(String IdCongTrinh, String TenCongTrinh, String DiaChi, DateTime NgayBatDau, DateTime NgayKetThucDuKien, DateTime NgayHoanThanh, String TrangThai)
        {
            idCongTrinh = IdCongTrinh;
            tenCongTrinh = TenCongTrinh;
            diaChi = DiaChi;
            ngayBatDau = NgayBatDau;
            ngayKetThucDuKien = NgayKetThucDuKien;
            ngayHoanThanh = NgayHoanThanh;
            trangThai = TrangThai;
        }

        public eCongTrinh(String TenCongTrinh, String DiaChi, DateTime NgayBatDau, DateTime NgayKetThucDuKien)
        {
            tenCongTrinh = TenCongTrinh;
            diaChi = DiaChi;
            ngayBatDau = NgayBatDau;
            ngayKetThucDuKien = NgayKetThucDuKien;
        }

        public eCongTrinh()
        {

        }
    }
}
