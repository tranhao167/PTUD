using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhongBan
    {
        public String idPhongBan { get; set; }
        public String tenPhongBan { get; set; }

        public ePhongBan(String IdPhongBan,String TenPhongBan)
        {
            idPhongBan = IdPhongBan;
            tenPhongBan = TenPhongBan;
        }
        public ePhongBan(String TenPhongBan)
        {
            tenPhongBan = TenPhongBan;
        }
        public ePhongBan()
        {

        }
    }
}
