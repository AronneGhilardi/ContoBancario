using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoBancario_GhilardiAronne
{
    class Bancomat
    {
        private int _nrconto;
        private int _pin;
        private Conto conto;

        public Bancomat(int nrconto, int pin, Conto contocorrente)
        {
            nrconto = nrconto;
            pin = pin;
            conto = contocorrente;
        }

        public int NrConto
        {
            get
            {
                return _nrconto;
            }

            set
            {
                _nrconto = value;
            }
        }

        public int Pin;

        public void Depositare(float delta, int check)
        {
            if (check == Pin)
            {
                conto.Deposita(delta);
            }
            else
            {
                throw new Exception("Pin errato!");
            }
        }

        public void Prelevare(float delta, int check)
        {
            if (check == Pin)
            {
                conto.Deposita(delta);
            }
            else
            {
                throw new Exception("Pin errato!");
            }
        }

        public void getSaldo(float delta, int check)
        {
            if (check == Pin)
            {
                conto.Deposita(delta);
            }
            else
            {
                throw new Exception("Pin errato!");
            }
        }

        public int getNrConto()
        {
            return _nrconto;
        }
    }
}
