using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace MenuKaryawan
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Menjadikan Form1 sebagai MDI Parent

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bagian 1: Kode untuk Grafik
            //string[] bulan = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //double[] pemasukan = { 1000, 1200, 1500, 1800, 1300, 1700, 2000, 2200, 2100, 1900, 2300, 2500 };
           //double[] pengeluaran = { 800, 900, 1100, 1300, 900, 1000, 1200, 1300, 1250, 1100, 1350, 1400 };

            // Konfigurasi grafik pemasukan dan pengeluaran
            //chtGrafik.Series.Clear();
            //Series seriesPemasukan = chtGrafik.Series.Add("Pemasukan");
            //seriesPemasukan.ChartType = SeriesChartType.Line;
            //seriesPemasukan.Color = System.Drawing.Color.Green;

            //Series seriesPengeluaran = chtGrafik.Series.Add("Pengeluaran");
            //seriesPengeluaran.ChartType = SeriesChartType.Line;
            //seriesPengeluaran.Color = System.Drawing.Color.Red;

            //for (int i = 0; i < bulan.Length; i++)
            //{
             //   seriesPemasukan.Points.AddXY(bulan[i], pemasukan[i]);
             //   seriesPengeluaran.Points.AddXY(bulan[i], pengeluaran[i]);
            //}

         }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnManajemen_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnManajemen.Height;
            PnlNav.Top = BtnManajemen.Top;
            BtnManajemen.BackColor = Color.FromArgb(46, 51, 73);

            Form2 form2 = new Form2(); // Membuat instance Form2
            form2.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form2.FormClosed += (s, args) => this.Close();
        }

        private void BtnInventaris_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnInventaris.Height;
            PnlNav.Top = BtnInventaris.Top;
            BtnInventaris.BackColor = Color.FromArgb(46, 51, 73);

            Form3 form3 = new Form3(); // Membuat instance Form2
            form3.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form3.FormClosed += (s, args) => this.Close();
        }

        private void BtnAbsensi_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAbsensi.Height;
            PnlNav.Top = BtnAbsensi.Top;
            BtnAbsensi.BackColor = Color.FromArgb(46, 51, 73);

            Form4 form4 = new Form4(); // Membuat instance Form2
            form4.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form4.FormClosed += (s, args) => this.Close();
        }

        private void BtnBonus_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnBonus.Height;
            PnlNav.Top = BtnBonus.Top;
            BtnBonus.BackColor = Color.FromArgb(46, 51, 73);

            Form5 form5 = new Form5(); // Membuat instance Form2
            form5.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form5.FormClosed += (s, args) => this.Close();
        }

        private void BtnProfileSet_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnProfileSet.Height;
            PnlNav.Top = BtnProfileSet.Top;
            BtnProfileSet.BackColor = Color.FromArgb(46, 51, 73);

            Form6 form6 = new Form6(); // Membuat instance Form2
            form6.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form6.FormClosed += (s, args) => this.Close();
        }

        private void BtnPengaturan_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnPengaturan.Height;
            PnlNav.Top = BtnPengaturan.Top;
            BtnPengaturan.BackColor = Color.FromArgb(46, 51, 73);

            Form7 form7 = new Form7(); // Membuat instance Form2
            form7.Show();              // Menampilkan Form2
            this.Hide();               // Menyembunyikan Form1

            // Menutup Form1 setelah Form2 ditutup (opsional)
            form7.FormClosed += (s, args) => this.Close();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnManajemen_Leave(object sender, EventArgs e)
        {
            BtnManajemen.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnInventaris_Leave(object sender, EventArgs e)
        {
            BtnInventaris.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAbsensi_Leave(object sender, EventArgs e)
        {
            BtnAbsensi.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnBonus_Leave(object sender, EventArgs e)
        {
            BtnBonus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnProfileSet_Leave(object sender, EventArgs e)
        {
            BtnProfileSet.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnPengaturan_Leave(object sender, EventArgs e)
        {
            BtnPengaturan.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClost_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
