namespace csharp_oop_shop
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Product newProduct = new Product();
        }
    }
    public class Product
    {

        //VARIABILI E PROPRIETA
        private int code;
        public int Code { get { return code; } }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int iva { get; set; }

        //setto il codice automaticamente
        private int SetCode()
        {
            System.Random rnd = new System.Random();
            int number = rnd.Next(0, 1001);
            return number;
        }

        public Product()
        {
            this.code = SetCode();
            Console.WriteLine($"Il codice prodotto è {code}");
        }
    }
}
