using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        //VARIABILI E PROPRIETA
        private int code;
        public int Code { get { return code; } }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal iva { get; set; }

        //SETTO IL CODICE AUTOMATICAMENTE
        private int SetCode()
        {
            System.Random rnd = new System.Random();
            int number = rnd.Next(0, 1001);
            return number;
        }
        //SETTO IL PREZZO
        public void SetPrice(decimal price)
        {
            this.price = price;
        }
        //OTTIENI IL PREZZO DEL PRODOTTO ORIGINALE
        public void GetOriginalPrice()
        {
            Console.WriteLine($"Il costo del prodotto senza IVA è {this.price} euro");
        }
        //OTTIENI IL PREZZO CON IVA
        public void GetIvaPrice()
        {
            decimal ivaPrice = this.price + (this.price * this.iva);
            Console.WriteLine($"Il costo del prodotto con IVA al 22% è {ivaPrice} euro");
        }
        //CODICE E NOME CONCATENATI
        public void GetCodeAndName()
        {
            string fullName = string.Join("_", this.code, this.name);
            Console.WriteLine($"Il nome completo del prodotto è {fullName}");
        }
        //CODICE SAMPATO CON ZERI
        public void GetCode8()
        {
            string myString = this.code.ToString();
            string newString = myString.PadLeft(8, '0');
            Console.WriteLine($"Il codice assoluto del prodotto è {newString}");
        }

        //ARRAY DI PRODOTTI NEL NEGOZIO

        private static Product[] productsAvailable = new Product[4];

        //COSTRUTTORE
        public Product(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.code = SetCode();
            this.iva = 0.22m;
            for (int i = 0; i < productsAvailable.Length; i++)
            {
                if (productsAvailable[i] == null)
                {
                    productsAvailable[i] = this;
                    break;
                }
            }
        }

        //COSTRUTTORE CON PREZZO

        public Product(string name, string description, decimal price)
        {
            this.name = name;
            this.description = description;
            this.code = SetCode();
            this.iva = 0.22m;
            this.price = price;
            for (int i = 0; i < productsAvailable.Length; i++)
            {
                if (productsAvailable[i] == null)
                {
                    productsAvailable[i] = this;
                    break;
                }
            }
        }
    }

    //CLASSE SHOP
    public static class Shop
    {
        //DATO UN ARRAY,INSERISCE I PRODOTTI DEL NEGOZIO CHIEDENDO IL PREZZO
        public static void InsertProducts(string[] product)
        {
            foreach (string el in product)
            {
                Console.WriteLine($"Inserisci il prezzo in euro per {el}:");
                decimal newPrice = Convert.ToInt32(Console.ReadLine());
                new Product($"{el}", $"miglior {el}", newPrice);
            }
        }
    }
}
