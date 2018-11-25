using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_thuoc:DBConnect
    {
       public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_thuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;
            
        }
    }
}
