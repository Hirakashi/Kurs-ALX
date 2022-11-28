using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class ShoppingApp
    {
        public static void Run()
        {
            Console.WriteLine("Shopping service running...");
            char appStatus = 'r';
            ShoppingCart shoppingCart = new ShoppingCart();
            while (appStatus == 'r')
            {
                Console.WriteLine("What would you like to do?\n a = Add Product | s = Show Cart | c = clear Cart | other = exit");
                appStatus = char.Parse(Console.ReadLine());
                switch (appStatus)
                {
                    case 'a':
                        shoppingCart.AddProduct();
                        appStatus = 'r';
                        break;
                    case 's':
                        shoppingCart.PresentCart();
                        Console.WriteLine($"Total Price: {shoppingCart.GetPrice()}");
                        appStatus = 'r';
                        break;
                    case 'c':
                        shoppingCart.ClearCart();
                        Console.WriteLine("Cart cleared.");
                        appStatus = 'r';
                        break;
                    default:
                        Console.WriteLine("Exiting...");
                        break;
                }
            }
        }
    }
}
