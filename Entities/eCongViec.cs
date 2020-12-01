using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCongViec
    {
        public String idCongViec { get; set; }
        public String tenCongViec { get; set; }
        public bool isDelete { get; set; }

        //Trường thuộc tính để hỗ trợ cho việc show dữ liệu cho người dùng
        public String tenCongTrinh { get; set; }
        public int stt { get; set; }
        public int idPhanCong { get; set; }

        public eCongViec(String IdCongViec, String TenCongViec, bool IsDelete)
        {
            idCongViec = IdCongViec;
            tenCongViec = TenCongViec;
            isDelete = IsDelete;
        }

        public eCongViec(String IdCongViec, String TenCongViec)
        {
            idCongViec = IdCongViec;
            tenCongViec = TenCongViec;
        }

        public eCongViec(int IdPhanCong, String TenCongViec,string TenCongTrinh, int Stt)
        {
            idPhanCong = IdPhanCong;
            tenCongViec = TenCongViec;
            tenCongTrinh = TenCongTrinh;
            stt = Stt;
        }

        public eCongViec(String TenCongViec)
        {
            tenCongViec = TenCongViec;
        }


        public eCongViec()
        {

        }
    }
}
