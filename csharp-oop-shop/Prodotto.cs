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
        public int getCodice()
        {
            Random codiceRandom = new Random();
            int codice = codiceRandom.Next();
            return codice;
        }

        public string getDescrizione()
        {
            return this.descrizione;
        }

        public string getNome()
        {
            return this.nome;
        }

        // SETTERS

        public float setPrezzo()
        {
            return (float)this.prezzo;
        }

        // METODI

        public float prezzoConIva()
        {
            float iva = 1.22f * prezzo;
            return iva;
        }




    }
}
