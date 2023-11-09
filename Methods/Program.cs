namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product products = new Product();
            products.Name = "Elma";
            products.Price = 15;
            products.Description = "Amasya elması";

            Product products2 = new Product();
            products2.Name = "Karpuz";
            products2.Price = 80;
            products2.Description = "Diyarbakır karpuzu";

            Product[] products3 = new Product[] { products, products2 };

            //type-safe -- tip güvenli
            foreach (Product product in products3)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------Methods---------");
            //instance
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(products);
            sepetManager.Add2("Armut", "Yeşil armut", 12,10);
            sepetManager.Add2("Elma", "Yeşil elma", 12,9);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 12,8);
        }
    }
}