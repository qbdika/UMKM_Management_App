using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuKaryawan
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Membuat instance Form1
            form1.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form1.FormClosed += (s, args) => this.Close();
        }

        private void BtnManajemen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Membuat instance Form2
            form2.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form2.FormClosed += (s, args) => this.Close();
        }

        private void BtnInventaris_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3(); // Membuat instance Form2
            form3.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1


            // Menutup Form1 setelah Form2 ditutup (opsional)
            form3.FormClosed += (s, args) => this.Close();
        }

        private void BtnAbsensi_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Membuat instance Form2
            form4.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form4.FormClosed += (s, args) => this.Close();
        }

        private void BtnProfileSet_Click(object sender, EventArgs e)
        {

            Form6 form6 = new Form6(); // Membuat instance Form2
            form6.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form6.FormClosed += (s, args) => this.Close();
        }


        private void BtnPengaturan_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); // Membuat instance Form2
            form7.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form7.FormClosed += (s, args) => this.Close();
        }

        private void btnClost_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
