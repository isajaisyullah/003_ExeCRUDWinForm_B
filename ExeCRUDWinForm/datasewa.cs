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
    public partial class datasewa : Form
    {
        public datasewa()
        {
            InitializeComponent();
        }

        private void datasewa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet.Penyewa' table. You can move, or remove it, as needed.
            this.penyewaTableAdapter.Fill(this.exeCRUDDataSet.Penyewa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
