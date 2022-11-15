using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoBancario_GhilardiAronne
{
    class Sportello
    {
        private int _nrsportello;
        private string _indirizzo;
        private string _banca;
        private bool _stato;
        private Bancomat seriale;
        string[] bloccare = new string[1000];
        public int NrSportello;
        public string Indirizzo;
        public string Banca;

        public Sportello(int nrsportello, string indirizzo, string banca, bool stato)
        {
            NrSportello = nrsportello;
            Indirizzo = indirizzo;
            Banca = banca;
        }

        public bool getStato()
        {
            return _stato;
        }

        private void setStato(bool stato)
        {
            this._stato = stato;
        }

        public void Inserisci(Bancomat carta, bool stato)
        {
            bool check = false;

            for (int i = 0; i != 1000; i++)
            {
                if (seriale.getNrConto() = bloccare[i])
                {
                    Console.WriteLine("Carta bloccata!");
                    setStato(true);
                    check = true;
                }
            }
            if (check == false)
            {
                setStato(false);
            }
        }

        public void Espelli(Bancomat carta, bool stato)
        {
            setStato(true);
        }
    }
}
