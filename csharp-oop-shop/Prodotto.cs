using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // ATTRIBUTI
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private float iva;


        // STATI


        // COSTRUTTORE
        public Prodotto(string nome, string descrizione,float prezzo)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }

        // GETTERS
        public int GetCodice()
        {
            Random codiceRandom = new Random();
            int codice = codiceRandom.Next();
            return codice;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public string GetNome()
        {
            return this.nome;
        }

        // SETTERS

        public float SetPrezzo()
        {
            return (float)this.prezzo;
        }

        // METODI

        public float PrezzoConIva()
        {
            float iva = 1.22f * prezzo;
            return iva;
        }

        public string ConcatenaNomeECodice()
        {
            string nomeECodice = nome + codice;
            return nomeECodice;
        }


    }
}
