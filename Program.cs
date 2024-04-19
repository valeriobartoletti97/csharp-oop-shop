namespace csharp_oop_shop
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Product chitarra = new Product("chitarra","miglior chitarra del mondo");
            Console.WriteLine($"Il codice prodotto è {chitarra.Code}");
            chitarra.SetPrice(22);
            chitarra.GetOriginalPrice();
            chitarra.GetIvaPrice();
            chitarra.GetCodeAndName();
            chitarra.GetCode8();
        }
    }

    //CLASSE PRODOTTO
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
        public void SetPrice(decimal price)
        {
            this.price = price;
        }
        public void GetOriginalPrice()
        {
           Console.WriteLine($"Il costo del prodotto senza IVA è {this.price} euro");
        }
        public void GetIvaPrice()
        {
            decimal ivaPrice = this.price + (this.price * this.iva);
            Console.WriteLine($"Il costo del prodotto con IVA al 22% è {ivaPrice} euro");
        }
        public void GetCodeAndName()
        {
            string fullName = string.Join("_", this.code,this.name);
            Console.WriteLine($"Il nome completo del prodotto è {fullName}");
        }
        public void GetCode8()
        {
            string myString = this.code.ToString();
            string newString = myString.PadLeft(8, '0');
            Console.WriteLine($"Il codice assoluto del prodotto è {newString}");
        }
        //COSTRUTTORE
        public Product(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.code = SetCode();
            this.iva = 0.22m;
        }
    }
}
