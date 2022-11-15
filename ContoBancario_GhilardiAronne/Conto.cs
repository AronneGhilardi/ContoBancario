using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoBancario_GhilardiAronne
{
    class Conto
    {
        private string utente;
        private int nrconto;
        private string banca;
        private float saldo;

        private void setUtente(string utente)
        {
            this.utente = utente;
        }

        private void setNrConto(int nrconto)
        {
            this.nrconto = nrconto;
        }

        private void setBanca(string banca)
        {
            this.banca = banca;
        }

        private void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }

        public float getSaldo()
        {
            return saldo;
        }

        public Conto(string utente, int nrconto, string banca, float saldo)
        {
            setUtente(utente);
            setNrConto(nrconto);
            setBanca(banca);
            setSaldo(saldo);
        }

        public void Deposita(float delta)
        {
            if(delta <= 0)
            {
                throw new Exception("Non puoi depositare un cifra negativa!"); 
            }
            if(getSaldo() + delta >= 0)
            {
                setSaldo(getSaldo() + delta);
            }
        }

        public void Preleva(float delta)
        {
            if(delta <= 0)
            {
                throw new Exception("Non puoi prelevare un cifra negativa!");
            }
            if(getSaldo() - delta >= 0)
            {
                setSaldo(getSaldo() + delta);
            }
            else
            {
                throw new Exception("Sei un poveraccio! Non puoi prelevare più soldi di quanti ne possiedi.");
            }
        }

        public void Bonifico(Conto utente, float delta)
        {
            Preleva(delta);
            utente.Deposita(delta);
        }
    }
}
