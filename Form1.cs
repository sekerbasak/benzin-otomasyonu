using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENZİN_OTOMASYONU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        double D_benzin95 = 0, D_benzin97 = 0, D_dizel = 0, D_eurodizel = 0, D_LPG = 0;

        double E_benzin95 = 0, E_benzin97 = 0, E_dizel = 0, E_eurodizel = 0, E_LPG = 0;

        double F_benzin95 = 0, F_benzin97 = 0, F_dizel = 0, F_eurodizel = 0, F_LPG = 0;

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                E_benzin95 = Convert.ToDouble(textBox1.Text);
                if(1000<D_benzin95+E_benzin95 || E_benzin95 <= 0)
                {
                    textBox1.Text = "Hata!";

                }
                else
                {
                    depo_bilgiler[0] = Convert.ToString(D_benzin95 + E_benzin95);
                }
            }
            catch (Exception)
            {

                textBox1.Text = "Hata!";
            }


            try
            {
                E_benzin97 = Convert.ToDouble(textBox2.Text);
                if (1000 < D_benzin97 + E_benzin97 || E_benzin97 <= 0)
                {
                    textBox2.Text = "Hata!";

                }
                else
                {
                    depo_bilgiler[1] = Convert.ToString(D_benzin97 + E_benzin97);
                }
            }
            catch (Exception)
            {

                textBox2.Text = "Hata!";
            }
            try
            {
                E_dizel = Convert.ToDouble(textBox3.Text);
                if (1000 < D_dizel + E_dizel || E_dizel <= 0)
                {
                    textBox3.Text = "Hata!";

                }
                else
                {
                    depo_bilgiler[2] = Convert.ToString(D_dizel + E_dizel);
                }
            }
            catch (Exception)
            {

                textBox3.Text = "Hata!";
            }
            try
            {
                E_eurodizel = Convert.ToDouble(textBox4.Text);
                if (1000 < D_eurodizel + E_eurodizel || E_eurodizel <= 0)
                {
                    textBox4.Text = "Hata!";

                }
                else
                {
                    depo_bilgiler[3] = Convert.ToString(D_eurodizel + E_eurodizel);
                }
            }
            catch (Exception)
            {

                textBox4.Text = "Hata!";
            }
            try
            {
                E_LPG = Convert.ToDouble(textBox5.Text);
                if (1000 < D_LPG + E_LPG || E_LPG <= 0)
                {
                    textBox5.Text = "Hata!";

                }
                else
                {
                    depo_bilgiler[4] = Convert.ToString(D_LPG + E_LPG);
                }
            }
            catch (Exception)
            {

                textBox5.Text = "Hata!";
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt" ,depo_bilgiler);
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
            numericupdown_value();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                F_benzin95 = F_benzin95 + (F_benzin95 * Convert.ToDouble(textBox6.Text) / 100);
                fiyat_bilgileri[0] = Convert.ToString(F_benzin95);
            }
            catch (Exception)
            {
                textBox6.Text = "Hata!";
                
            }
            try
            {
                F_benzin97 = F_benzin97 + (F_benzin97 * Convert.ToDouble(textBox7.Text) / 100);
                fiyat_bilgileri[1] = Convert.ToString(F_benzin97);
            }
            catch (Exception)
            {
                textBox7.Text = "Hata!";

            }
            try
            {
                F_dizel = F_dizel + (F_dizel * Convert.ToDouble(textBox8.Text) / 100);
                fiyat_bilgileri[2] = Convert.ToString(F_dizel);
            }
            catch (Exception)
            {
                textBox8.Text = "Hata!";

            }
            try
            {
                F_eurodizel = F_dizel + (F_dizel * Convert.ToDouble(textBox9.Text) / 100);
                fiyat_bilgileri[3] = Convert.ToString(F_dizel);
            }
            catch (Exception)
            {
                textBox9.Text = "Hata!";

            }
            try
            {
                F_LPG = F_LPG + (F_LPG * Convert.ToDouble(textBox10.Text) / 100);
                fiyat_bilgileri[4] = Convert.ToString(F_LPG);
            }
            catch (Exception)
            {
                textBox10.Text = "Hata!";

            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", fiyat_bilgileri);
            txt_fiyat_oku();
            txt_fiyat_yaz();
            label17.Text = fiyat_bilgileri[0];
            label18.Text = fiyat_bilgileri[1];
            label19.Text = fiyat_bilgileri[2];
            label20.Text = fiyat_bilgileri[3];
            label21.Text = fiyat_bilgileri[4];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Benzin(95)")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if(comboBox1.Text == "Benzin(97)")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "EuroDizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled =false;
                numericUpDown4.Enabled =  true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "LPG")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

            label30.Text = "_________";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_benzin95 = double.Parse(numericUpDown1.Value.ToString());
            S_benzin97 = double.Parse(numericUpDown2.Value.ToString());
            S_dizel = double.Parse(numericUpDown3.Value.ToString());
            S_eurodizel = double.Parse(numericUpDown4.Value.ToString());
            S_LPG = double.Parse(numericUpDown5.Value.ToString());

            if (numericUpDown1.Enabled == true)
            {
                D_benzin95 = D_benzin95 - S_benzin95;
                label30.Text = Convert.ToString(S_benzin95 * F_benzin95);
            }

            if (numericUpDown2.Enabled == true)
            {
                D_benzin97 = D_benzin97 - S_benzin97;
                label30.Text = Convert.ToString(S_benzin97 * F_benzin97);
            }

            if (numericUpDown3.Enabled == true)
            {
                D_dizel = D_dizel - S_dizel;
                label30.Text = Convert.ToString(S_dizel * F_dizel);
            }

            if (numericUpDown4.Enabled == true)
            {
                D_eurodizel = D_eurodizel - S_eurodizel;
                label30.Text = Convert.ToString(S_eurodizel * F_eurodizel);
            }

            if (numericUpDown5.Enabled == true)
            {
                D_LPG = D_LPG - S_LPG;
                label30.Text = Convert.ToString(S_LPG * F_LPG);
            }

            depo_bilgiler[0] = Convert.ToString(D_benzin95);
            depo_bilgiler[1] = Convert.ToString(D_benzin97);
            depo_bilgiler[2] = Convert.ToString(D_dizel);
            depo_bilgiler[3] = Convert.ToString(D_eurodizel);
            depo_bilgiler[4] = Convert.ToString(D_LPG);

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgiler);
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
            numericupdown_value();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        double S_benzin95 = 0, S_benzin97 = 0, S_dizel = 0, S_eurodizel = 0, S_LPG = 0;

        string[] depo_bilgiler;
        string[] fiyat_bilgileri;

        private void txt_depo_oku()
        {
            depo_bilgiler = System.IO.File.ReadAllLines(Application.StartupPath+"\\depo.txt");
            D_benzin95 = Convert.ToDouble(depo_bilgiler[0]);
            D_benzin97 = Convert.ToDouble(depo_bilgiler[1]);
            D_dizel = Convert.ToDouble(depo_bilgiler[2]);
            D_eurodizel = Convert.ToDouble(depo_bilgiler[3]);
            D_LPG = Convert.ToDouble(depo_bilgiler[4]);

        }
        private void txt_depo_yaz()
        {
            label6.Text = D_benzin95.ToString("N");
            label7.Text = D_benzin97.ToString("N");
            label8.Text = D_dizel.ToString("N");
            label9.Text = D_eurodizel.ToString("N");
            label10.Text = D_LPG.ToString("N");

        }
        private void txt_fiyat_oku()
        {
            fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\fiyat.txt");
            F_benzin95 = Convert.ToDouble(fiyat_bilgileri[0]);
            F_benzin97 = Convert.ToDouble(fiyat_bilgileri[1]);
            F_dizel = Convert.ToDouble(fiyat_bilgileri[2]);
            F_eurodizel = Convert.ToDouble(fiyat_bilgileri[3]);
            F_LPG = Convert.ToDouble(fiyat_bilgileri[4]);
}
        private void txt_fiyat_yaz()
        {
            label17.Text = F_benzin95.ToString("N");
            label18.Text = F_benzin97.ToString("N");
            label19.Text = F_dizel.ToString("N");
            label20.Text = F_eurodizel.ToString("N");
            label21.Text = F_LPG.ToString("N");
        }
        private void progressBar_guncelle()
        {
            progressBar2.Value = Convert.ToInt32(D_benzin95);
            progressBar3.Value = Convert.ToInt32(D_benzin97);
            progressBar4.Value = Convert.ToInt32(D_dizel);
            progressBar5.Value = Convert.ToInt32(D_eurodizel);
            progressBar6.Value = Convert.ToInt32(D_LPG);
        }
        private void numericupdown_value()
        {
            numericUpDown1.Maximum = decimal.Parse(D_benzin95.ToString());
            numericUpDown2.Maximum = decimal.Parse(D_benzin97.ToString());
            numericUpDown3.Maximum = decimal.Parse(D_dizel.ToString());
            numericUpDown4.Maximum = decimal.Parse(D_eurodizel.ToString());
            numericUpDown5.Maximum = decimal.Parse(D_LPG.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "AKARYAKIT OTOMASYONU";
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;
            progressBar5.Maximum = 1000;
            progressBar6.Maximum = 1000;



            txt_depo_oku();
            txt_depo_yaz();
            txt_fiyat_oku();
            txt_fiyat_yaz();
            progressBar_guncelle();
            numericupdown_value();
            string[] yakit_türleri = { "Benzin(95)", "Benzin(97)", "Dizel", "EuroDizel", "LPG" };

            comboBox1.Items.AddRange(yakit_türleri);
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;





             
        }
    }
}
