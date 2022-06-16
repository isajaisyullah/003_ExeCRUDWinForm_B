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
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet.kendaraan' table. You can move, or remove it, as needed.
            this.kendaraanTableAdapter.Fill(this.exeCRUDDataSet.kendaraan);

            txtID.Enabled = false;
            txtMerek.Enabled = false;
            txtPol.Enabled = false;
            txtOwn.Enabled = false;
            
            cbJenis.Enabled = false;
            

            cbJenis.Items.Add("MOTOR");
            cbJenis.Items.Add("MOBIL");

            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtID.Enabled = true;
            txtMerek.Enabled = true;
            txtPol.Enabled = true;
            txtOwn.Enabled = true;
            cbJenis.Enabled = true;
            
            txtID.Text = "";
            txtMerek.Text = "";
            txtPol.Text = "";
            txtOwn.Text = "";
            cbJenis.Text = "";
          
            dt = exeCRUDDataSet.Tables["kendaraan"];
          
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt = exeCRUDDataSet.Tables["kendaraan"];
            dr = dt.NewRow();
            dr[0] = txtID.Text;
            dr[1] = cbJenis.SelectedItem;
            dr[2] = txtMerek.Text;
            dr[3] = txtPol.Text;
            dr[4] = txtOwn.Text;

            dt.Rows.Add(dr);

            kendaraanTableAdapter.Update(exeCRUDDataSet);

            txtID.Enabled = false;
            txtMerek.Enabled = false;
            txtPol.Enabled = false;
            txtOwn.Enabled = false;
            cbJenis.Enabled = false;

            this.kendaraanTableAdapter.Fill(this.exeCRUDDataSet.kendaraan);

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            code = txtID.Text;

            dr = exeCRUDDataSet.Tables["kendaraan"].Rows.Find(code);
            dr.Delete();

           kendaraanTableAdapter.Update(exeCRUDDataSet);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
