using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Projekt3_Kruhlov_48720.Kruhlov_48720;

namespace Projekt3_Kruhlov_48720
{
    class dkOstrosłupSześciokątnyPochyły : dkWielościany
    {//deklaracja zmiennych globalnych dla danej klasy
        float dkOś_duża, dkOś_mała;
        int dkKątNachylenia;
        float dkKątMiędzyWierzchołkami, dkKątPołożenia;
        Point[] dkWielokątPodłogi;
        private int dkr;
        private Color dkkolorLinii;
        private DashStyle dkstylLinii;
        private int dkgrubośćLinii;

        public dkOstrosłupSześciokątnyPochyły(int dkR, int dkWysokośćOstrosłupa, int dkStopieńWielokątaPodstawy, int dkXsS, int dkYsS, 
            int dkXsP, int dkYsP,
            Color dkKolorLinii, DashStyle dkStylLinii, int dkGrubośćLinii) : base(dkR, dkStopieńWielokątaPodstawy,
                dkKolorLinii, dkStylLinii, dkGrubośćLinii)
        {//odziedziczenie wartości zmiennych z klasy nadrzędnej
            this.dkrodzaj_bryły = dktyp_bryły.dkbg_ostrosłup_sześciokątny_pochyły;
            this.dkWysokośćBryły = dkWysokośćOstrosłupa;
            this.dkStopieńWielokątaPodstawy = dkStopieńWielokątaPodstawy;
            dkKątNachylenia = Math.Abs(dkXsP - dkXsS);
            this.dkOś_duża = this.dkPromieńBryły * 2;
            this.dkOś_mała = this.dkPromieńBryły / 2;
            this.dkKątPochylylenia = 90;

            this.dkXsS = dkXsS;
            this.dkYsS = dkYsS;
            this.dkXsP = dkXsP;
            this.dkYsP = dkYsP;

            //wyznaczenie współrzędnych wielokąta podłogi
            this.dkKątMiędzyWierzchołkami = 360 / dkStopieńWielokątaPodstawy;
            this.dkKątPołożenia = 0f;
            //utworzenie egzemplarzy dla tablic wierzchołków wielokąta podłogi
            this.dkWielokątPodłogi = new Point[dkStopieńWielokątaPodstawy + 1];
            //utworzenie egzemlarzy punktów wierzchołków wielokąta podłogi
            //wyznaczenie współrzędnych wierzchołków wielokąta podłogi
            for (int dki = 0; dki <= dkStopieńWielokątaPodstawy; dki++)
            {
                dkWielokątPodłogi[dki] = new Point();
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * Math.Cos(Math.PI * 
                    (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * Math.Sin(Math.PI * 
                    (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
            }
            //obliczenie objętości i pola powierzchni figury
            float dkPolePodstawy = (float)((3 * Math.Pow(dkOś_duża / 2, 2) * Math.Sqrt(3)) / 2);
            float dkPoleBoku = (float)((dkOś_duża / 4) * Math.Sqrt((5 / 4) * Math.Pow(dkOś_duża / 2, 2) + Math.Pow(dkWysokośćBryły, 2)));
            this.dkObjętośćBryły = (dkPolePodstawy * dkWysokośćBryły / 3);
            this.dkPowierzchniaBryły = (dkPolePodstawy + dkPoleBoku * 6);
        }

        public override void dkWykreśl()
        {
            //utworzenie pióra
            Pen dkPióro = new Pen(this.dkKolor_linii, this.dkGrubość_linii);
            dkPióro.DashStyle = this.dkStyl_linii;
            //wykreślenie podłogi
            for (int dki = 0; dki < dkWielokątPodłogi.Length - 1; dki++)
                dkRysownica.DrawLine(dkPióro, dkWielokątPodłogi[dki], dkWielokątPodłogi[dki + 1]);

            //wykreślenie krawędzi bocznych ostrosłupa
            for (int dki = 0; dki <= dkStopieńWielokątaPodstawy; dki++)
                dkRysownica.DrawLine(dkPióro, dkWielokątPodłogi[dki], new Point(dkXsS, dkYsS));
            //zwolninie pióra
            dkPióro.Dispose();
        }
        public override void dkWymaż()
        {
            //utworzenie pióra
            Pen dkPióro = new Pen(dkKolorTła, this.dkGrubość_linii);
            dkPióro.DashStyle = this.dkStyl_linii;
            //wykreślenie podłogi
            for (int dki = 0; dki < dkWielokątPodłogi.Length - 1; dki++)
                dkRysownica.DrawLine(dkPióro, dkWielokątPodłogi[dki], dkWielokątPodłogi[dki + 1]);

            //wykreślenie krawędzi bocznych ostrosłupa
            for (int dki = 0; dki <= dkStopieńWielokątaPodstawy; dki++)
                dkRysownica.DrawLine(dkPióro, dkWielokątPodłogi[dki], new Point(dkXsS, dkYsS));
            //zwolninie pióra
            dkPióro.Dispose();
        }
        public override void dkObróć_i_wykreśl(float dkkątObrotu)
        {
            dkWymaż();
            //wyznaczenie współrzędnych wierzchołków wielokąta podło obróconych o kątObrotu
            if (!this.dkKierunekObrotu)
                this.dkKątPołożenia += dkkątObrotu;
            else
                this.dkKątPołożenia -= dkkątObrotu;
            for (int dki = 0; dki <= dkStopieńWielokątaPodstawy; dki++)
            {
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * Math.Cos(Math.PI * 
                    (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * Math.Sin(Math.PI * 
                    (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
            }
            dkWykreśl();
        }
        public override void dkPrzesuńDoNowegoXY(int dkx, int dky)
        {/*Wymazuje poprzednią figurę, ustawia wszsytkieparametry na nowe, podane z klasy głownek
            a następnie oblicza wartości owej figury i ją kreśli*/
            dkWymaż();
            this.dkXsP = dkx - dkKątNachylenia;
            this.dkYsP = dky;
            this.dkXsS = dkx + (int)(this.dkWysokośćBryły / (Math.Tan(Math.PI * dkKątPochylylenia / 180f)));
            this.dkYsS = dky - dkWysokośćBryły;

            for (int dki = 0; dki < dkStopieńWielokątaPodstawy; dki++)
            {
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * Math.Cos(Math.PI * 
                    (dkKątPochylylenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * 
                    Math.Sin(Math.PI * (dkKątPochylylenia + dki * dkKątMiędzyWierzchołkami) / 180f));
            }
            dkWykreśl();
        }
        public override void dkZmianaPromieniaBryły(int dkPromień)
        {
            dkOś_duża = dkPromień * 2;
            dkOś_mała = dkPromień / 2;
        }
        public override void dkUstawWysokość(int dkWysokość)
        {
            dkWysokośćBryły = dkWysokość;
        }
        public override void dkUstawStopieńWielokąta(int dkStopień) { }
        public override void dkObliczeniePolaObjętościItp()
        {
            //obliczenie objętości i pola powierzchni figury
            float dkPolePodstawy = (float)((3 * Math.Pow(dkOś_duża / 2, 2) * Math.Sqrt(3)) / 2);
            float dkPoleBoku = (float)((dkOś_duża / 4) * Math.Sqrt((5 / 4) * Math.Pow(dkOś_duża / 2, 2) + Math.Pow(dkWysokośćBryły, 2)));
            this.dkObjętośćBryły = (dkPolePodstawy * dkWysokośćBryły / 3);
            this.dkPowierzchniaBryły = (dkPolePodstawy + dkPoleBoku * 6);
        }
    }

}
