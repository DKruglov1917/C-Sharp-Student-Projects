using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjektNr2_Kruhlov48720
{
    public partial class dk_Form : Form
    {
        //Podstawowe deklaracje takie jak margines czy tablice
        const int dk_Margines = 25;
        int dk_PróbaBadawcza = 200;
        int dk_MaxRozmTablicy = 50;
        int dk_DolnaGranicaWartościTablicy = 100;
        int dk_GórnaGranicaWartościTablicy = 100;
        int[] dk_Array;
        int[] dk_Licznik;

        float[] dk_WynikiZPomiaru;
        float[] dk_WynikiAnalityczne;

        bool dk_CzyWykresNarysowany = false;

        // Zadanie 2 sprawdzianiu
        public struct dk_EwidencjaBiblioteczna
        {
            public int dk_sygnatura;
            public string dk_tytuł;
            public string dk_autor;
            public int dk_rokWydania;
        }
        dk_EwidencjaBiblioteczna[] dk_Record = new dk_EwidencjaBiblioteczna[5];

        public dk_Form()
        {
            InitializeComponent();

            // Edycja formularza
            this.Left = Screen.PrimaryScreen.Bounds.Left + dk_Margines;
            this.Top = Screen.PrimaryScreen.Bounds.Top + dk_Margines;

            this.Width = 1150;
            this.Height = 690;

            this.StartPosition = FormStartPosition.Manual;
            this.AutoScroll = true;

            // Domyślnie ustawiamy wartości w textbox
            dk__txt_MinimalnaPróbaBadawcza.Text = dk_PróbaBadawcza.ToString();
            dk__txt_RozmiarTabl.Text = dk_MaxRozmTablicy.ToString();
            dk__txt_DolnaGranica.Text = dk_DolnaGranicaWartościTablicy.ToString();
            dk__txt_GórnaGranica.Text = dk_GórnaGranicaWartościTablicy.ToString();

            dk__dgv_TabelaWyników.Visible = false;
            dk__btn_WynikiTabelaryczne.Enabled = false;
            dk__groupBox1.Enabled = false;

        }

        // Akceptacja danych
        private void dk__btn_AkceptacjaDanych_Click(object sender, EventArgs e)
        {
            // Tworzymy tablice
            dk_Array = new int[dk_MaxRozmTablicy];
            dk_WynikiZPomiaru = new float[dk_MaxRozmTablicy];
            dk_WynikiAnalityczne = new float[dk_MaxRozmTablicy];
            dk_Licznik = new int[dk_PróbaBadawcza];

            // Uaktywniamy albo wyłaczymy niektóre przyciski
            dk__btn_WynikiTabelaryczne.Enabled = true;
            dk__btn_Resetuj.Enabled = true;
            dk__btn_WynikiWykres.Enabled = false;
            dk__btn_AkceptacjaDanych.Enabled = false;
            dk_ButtonZmianaSortowania.Enabled = false;

        }

        private void dk__btn_WynikiTabelaryczne_Click(object sender, EventArgs e)
        {
            // Uaktywniamy albo wyłaczymy niektóre przyciski
            dk__dgv_TabelaWyników.Visible = true;
            dk__btn_WynikiWykres.Enabled = true;
            dk__groupBox1.Enabled = false;
            dk_Wykres.Visible = false;


            int dk_LicznikOperacji = 0;
            float dk_SumaOperacji;
            float dk_ŚredniaOperacji;

            Random Rnd = new Random();
            dk_Sortowanie AlgorytmSortowania = new dk_Sortowanie();

            // Sortowanie
            for (int dk_l = 0; dk_l < dk_MaxRozmTablicy; dk_l++)
            {
                // Losujemy elementy tablicy
                for (int dk_k = 0; dk_k < dk_PróbaBadawcza; dk_k++)
                {
                    for (int dk_i = 0; dk_i < dk_MaxRozmTablicy; dk_i++)
                    {
                        dk_Array[dk_i] = Rnd.Next() * (dk_GórnaGranicaWartościTablicy - dk_DolnaGranicaWartościTablicy) + dk_DolnaGranicaWartościTablicy;
                    }

                    // Wybieramy metodę
                    switch (dk_WybranyAlgorytm.Text)
                    {
                        case "Radix Sort":
                            dk_LicznikOperacji = AlgorytmSortowania.dk_RadixSort(ref dk_Array, dk_Array.Length, dk_l);
                            break;

                        case "Library Sort":
                            dk_LicznikOperacji = AlgorytmSortowania.dk_LibrarySort(ref dk_Array, dk_l);  
                            break;
                    }

                    // Zapamiętujemy licznik operacji dominujących
                    dk_Licznik[dk_k] = dk_LicznikOperacji;
                }

                // Sumujemy wykonane operacje
                dk_SumaOperacji = 0.0F;

                for (int dk_j = 0; dk_j < dk_PróbaBadawcza; dk_j++)

                    dk_SumaOperacji = dk_SumaOperacji + dk_Licznik[dk_j];
                dk_ŚredniaOperacji = dk_SumaOperacji / dk_PróbaBadawcza;
                dk_WynikiZPomiaru[dk_l] = dk_ŚredniaOperacji;

                switch (dk_WybranyAlgorytm.Text)
                {
                    case "Merge Sort":
                        dk_WynikiAnalityczne[dk_l] = (float)(dk_l * Math.Log(dk_l));
                        break;

                    case "Radix Sort":
                        dk_WynikiAnalityczne[dk_l] = (float)(dk_l * Math.Log(dk_l));
                        break;
                }
            }

            // Edytujemy DataGridView
            dk__dgv_TabelaWyników.Location = new Point(300, 100);
            dk__dgv_TabelaWyników.Width = (int)(this.Width * 0.50F);
            dk__dgv_TabelaWyników.Height = (int)(this.Height * 0.70F);

            // Ustawiamy DataGridView
            for (int dk_i = 0; dk_i < dk_MaxRozmTablicy; dk_i++)
            {
                dk__dgv_TabelaWyników.Rows.Add();
                dk__dgv_TabelaWyników.Rows[dk_i].Cells[0].Value = dk_i;
                dk__dgv_TabelaWyników.Rows[dk_i].Cells[1].Value = String.Format("{0:F2}", dk_WynikiZPomiaru[dk_i]);
                dk__dgv_TabelaWyników.Rows[dk_i].Cells[2].Value = String.Format("{0:F2}", dk_WynikiAnalityczne[dk_i]);

                switch (dk_WybranyAlgorytm.Text)
                {
                    case "Merge Sort":
                        dk__dgv_TabelaWyników.Rows[dk_i].Cells[3].Value = dk_i + 52;
                        break;

                    case "Radix Sort":
                        dk__dgv_TabelaWyników.Rows[dk_i].Cells[3].Value = dk_i;
                        break;
                }

                if (dk_i % 2 == 0)
                {
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[0].Style.BackColor = Color.LightGray;
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[1].Style.BackColor = Color.LightGray;
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[2].Style.BackColor = Color.LightGray;
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[3].Style.BackColor = Color.LightGray;
                }
                else
                {
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[0].Style.BackColor = Color.White;
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[1].Style.BackColor = Color.White;
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[2].Style.BackColor = Color.White;
                    dk__dgv_TabelaWyników.Rows[dk_i].Cells[3].Style.BackColor = Color.White;
                }

                dk__dgv_TabelaWyników.Rows[dk_i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dk__dgv_TabelaWyników.Rows[dk_i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dk__dgv_TabelaWyników.Rows[dk_i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dk__dgv_TabelaWyników.Rows[dk_i].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Uaktywniamy albo wyłaczymy niektóre dane
            dk__dgv_TabelaWyników.Visible = true;
            dk__btn_WynikiTabelaryczne.Enabled = false;
        }

        // Textbox dla minimalnej próby badawczej
        private void dk__txt_MinimalnaPróbaBadawcza_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(dk__txt_MinimalnaPróbaBadawcza.Text, out dk_PróbaBadawcza))
                MessageBox.Show("ERROR: Niedozwolony znak!!!!");
        }

        // Zamieniamy sortowanie w tabelce
        private void dk_ButtonZmianaSortowania_Click(object sender, EventArgs e)
        {
            if (dk_WybranyAlgorytm.Text == "Radix Sort")
                dk_WybranyAlgorytm.Text = "Library Sort";
            else
                dk_WybranyAlgorytm.Text = "Radix Sort";
        }

        // Link do wizualizacji Radix Sorta
        private void dk_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.geeksforgeeks.org/radix-sort/");
        }

        // Link do wizualizacji Library Sorta
        private void dk_linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Library_sort");
        }

        // Tworzymy tabelkę oraz wyświetlamy wszystkie liczby
        private void dk__btn_WynikiWykres_Click(object sender, EventArgs e)
        {
            // Uaktywniamy albo wyłaczymy niektóre przyciski
            dk__dgv_TabelaWyników.Visible = false;
            dk__btn_WynikiWykres.Enabled = false;
            dk__groupBox1.Enabled = true;
            dk__btn_WynikiTabelaryczne.Enabled = true;
            dk_Wykres.Visible = true;
            dk__btn_WynikiWykres.Visible = true;

            if (dk_CzyWykresNarysowany == false)
            {
                int[] dk_RozmiarTabeli = new int[dk_MaxRozmTablicy];

                for (int dk_i = 0; dk_i < dk_MaxRozmTablicy; dk_i++)
                    dk_RozmiarTabeli[dk_i] = dk_i;

                // Edytujemy tytuł
                Title dk_TytulWykresu = new Title();
                dk_TytulWykresu.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);

                // Ustawiamy nazwę metod
                switch (dk_WybranyAlgorytm.Text)
                {
                    case "Merge Sort":
                        dk_TytulWykresu.Text = "Algorytm Radix Sort";
                        break;

                    case "Radix Sort":
                        dk_TytulWykresu.Text = "Algorytm Library Sort";
                        break;
                }

                // Edycja wykresów
                dk_Wykres.Titles.Add(dk_TytulWykresu);

                // Koszt czasowy pomiaru
                var dk_Series0 = new Series("Koszt czasowy pomiaru");
                dk_Series0.Color = Color.Green;
                dk_Series0.Points.DataBindXY(dk_RozmiarTabeli, dk_WynikiZPomiaru);
                dk_Wykres.Legends["Legend1"].Docking = Docking.Bottom;
                dk_Wykres.Series.Add(dk_Series0);

                // Koszt analityczny
                dk_Wykres.Series[0].ChartType = SeriesChartType.Line;
                var dk_Series1 = new Series("Koszt analityczny");
                dk_Series1.Color = Color.Red;
                dk_Series1.Points.DataBindXY(dk_RozmiarTabeli, dk_WynikiAnalityczne);

                // Koszt pamięciowy
                dk_Wykres.Series.Add(dk_Series1);
                dk_Wykres.Series[1].ChartType = SeriesChartType.Line;
                var dk_Series2 = new Series("Koszt pamięciowy");
                dk_Series2.Color = Color.Violet;

                int[] dk_KosztPamieciowyMergeSort = new int[dk_MaxRozmTablicy];

                // Po kliknięciu wyświetli Merge albo Radix sort
                switch (dk_WybranyAlgorytm.Text)
                {
                    case "Merge Sort":
                        for (int dk_i = 0; dk_i < dk_MaxRozmTablicy; dk_i++)
                            dk_KosztPamieciowyMergeSort[dk_i] = dk_i + 10;
                        break;

                    case "Radix Sort":
                        for (int dk_i = 0; dk_i < dk_MaxRozmTablicy; dk_i++)
                            dk_KosztPamieciowyMergeSort[dk_i] = 1;
                        break;
                }

                dk_Series2.Points.DataBindXY(dk_RozmiarTabeli, dk_KosztPamieciowyMergeSort);
                dk_Wykres.Series.Add(dk_Series2);
                dk_Wykres.Series[2].ChartType = SeriesChartType.Line;
                dk_CzyWykresNarysowany = true;
            }
        }

        // Textbox dla rozmiaru tablicy
        private void dk__txt_RozmiarTabl_TextChanged(object sender, EventArgs e)
        {
            dk_MaxRozmTablicy = Convert.ToInt32(dk__txt_RozmiarTabl.Text);
        }

        // Textbox dla dolnej granicy tablicy
        private void dk__txt_DolnaGranica_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(dk__txt_DolnaGranica.Text, out dk_DolnaGranicaWartościTablicy))
            {
                MessageBox.Show("Wystąpił błąd, sprawdź co wprowadziłeś!");
            }
        }

        // Textbox dla górnej granicy tablicy
        private void dk__txt_GórnaGranica_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(dk__txt_GórnaGranica.Text, out dk_GórnaGranicaWartościTablicy))
            {
                MessageBox.Show("Wystąpił błąd, sprawdź co wprowadziłeś!");
            }
        }

        // Przycisk "reset"
        private void dk__btn_Resetuj_Click(object sender, EventArgs e)
        {
            dk__btn_WynikiTabelaryczne.Enabled = true;
            dk_ButtonZmianaSortowania.Enabled = true;
            dk__btn_AkceptacjaDanych.Enabled = true;
            dk__btn_WynikiWykres.Enabled = false;
            dk_CzyWykresNarysowany = false;

            dk_Wykres.Series.Clear();
            dk__dgv_TabelaWyników.Rows.Clear();
            
        }

        // Zmiana koloru linii
        private void dk_ZmianaKoloru1_Click(object sender, EventArgs e)
        {
            if (dk__colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dk_Wykres.Series[0].Color = dk__colorDialog1.Color;
            }
        }

        private void dk_ZmianaKoloru2_Click(object sender, EventArgs e)
        {
            if (dk__colorDialog2.ShowDialog() == DialogResult.OK)
            {
                dk_Wykres.Series[1].Color = dk__colorDialog2.Color;
            }
        }

        private void dk_ZmianaKoloru3_Click(object sender, EventArgs e)
        {
            if (dk__colorDialog3.ShowDialog() == DialogResult.OK)
            {
                dk_Wykres.Series[2].Color = dk__colorDialog3.Color;
            }
        }

        // Zmiana grubości linii
        private void dk_ZmianaGrubosci1_Scroll(object sender, EventArgs e)
        {
            dk_Wykres.Series[0].BorderWidth = dk_ZmianaGrubosci1.Value;
        }

        private void dk_ZmianaGrubosci2_Scroll(object sender, EventArgs e)
        {
            dk_Wykres.Series[1].BorderWidth = dk_ZmianaGrubosci2.Value;
        }

        private void dk_ZmianaGrubosci3_Scroll(object sender, EventArgs e)
        {
            dk_Wykres.Series[2].BorderWidth = dk_ZmianaGrubosci3.Value;
        }

        // Zmiana stylu linii
        private void dk_ZmianaStylu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dk_ZmianaStylu1.SelectedIndex == 0)
                dk_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            else if (dk_ZmianaStylu1.SelectedIndex == 1)
                dk_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Dash;
            else
                dk_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Dot;
        }

        private void dk_ZmianaStylu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dk_ZmianaStylu2.SelectedIndex == 0)
                dk_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Solid;
            else if (dk_ZmianaStylu2.SelectedIndex == 1)
                dk_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Dash;
            else
                dk_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Dot;
        }

        private void dk_ZmianaStylu3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dk_ZmianaStylu3.SelectedIndex == 0)
                dk_Wykres.Series[2].BorderDashStyle = ChartDashStyle.Solid;
            else if (dk_ZmianaStylu3.SelectedIndex == 1)
                dk_Wykres.Series[2].BorderDashStyle = ChartDashStyle.Dash;
            else
                dk_Wykres.Series[2].BorderDashStyle = ChartDashStyle.Dot;
        }

        private void dk_Form_Load(object sender, EventArgs e)
        {

        }
    }
}