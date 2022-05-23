using System;
using System.Collections.Generic;
using System.Text;

namespace test.nakladak
{
    public class Nakladak
    {
        public int nosnost;
        public int palivovnadrzi;
        public int spotrebapaliva;
        public int celkovaujetavzdalenost;
        public int naklad;

        public string Jmeno { get; set; }
        public int Nosnost { get; set; }
        public int PalivoVNadrzi { get; set; }
        public int SpotrebaPaliva { get; set; }
        public int CelkovaUjetaVzdalenost { get; set; }
        public int Naklad { get => naklad; }

        public Nakladak()
        {
            Jmeno = " ";
            Nosnost = 25000;
            PalivoVNadrzi = 1000;
            SpotrebaPaliva = 35;
            CelkovaUjetaVzdalenost = 2000;
            naklad = 0;

        }

        public void Nalozit()
        {
            naklad += 1000;
            if (naklad > 25000)
            {
                naklad = 25000;
            }


        }

        public void Vylozit()
        {
            naklad -= 1000;
            if (naklad < 0)
            {
                naklad = 0;
            }
        }

        public void Natankovat()
        {
            palivovnadrzi += 1000;
            if(palivovnadrzi > 3000)
            {
                palivovnadrzi = 3000;
            }

        }

        public void Jet()
        {
            palivovnadrzi -= 500;
            if (palivovnadrzi < 0)
            {
                palivovnadrzi = 0;
            }
        }


    }

}
