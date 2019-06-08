using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBConnect
    {
        protected static SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = Quan ly nha thuoc c#; Integrated Security = True");
        public static void openC()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void closeC()
        {
            try
            {
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

