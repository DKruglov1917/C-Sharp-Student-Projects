using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Projekt3_Kruhlov_48720
{
    class dkWielościany : dkbryła_abstrakcyjna
    {//deklaracja zmiennych globalnych dla danej klasy
        protected int dkStopieńWielokątaPodstawy;
        public dkWielościany(int dkR, int dkStopieńWielokątaPodstawy, Color dkKolorLinii, DashStyle dkStylLinii, int dkGrubośćLinii) :
            base(dkKolorLinii, dkStylLinii, dkGrubośćLinii)
        {//odziedziczenie wartości zmiennych z klasy nadrzędnej
            dkPromieńBryły = dkR;
            this.dkStopieńWielokątaPodstawy = dkStopieńWielokątaPodstawy;
        }
        public override void dkWykreśl() { /*pusta implementacja */ }
        public override void dkWymaż() { /*pusta implementacja */ }
        public override void dkObróć_i_wykreśl(float dkrotateAngle) { /*pusta implementacja */ }
        public override void dkPrzesuńDoNowegoXY(int dkx, int dky) { /*pusta implementacja */ }
        public override void dkZmianaPromieniaBryły(int dkPromień) { /*pusta implementacja */ }
        public override void dkUstawWysokość(int dkWysokość) { /*pusta implementacja */ }
        public override void dkUstawStopieńWielokąta(int dkStopień) { /*pusta implementacja */ }
        public override void dkUstawKątNachyleniaStożka(int dkX) { /*pusta implementacja */ }
        public override void dkObliczeniePolaObjętościItp() { /*pusta implementacja */ }
    }
}
