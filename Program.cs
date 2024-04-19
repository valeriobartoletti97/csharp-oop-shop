namespace csharp_oop_shop
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Product chitarra = new Product("Chitarra","miglior chitarra del mondo");
            Console.WriteLine($"Il codice prodotto è {chitarra.Code}");
            chitarra.SetPrice(100);
            chitarra.GetOriginalPrice();
            chitarra.GetIvaPrice();
            chitarra.GetCodeAndName();
            chitarra.GetCode8();

            //CREO PRODOTTI DA UN ARRAY DEFINITTO
            string[] shopProducts = { "Batteria", "Basso", "Tastiera" };
            Shop.InsertProducts(shopProducts);
        }
    }
}
