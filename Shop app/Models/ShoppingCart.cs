using System.Security.Cryptography.X509Certificates;

namespace ShopApp.Models
{
    internal class ShoppingCart
    {
        public List<Product> Products = new List<Product>();

        public decimal GetPrice()
        {
            return Products.Sum(x => x.Price);

        }
        public void AddProduct()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            var newProduct = new Product{ ProductName = name, Price = price };
            Products.Add(newProduct);
        }

        public void ClearCart()
        {
            Products.Clear();
        }
        public void PresentCart()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"Product: {product.ProductName}");
                Console.WriteLine($"Price: {product.Price}");
            }
        }
    }
}   
