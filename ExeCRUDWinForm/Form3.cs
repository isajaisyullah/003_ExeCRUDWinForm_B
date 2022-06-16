using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet.peminjaman' table. You can move, or remove it, as needed.
            this.peminjamanTableAdapter.Fill(this.exeCRUDDataSet.peminjaman);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new tambahpinjam().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            new datasewa().Show();
            this.Hide();
        }
    }
}
