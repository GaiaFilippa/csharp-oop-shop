/*Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
Un prodotto è caratterizzato da:
- codice (numero intero)
- nome
- descrizione
- prezzo
- iva

Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter
(o eventualmente le properties) ed eventuali altri metodi di “utilità” per fare in modo che:

- Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
- Il codice prodotto sia accessibile solo in lettura
- Gli altri attributi siano accessibili sia in lettura che in scrittura
- Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
- Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.
 */


using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto("Prodotto 1", "Questo è il primo prodotto", 12.50f);

Console.WriteLine("Questo prodotto è il: " + prodotto1.getNome());
Console.WriteLine("Descrizione del prodotto: " + prodotto1.getDescrizione());
Console.WriteLine("Questo è il prezzo del prodotto: " + prodotto1.setPrezzo() + " euro");
Console.WriteLine("Questo è il prezzo con iva: " + prodotto1.prezzoConIva() + " euro");
Console.WriteLine("Codice: " + prodotto1.getCodice());