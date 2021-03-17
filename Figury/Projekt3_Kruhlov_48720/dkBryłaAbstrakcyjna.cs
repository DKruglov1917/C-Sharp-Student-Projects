using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Projekt3_Kruhlov_48720.Kruhlov_48720;

namespace Projekt3_Kruhlov_48720
{
    abstract class dkbryła_abstrakcyjna : IComparable<dkbryła_abstrakcyjna>
    {
        public enum dktyp_bryły
        {//stworzenie listy brył geometrycznych(Przechowyje tylko nazwę brył)
            dkbg_walec, dkbg_stożek, dkbg_stożek_pochyły, dkbg_czworościan, dkbg_czworościan_pochyły, dkbg_ostrosłup_czworokątny,
            dkbg_ostrosłup_czworokątny_pochyły, dkbg_ostrosłup_sześciokątny, dkbg_ostrosłup_sześciokątny_pochyły,
            dkbg_graniastosłup_sześciokątny, dkbg_graniastosłup_trójkątny, dkbg_symbol_kryształu
        };
        public dktyp_bryły dkrodzaj_bryły;
        protected int dkXsS, dkYsS; //środek Sufitu
        protected int dkXsP, dkYsP; //środek Podłogi
        protected int dkKątPochylylenia;
        protected int dkWysokośćBryły;
        protected int dkPromieńBryły;
        protected int dkGrubość_linii;
        protected Color dkKolor_linii;
        protected DashStyle dkStyl_linii;
        protected bool dkKierunekObrotu; //false w prawo...
        protected float dkPowierzchniaBryły;
        protected float dkObjętośćBryły;
        //deklaracja konstruktora klasy BryłaAbstrakcyjna
        public dkbryła_abstrakcyjna(Color dkKolorLinii, DashStyle dkStylLinii, int dkGrubośćLinii)
        {
            this.dkKolor_linii = dkKolorLinii;
            this.dkStyl_linii = dkStylLinii;
            this.dkGrubość_linii = dkGrubośćLinii;
        }
        public dkbryła_abstrakcyjna(int dkPromień, Color dkKolorLinii, DashStyle dkStylLinii, int dkGrubośćLinii)
        {
            this.dkPromieńBryły = dkPromień;
            this.dkKolor_linii = dkKolorLinii;
            this.dkStyl_linii = dkStylLinii;
            this.dkGrubość_linii = dkGrubośćLinii;
        }
        //deklaracja metod abstrakcyjnych
        public abstract void dkWykreśl();
        public abstract void dkWymaż();
        public abstract void dkObróć_i_wykreśl(float dkrotateAngle);
        public abstract void dkPrzesuńDoNowegoXY(int dkx, int dky);
        public abstract void dkZmianaPromieniaBryły(int dkPromień);
        public abstract void dkUstawWysokość(int dkWysokość);
        public abstract void dkUstawStopieńWielokąta(int dkStopień);
        public abstract void dkUstawKątNachyleniaStożka(int dkX);
        public abstract void dkObliczeniePolaObjętościItp();
        public void dkUstawAtrybutyGraficzne(Color dkKolorLinii, DashStyle dkStylLinii, int dkGrubośćLinii)
        {
            this.dkKolor_linii = dkKolorLinii;
            this.dkStyl_linii = dkStylLinii;
            this.dkGrubość_linii = dkGrubośćLinii;
        }
        public void dkUstawAtrybutyGraficzne(Color dkKolorLinii)
        {
            this.dkKolor_linii = dkKolorLinii;
        }
        public void dkUstawAtrybutyGraficzne(DashStyle dkStylLinii)
        {
            this.dkStyl_linii = dkStylLinii;
        }
        public void dkUstawAtrybutyGraficzne(int dkGrubośćLinii)
        {
            this.dkGrubość_linii = dkGrubośćLinii;
        }
        public void dkUstawKątNachylenia(int dkKątNachylenia)
        {
            this.dkKątPochylylenia = dkKątNachylenia;
        }
        
        public void dkKierunekWlewo()
        {
            this.dkKierunekObrotu = true;
        }
        public void dkKierunekWprawo()
        {
            this.dkKierunekObrotu = false;
        }
        public int CompareTo(dkbryła_abstrakcyjna dkBryła)
        { //sprawdza zaznaczone przyciski sortujące bryły
            if (dkUchwytFormularza.dkRadioButtonPromień.Checked)
            {
                if (this.dkPromieńBryły > dkBryła.dkPromieńBryły) return 1;
                else if (this.dkPromieńBryły < dkBryła.dkPromieńBryły) return -1;
                else return 0;
            }
            else if (dkUchwytFormularza.dkRadioButtonWysokość.Checked)
            {
                if (this.dkWysokośćBryły > dkBryła.dkWysokośćBryły) return 1;
                else if (this.dkWysokośćBryły < dkBryła.dkWysokośćBryły) return -1;
                else return 0;
            }
            else if (dkUchwytFormularza.dkRadioButtonPole.Checked)
            {
                if (this.dkPowierzchniaBryły > dkBryła.dkPowierzchniaBryły) return 1;
                else if (this.dkPowierzchniaBryły < dkBryła.dkPowierzchniaBryły) return -1;
                else return 0;
            }
            else if (dkUchwytFormularza.dkRadioButtonObjętość.Checked)
            {
                if (this.dkObjętośćBryły > dkBryła.dkObjętośćBryły) return 1;
                else if (this.dkObjętośćBryły < dkBryła.dkObjętośćBryły) return -1;
                else return 0;
            }
            else return 0;
        }
    }
}
