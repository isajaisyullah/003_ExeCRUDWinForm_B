using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUDWinForm
{
    public partial class tambahpinjam : Form
    {
        DataTable dt;
        DataRow dr;
        public tambahpinjam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        public void updateKendaraan(string id, string penyewa, string kendaraan, string tanggal, string lamanya)
        {
            string connectionString = GetConnectionString();
            string query1 = $"select * from peminjaman where idKendaraan= '{id}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = $"insert into peminjaman (idPeminjaman, idPenyewa, idKendaraan,tglPeminjaman, lama) values ('{id}', '{penyewa}', '{kendaraan}', '{tanggal}', '{lamanya}')";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }

        private static string GetConnectionString()
        {
            return "data source = DESKTOP-MKB157K;database = exeCRUD; MultipleActiveResultSets = True; User ID=sa; Password = 123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateKendaraan(txtKode.ToString(), txtSewa.ToString(), txtKendaraan.ToString(), Date.ToString(), txtLama.ToString());
        }
    }
}
