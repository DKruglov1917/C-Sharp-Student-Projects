using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WendingMachine
{
    public partial class dkForm1 : Form
    {
        public static float dkcash = 0.0f;
        public int dkcounter_05 = 7;
        public int dkcounter_1 = 9;
        public int dkcounter_2 = 12;
        static float dksum = 36.5f;
        static float dkcounter_sum = dksum;
        public float dkcena = 999999999;
        public int dkwal_num = 0;
        public int dktyp_num = 0;
        static float dkceny = 1.0f;
        public float dkost_cash = dkcash;
        public int dktyp_pl = 1;
        public float dkpreszta = 0.0f;
        public int dkrc05 = 0;
        public int dkrc1 = 0;
        public int dkrc2 = 0;
        bool dkisKarta = false;
        
        public float dkzmKurs ()
        {
            float dkost_cena = dkcena * dkceny;
            return dkost_cena;
        }       

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] typy = { "Karta", "Gotowka" };

            string typ_str = (string)comboBox2.SelectedItem;
            dktyp_num = Array.IndexOf(typy, typ_str);
            if (dktyp_num == 0)
            {
                dkcash = 0.0f;
                dkisKarta = true;
            }
            else
            {
                dkcash = 0.0f;
                dkisKarta = false;
            }
        }

        private void waluta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //0 PLN
            //1 EUR (4.5 PLN)
            //2 USD (4 PLN)

            string[] waluty = { "PLN", "EUR", "USD" };
            
            string wal_str = (string)waluta.SelectedItem;
            dkwal_num = Array.IndexOf(waluty, wal_str);
            if (dkwal_num == 0)
            {
                dkceny = 1.0f;
                cSprite.Text = "2.50";
                cCola.Text = "5.00";
                cPepsi.Text = "7.50";
                cSnickers.Text = "5.00";
                cMars.Text = "2.50";

            }
            else if (dkwal_num == 1)
            {
                dkceny = 4.5f;
                cSprite.Text = "0.50";
                cCola.Text = "1.00";
                cPepsi.Text = "1.50";
                cSnickers.Text = "1.00";
                cMars.Text = "0.50";
            }
            else if (dkwal_num == 2)
            {
                dkceny = 4.0f;
                cSprite.Text = "0.50";
                cCola.Text = "1.50";
                cPepsi.Text = "2.00";
                cSnickers.Text = "1.50";
                cMars.Text = "0.50";
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        
        public dkForm1()
        {
            InitializeComponent();
            waluta.SelectedItem = "PLN";
            comboBox2.SelectedItem = "Gotowka";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
               
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cSprite_Click(object sender, EventArgs e)
        {

        }

        private void zlpol_Click(object sender, EventArgs e)
        {
            if (dkisKarta == true)
            {
                dkkartaerror frm5 = new dkkartaerror();
                frm5.Show();
                wrz_cash.Text = "0";
            }
            else
            {
                dkcash += 0.5f;
                dksum += 0.5f;
                string cash_str = dkcash.ToString();
                wrz_cash.Text = cash_str;
                dkcounter_05 += 1;
                string dkcounter_05_str = dkcounter_05.ToString();
                label19.Text = dkcounter_05_str;
                string dksum_str = dksum.ToString();
                label8.Text = dksum_str;
            }
        }

        private void zl_Click(object sender, EventArgs e)
        {
            if (dkisKarta == true)
            {
                dkkartaerror frm5 = new dkkartaerror();
                frm5.Show();
                wrz_cash.Text = "0";
            }
            else
            {
                dkcash += 1.0f;
                dksum += 1.0f;
                string cash_str = dkcash.ToString();
                wrz_cash.Text = cash_str;
                dkcounter_1 += 1;
                string dkcounter_1_str = dkcounter_1.ToString();
                label18.Text = dkcounter_1_str;
                string dksum_str = dksum.ToString();
                label8.Text = dksum_str;
            }
        }

        private void zl2_Click(object sender, EventArgs e)
        {
            if (dkisKarta == true)
            {
                dkkartaerror frm5 = new dkkartaerror();
                frm5.Show();
                wrz_cash.Text = "0";
            }
            else
            {
                dkcash += 2.0f;
                dksum += 2.0f;
                string cash_str = dkcash.ToString();
                wrz_cash.Text = cash_str;
                dkcounter_2 += 1;
                string dkcounter_2_str = dkcounter_2.ToString();
                label17.Text = dkcounter_2_str;
                string dksum_str = dksum.ToString();
                label8.Text = dksum_str;
            }
        }

        private void zl5_Click(object sender, EventArgs e)
        {
            if (dkisKarta == true)
            {
                dkkartaerror frm5 = new dkkartaerror();
                frm5.Show();
                wrz_cash.Text = "0";
            }
            else
            {
                dkcash += 5.0f;
                dksum += 5.0f;
                string cash_str = dkcash.ToString();
                wrz_cash.Text = cash_str;
                string dksum_str = dksum.ToString();
                label8.Text = dksum_str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void wrz_cash_Click(object sender, EventArgs e)
        {

        }

        private void waluta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void opl_mon_Click(object sender, EventArgs e)
        { 
            if (dkisKarta == true)
            {
                dkkartaerror frm5 = new dkkartaerror();
                frm5.Show();
            }
            else if (dkcash >= dkcena)
            {
                dkcounter_sum += dkcash;
                dkcash -= dkcena;
                string cash_str = dkcash.ToString();
                wrz_cash.Text = cash_str;

                dkpreszta = dkcash;

                string dkpreszta_str = dkpreszta.ToString();
                fullreszta.Text = dkpreszta_str;
                resztalabel.Text = "Reszta:";
                
                if (dksum != 0)
                {
                    while (dkcounter_2 > 0 && dkpreszta >= 2)
                    {
                        dkpreszta -= 2;
                        dkcounter_2--;
                        dkrc2++;
                    }
                    string dkrc2_str = dkrc2.ToString();
                    kol2.Text = dkrc2_str;
                    while (dkcounter_1 > 0 && dkpreszta >= 1)
                    {
                        dkpreszta -= 1;
                        dkcounter_1--;
                        dkrc1++;
                    }
                    string dkrc1_str = dkrc1.ToString();
                    kol1.Text = dkrc1_str;

                    while (dkcounter_05 > 0 && dkpreszta != 0)
                    {
                        dkpreszta -= 0.5f;
                        dkcounter_05--;
                        dkrc05++;
                        if (dkcounter_05 == 0)
                        {
                            dkpzp frm7 = new dkpzp();
                            frm7.Show();
                        }
                    }


                    string dkrc05_str = dkrc05.ToString();
                    kol05.Text = dkrc05_str;
                    dkcounter_sum -= dkcash;
                    string dkcounter_sum_str = dkcounter_sum.ToString();
                    label8.Text = dkcounter_sum_str;
                    dkrc2 = 0;
                    dkrc1 = 0;
                    dkrc05 = 0;


                }
            }
            else if (dkcena == 999999999)
            {
                dkzapprod frm4 = new dkzapprod();
                frm4.Show();
            }
            else
            {
                dknotenough frm2 = new dknotenough();
                frm2.Show();
            }            
        }

        private void Sprite_Click(object sender, EventArgs e)
        {
            if (dkwal_num == 0)
            {
                dkcena = 2.50f;
                kwota.Text = "2.50";
            }
            else
            {
                dkcena = 0.50f;
                kwota.Text = "0.50";
            }
        }

        private void Cola_Click(object sender, EventArgs e)
        {
            if (dkwal_num == 0)
            {
                dkcena = 5.00f;
                kwota.Text = "5.00";
            }
            else if (dkwal_num == 1)
            {
                dkcena = 1.00f;
                kwota.Text = "1.00";
            }
            else
            {
                dkcena = 1.50f;
                kwota.Text = "1.50";
            }
        }

        private void Pepsi_Click(object sender, EventArgs e)
        {
            if (dkwal_num == 0)
            {
                dkcena = 7.50f;
                kwota.Text = "7.50";
            }
            else if (dkwal_num == 1)
            {
                dkcena = 1.50f;
                kwota.Text = "1.50";
            }
            else
            {
                dkcena = 2.00f;
                kwota.Text = "2.00";
            }
        }

        private void Snickers_Click(object sender, EventArgs e)
        {
            if (dkwal_num == 0)
            {
                dkcena = 5.00f;
                kwota.Text = "5.00";
            }
            else if (dkwal_num == 1)
            {
                dkcena = 1.00f;
                kwota.Text = "1.00";
            }
            else
            {
                dkcena = 1.50f;
                kwota.Text = "1.50";
            }
        }

        private void Mars_Click(object sender, EventArgs e)
        {
            if (dkwal_num == 0)
            {
                dkcena = 2.50f;
                kwota.Text = "2.50";
            }
            else
            {
                dkcena = 0.50f;
                kwota.Text = "0.50";
            }
        }
                
        private void cCola_Click(object sender, EventArgs e)
        {

        }

        private void cSnickers_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dkisKarta != true)
            {
                dkmonerror frm6 = new dkmonerror();
                frm6.Show();
                wrz_cash.Text = "0";
            }
            else
            {
                dksucskart frm7 = new dksucskart();
                frm7.Show();
                wrz_cash.Text = "0";
            }
        }

        private void fullreszta_Click(object sender, EventArgs e)
        {

        }

        private void kol2_Click(object sender, EventArgs e)
        {

        }
    }
}
