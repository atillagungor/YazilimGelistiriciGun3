namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;   //Mobilya
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Product product1 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            Console.WriteLine(product.ProductName);

            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);

            //ProductManager productManager1 = new ProductManager();

            //int sayi = 100;
            //productManager1.BiseyYap(sayi);
            //Console.WriteLine(sayi);
        }
    }
}