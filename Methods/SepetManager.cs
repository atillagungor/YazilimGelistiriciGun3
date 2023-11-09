using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi: " + product.Name);
        }

        public void Add2(string productName, string productDescription, double price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi: " + productName);
        }
    }
}
