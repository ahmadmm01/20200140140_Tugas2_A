using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140140_Tugas2_A
{
    class Program
    {
        public void SQLServer()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source= MADD\\AHMADMM; database=Kontrak_Tenant; User ID= sa; Password=root");
                con.Open();

                Console.WriteLine("Hooray, berhasil!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().SQLServer();
        }
    }
}
