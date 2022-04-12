using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220411_DistributoreNew
{
    public class Prodotto
    {
        public string Nome { get; set; }
        public int Quantità { get; set; }
        public string Tipologia { get; set; }

        public int Costo { get; set; }

        public void MiBlocco()
        {

        }




    }

    public class Distrubutore
    {
        public List<AvailableProducts> availableProducts = new List<AvailableProducts>();

        public Distrubutore()
        {

        }

        public void CreateDefaultProducts()
        {
            Patatine patatina1 = new Patatine();
            patatina1.Nome = "Classiche";
            patatina1.Quantità = 5;
            patatina1.Tipologia = "patatina";
            patatina1.MateriaPrima = "Patata";
            patatina1.Costo = 1;
            AvailableProducts ap = new AvailableProducts();
            ap.prodotto = patatina1;
            ap.Quantity = 10;
            this.availableProducts.Add(ap);

            Patatine patatina2 = new Patatine();
            patatina2.Nome = "PopCorns";
            patatina2.Quantità = 10;
            patatina2.Tipologia = "PopCorns";
            patatina2.MateriaPrima = "Semi di Mais";
            patatina2.Costo = 1;
            AvailableProducts ap2 = new AvailableProducts();
            ap2.prodotto = patatina2;
            ap2.Quantity = 10;
            this.availableProducts.Add(ap2);


            Bibite bibita1 = new Bibite();
            bibita1.Nome = "CocaCola";
            bibita1.Quantità = 5;
            bibita1.Tipologia = "Bibita";
            bibita1.GasNat = "Gasata";
            bibita1.Costo = 1;
            AvailableProducts ap3 = new AvailableProducts();
            ap3.prodotto = bibita1;
            ap3.Quantity = 20;
            this.availableProducts.Add(ap3);

            Bibite bibita2 = new Bibite();
            bibita2.Nome = "The";
            bibita2.Quantità = 5;
            bibita2.Tipologia = "Infuso";
            bibita2.GasNat = "Naturale";
            bibita2.Costo = 1;
            AvailableProducts ap4 = new AvailableProducts();
            ap4.prodotto = bibita2;
            ap4.Quantity = 20;
            this.availableProducts.Add(ap4);

            Merendine merendina1 = new Merendine();
            merendina1.Nome = "Barretta Novi";
            merendina1.Quantità = 5;
            merendina1.Tipologia = "Cioccolatosa";
            merendina1.TipoZucchero = "Bianco";
            merendina1.Costo = 1;
            AvailableProducts ap5 = new AvailableProducts();
            ap5.prodotto = merendina1;
            ap5.Quantity = 20;
            this.availableProducts.Add(ap5);

            Merendine merendina2 = new Merendine();
            merendina2.Nome = "Fiesta";
            merendina2.Quantità = 5;
            merendina2.Tipologia = "Briosches";
            merendina2.TipoZucchero = "Canna";
            merendina2.Costo = 1;
            AvailableProducts ap6 = new AvailableProducts();
            ap6.prodotto = merendina2;
            ap6.Quantity = 20;
            this.availableProducts.Add(ap6);
        }
        public void AddProdotto()
        {
            Console.WriteLine("Che prodotto vuoi inserire? 'Inserire la lettera corrispondente.'");
            Console.WriteLine("A) - Patatine");
            Console.WriteLine("B) - Bibita");
            Console.WriteLine("C) - Merendina");
            string scelta = Console.ReadLine();
            if (scelta == "A")
            {
                Patatine patatina = new Patatine();
                Console.WriteLine("Come si chiamano le patatine?");
                patatina.Nome = Console.ReadLine();
                Console.WriteLine("Che quantità ne inserisci?");
                patatina.Quantità = int.Parse(Console.ReadLine());
                Console.WriteLine("Che tipologia è?");
                patatina.Tipologia = Console.ReadLine();
                Console.WriteLine("Quele è la materia prima?");
                patatina.MateriaPrima = Console.ReadLine();
                Console.WriteLine("Quanto è il costo unitario?");
                patatina.Costo = int.Parse(Console.ReadLine());
                AvailableProducts ap = new AvailableProducts();
                ap.prodotto = patatina;
                ap.Quantity = 10;
                this.availableProducts.Add(ap);
            }
            else if (scelta == "B")
            {
                Bibite bibita = new Bibite();
                Console.WriteLine("Come si chiama la bibita ?");
                bibita.Nome = Console.ReadLine();
                Console.WriteLine("Che quantità ne inserisci?");
                bibita.Quantità = int.Parse(Console.ReadLine());
                Console.WriteLine("Che tipologia è?");
                bibita.Tipologia = Console.ReadLine();
                Console.WriteLine("E' gasata o naturale?");
                bibita.GasNat = Console.ReadLine();
                Console.WriteLine("Quanto è il costo unitario?");
                bibita.Costo = int.Parse(Console.ReadLine());

                AvailableProducts ap = new AvailableProducts();
                ap.prodotto = bibita;
                ap.Quantity = 10;
                this.availableProducts.Add(ap);
            }
            else if (scelta == "C")
            {
                Merendine merendina = new Merendine();
                Console.WriteLine("Come si chiama la merendina?");
                merendina.Nome = Console.ReadLine();
                Console.WriteLine("Che quantità ne inserisci?");
                merendina.Quantità = int.Parse(Console.ReadLine());
                Console.WriteLine("Che tipologia è?");
                merendina.Tipologia = Console.ReadLine();
                Console.WriteLine("Che zucchero contiene?");
                merendina.TipoZucchero = Console.ReadLine();
                Console.WriteLine("Quanto è il costo unitario?");
                merendina.Costo = int.Parse(Console.ReadLine());
                AvailableProducts ap6 = new AvailableProducts();
                ap6.prodotto = merendina;
                ap6.Quantity = 20;
                this.availableProducts.Add(ap6);
            }
        }

        public class AvailableProducts
        {
            public int Quantity;
            public Prodotto prodotto;

        }
    }
    public class Patatine : Prodotto
    {
        public string MateriaPrima { get; set; }
    }

    public class Bibite : Prodotto
    {
        public string GasNat { get; set; }
    }

    public class Merendine : Prodotto
    {
        public string TipoZucchero { get; set; }
    }


    public class Utente
    {
        public int Denaro { get; set; }
        public int Resto { get; set; }
    }
}
