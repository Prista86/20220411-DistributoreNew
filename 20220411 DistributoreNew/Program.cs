using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220411_DistributoreNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int euro = 0;
            string scelta = "";
            int sceltaNum = 0;

            Utente utente = new Utente();
            utente.Denaro = 0;
            utente.Resto = 0;

            Distrubutore distributore = new Distrubutore();










            while (euro < 1)
            {
                Console.Clear();
                Console.WriteLine($"Cosa vuoi fare? Al momento hai {utente.Denaro} euro. 'Scegli digitando il numero corretto'");
                Console.WriteLine("A) - Inserire Moneta");
                Console.WriteLine("B) - Prelevare un prodotto");
                Console.WriteLine("C) - Caricare la macchinetta");
                Console.WriteLine("D) - Inserire un prodotto");
                //Console.WriteLine("E) - Tirare un calcio alla macchinetta");
                scelta = Console.ReadLine();
                if (scelta == "A")
                {
                    Console.WriteLine("Scrivi il numero di monete che vuoi inserire nella macchinetta");
                    utente.Denaro += int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ottimo ora hai ben {utente.Denaro} euro.");
                    Console.ReadKey();
                }
                else if (scelta == "B")
                {
                    //if (/*Prodotto non caricato non puoi scegliere nulla*/)
                    //{

                    //}
                    if (utente.Denaro > 0)
                    {
                        Console.WriteLine();   
                        for (int i = 0; i < distributore.availableProducts.Count; i++)
                        {
                            Console.WriteLine($"ID: {i} , Nome Prodotto: {distributore.availableProducts[i].prodotto.Nome} Quantita': {distributore.availableProducts[i].prodotto.Quantità} Costo: {distributore.availableProducts[i].prodotto.Costo}");
                        }
                        Console.WriteLine("Tutti i prodotti sono a video");

                        Console.WriteLine("Quale prodotto vuoi prelevare? 'inserire il numero ID del prodotto scelto'");
                        sceltaNum= int.Parse(Console.ReadLine());
                        distributore.availableProducts[sceltaNum].prodotto.Quantità--;
                        
                        if (utente.Denaro >= distributore.availableProducts[sceltaNum].prodotto.Costo) 
                        {
                            utente.Denaro -= distributore.availableProducts[sceltaNum].prodotto.Costo;
                            distributore.availableProducts[sceltaNum].prodotto.Quantità--;
                            Console.WriteLine("Ottimo hai ottenuto il prodotto scelto");
                        }
                        else
                        {
                            
                            Console.WriteLine("Mi dispiace non te lo puoi permettere");
                        }


                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Mi dispiace devi inserire almeno 1 euro");
                        Console.ReadKey();

                    }




                }
                else if (scelta == "C")
                {
                    distributore.CreateDefaultProducts();
                    Console.WriteLine("Macchinetta caricata con prodotti predefiniti");
                    Console.ReadKey();
                }
                else if (scelta == "D")
                {
                    distributore.AddProdotto();
                }

            }
        }
    }
}
