using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_nhanvien
    {
        private DAL_nhanvien nv = new DAL_nhanvien();
        public int dangNhap(string id, string pass)
        {

            return nv.dangNhap(id,pass);
        }
    }
}
