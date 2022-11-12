using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments
{
    public class A3ConditionalExpresions
    {
        public static void Run()
        {
            Console.Write("Wpisz cenę: ");
            var price = Double.Parse(Console.ReadLine());
            if (price >= 100)
                Console.WriteLine($"Rabat 15%! -{price - (price * 0.85)}");
            else if (price >= 60)
                Console.WriteLine($"Rabat 5%! -{price - (price * 0.95)}");
            else Console.WriteLine("Niestety nie przysługuję rabat.");
        }
    }
}
