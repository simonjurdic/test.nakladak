using System;
using System.Collections.Generic;
using System.Text;

namespace test.Nakladak
{
    public class Nakladak
    {


        public string Jmeno { get; set; }
        public int Nosnost { get; set; }
        public int PalivoVNadrzi { get; set; }
        public int SpotrebaPaliva { get; set; }
        public int CelkovaUjetaVzdalenost { get; set; }
        public int Naklad { get; set; }
        public Nakladak()
        {
            Jmeno = " ";
            Nosnost = 25000;
            PalivoVNadrzi = 1000;
            SpotrebaPaliva = 35;
            CelkovaUjetaVzdalenost = 2000;
            Naklad = 0;

        }

        public void Nalozit()
        {
            Naklad += 1000;
            if (Naklad > 25000)
            {
                Naklad = 25000;
            }


        }

        public void Vylozit()
        {
            Naklad -= 1000;
            if (Naklad < 0)
            {
                Naklad = 0;
            }
        }

        public void Natankovat()
        {
            PalivoVNadrzi += 1000;
            if(PalivoVNadrzi > 3000)
            {
                PalivoVNadrzi = 3000;
            }

        }

        public void Jet()
        {
            PalivoVNadrzi -= SpotrebaPaliva;
            if (PalivoVNadrzi < 0)
            {
                PalivoVNadrzi = 0;
            }
        }


    }

}
