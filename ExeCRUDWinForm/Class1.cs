using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExeCRUDWinForm
{
    class Class1
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(GetConnectionString());
                con.Open();

                SqlCommand cm = new SqlCommand(
                    "create table Penyewa (idPenyewa varchar(5) not null primary key, Nama varchar(50), NIK varchar(16), JKelamin char(1), NoHP varchar(13), Alamat varchar(50))" +
                    "create table kendaraan (idKendaraan varchar(5) PRIMARY KEY,Tipe varchar(5),nmMerek varchar(20),NoPol varchar(9),pemilik varchar(50))" +
                    "create table peminjaman (idPeminjaman varchar(5) Primary key,idPenyewa varchar(5) Foreign key references Penyewa(idPenyewa),idKendaraan varchar(5) Foreign key references kendaraan(idKendaraan),tglPeminjaman date,lama varchar(10))"
                    , con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Table sukses dibuat!");
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

        public void updateKendaraan(string id, string tipe, string merek, string noPol, string pemilik)
        {
            string connectionString = GetConnectionString();
            string query1 = $"select * from kendaraan where idKendaraan= '{id}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = $"update kendaraan SET Tipe = '{tipe}', nmMerek = '{merek}', NoPol = '{noPol}', pemilik = '{pemilik}' WHERE idKendaraan = '{id}'";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }

        public void deleteKendaraan(string id)
        {
            string connectionString = GetConnectionString();
            string query1 = $"select * from kendaraan where idKendaraan= '{id}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = $"delete kendaraan WHERE idKendaraan = '{id}'";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been deleted");
                    }
                }
            }
            Console.ReadLine();
        }

        private static string GetConnectionString()
        {
            return "data source = DESKTOP-MKB157K;database = exeCRUD; MultipleActiveResultSets = True; User ID=sa; Password = 123";
        }
    }
}
