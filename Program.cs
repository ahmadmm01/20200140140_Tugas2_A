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

                SqlCommand data1 = new SqlCommand("insert into owner (ID_owner, nama_owner, noHP_owner, alamat_owner, email_owner, jeniskelamin_owner) values ('1234567890123456','Mamad', '0812345678901', 'Jalan Manggis Nomor 01 Yogyakarta', 'mamad@gmail.com', 'L')", con);
                data1.ExecuteNonQuery();

                SqlCommand data2 = new SqlCommand("insert into customer (ID_customer, nama_customer, noHP_customer, alamat_customer, email_customer, jenisKelamin_customer) values ('0987654321098765','Rahmat','0894710284752','Jalan Semangka Nomor 11 Yogyakarta','rahmat@gmail.com','L')", con);
                data2.ExecuteNonQuery();

                SqlCommand data3 = new SqlCommand("insert into tenant (ID_tenant, jenis_sewa, lama_sewa, harga_sewa, lokasi_tenant) values ('001','bulan', 3, 500000, 'Lantai 5 Blok C')", con);
                data3.ExecuteNonQuery();

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
