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
    class dkStożek : dkWielościany
    {//deklaracja zmiennych globalnych dla danej klasy
        float dkOś_duża, dkOś_mała;
        float dkKątMiędzyWierzchołkami, dkKątPołożenia;
        Point[] dkWielokątPodłogi; 
        Point dkSufit;

        public dkStożek(int dkR, int dkWysokośćStożka, int dkStopieńWielokątaPodstawy, int dkXsS, int dkYsS, int dkXsP, int dkYsP,
            Color dkKolorLinii, DashStyle dkStylLinii, int dkGrubośćLinii) : base(dkR, dkStopieńWielokątaPodstawy,
                dkKolorLinii, dkStylLinii, dkGrubośćLinii)
        {//odziedziczenie wartości zmiennych z klasy nadrzędnej
            this.dkrodzaj_bryły = dktyp_bryły.dkbg_stożek;
            dkSufit = new Point(dkXsS, dkYsS);
            this.dkWysokośćBryły = dkWysokośćStożka;
            this.dkStopieńWielokątaPodstawy = dkStopieńWielokątaPodstawy;
            this.dkOś_duża = this.dkPromieńBryły * 2;
            this.dkOś_mała = this.dkPromieńBryły / 2;
            this.dkXsS = dkXsS;
            this.dkYsS = dkYsS;
            this.dkXsP = dkXsP;
            this.dkYsP = dkYsP;
            //wyznaczenie współrzędnych wielokąta podłogi i sufitu
            this.dkKątMiędzyWierzchołkami = 360 / dkStopieńWielokątaPodstawy;
            this.dkKątPołożenia = 0f;
            //utworzenie egzemplarzy dla tablic wierzchołków w 
            this.dkWielokątPodłogi = new Point[dkStopieńWielokątaPodstawy];

            //utworzenie egzemlarzy punktów wierzchołków wielokąta
            //wyznaczenie współrzędnych wierzchołki wielokąta podłogi
            for (int dki = 0; dki < dkStopieńWielokątaPodstawy; dki++)
            {
                dkWielokątPodłogi[dki] = new Point();
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * 
                    Math.Sin(Math.PI * (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * 
                    Math.Cos(Math.PI * (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
            }

            //obliczenie objętości i pola powierzchni figury
            float dkPolePodstawy = (float)(Math.PI * Math.Pow(dkOś_duża / 2, 2));
            float dkPoleBoku = (float)(Math.Sqrt(Math.Pow(dkWysokośćBryły, 2) + Math.Pow(dkOś_duża / 2, 2)));
            this.dkObjętośćBryły = (dkPolePodstawy * dkWysokośćBryły / 3);
            this.dkPowierzchniaBryły = (dkPolePodstawy + dkPoleBoku);
        }
        public override void dkWykreśl()
        {
            Pen dkPióro = new Pen(this.dkKolor_linii, this.dkGrubość_linii);
            dkPióro.DashStyle = this.dkStyl_linii;
            //wykreślenie podłogi i sufitu
            dkRysownica.DrawEllipse(dkPióro, this.dkXsP - this.dkOś_duża / 2,
                this.dkYsP - this.dkOś_mała / 2,
                this.dkOś_duża, this.dkOś_mała);
            dkRysownica.DrawLine(dkPióro, dkXsP - dkOś_duża / 2, dkYsP, dkXsS, dkYsS); //dobrze
            dkRysownica.DrawLine(dkPióro, dkXsP + dkOś_duża / 2, dkYsP, dkXsS, dkYsS); //dobrze
            //wykreślenie na ścianiebocznej tego czegoś
            for (int dki = 0; dki < dkStopieńWielokątaPodstawy; dki++)
            {
                dkRysownica.DrawLine(dkPióro, dkWielokątPodłogi[dki], dkSufit);
            }
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
            for (int dki = 0; dki < dkStopieńWielokątaPodstawy; dki++)
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
            for (int dki = 0; dki < dkStopieńWielokątaPodstawy; dki++)
            {
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * 
                    Math.Cos(Math.PI * (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * 
                    Math.Sin(Math.PI * (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
            }
            dkWykreśl();
        }
        public override void dkPrzesuńDoNowegoXY(int dkx, int dky)
        {   /*Wymazuje poprzednią figurę, ustawia wszsytkieparametry na nowe, podane z klasy głownek
            a następnie oblicza wartości owej figury i ją kreśli*/
            dkWymaż();
            dkRysownica.Clear(dkKolorTła);
            this.dkXsP = dkx;
            this.dkYsP = dky + dkWysokośćBryły;
            this.dkXsS = dkx;
            this.dkYsS = dky;
            dkSufit = new Point(dkXsS, dkYsS);
            for (int dki = 0; dki < dkStopieńWielokątaPodstawy; dki++)
            {
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * 
                    Math.Cos(Math.PI * (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * 
                    Math.Sin(Math.PI * (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
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
        public override void dkUstawStopieńWielokąta(int dkStopień)
        {
            dkStopieńWielokątaPodstawy = dkStopień;
            dkKątMiędzyWierzchołkami = 360 / dkStopień;
            this.dkKątPołożenia = 0f;
            //utworzenie egzemplarzy dla tablic wierzchołków wielokąta podłogi
            this.dkWielokątPodłogi = new Point[dkStopień + 1];
            //utworzenie egzemlarzy punktów wierzchołków wielokąta podłogi
            //wyznaczenie współrzędnych wierzchołków wielokąta podłogi
            for (int dki = 0; dki <= dkStopień; dki++)
            {
                dkWielokątPodłogi[dki] = new Point();
                dkWielokątPodłogi[dki].X = (int)(this.dkXsP + dkOś_duża / 2 * Math.Cos(Math.PI * 
                    (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
                dkWielokątPodłogi[dki].Y = (int)(this.dkYsP + dkOś_mała / 2 * Math.Sin(Math.PI * 
                    (dkKątPołożenia + dki * dkKątMiędzyWierzchołkami) / 180f));
            }
        }
        public override void dkObliczeniePolaObjętościItp()
        {
            //obliczenie objętości i pola powierzchni figury
            float dkPolePodstawy = (float)(Math.PI*Math.Pow(dkOś_duża/2,2));
            float dkPoleBoku = (float)(Math.Sqrt(Math.Pow(dkWysokośćBryły,2) + Math.Pow(dkOś_duża/2,2)));
            this.dkObjętośćBryły = (dkPolePodstawy * dkWysokośćBryły / 3);
            this.dkPowierzchniaBryły = (dkPolePodstawy + dkPoleBoku);
        }
    }

}
