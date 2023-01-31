
namespace ALXCourseHomework.MaterialAssignments
{
    public class A3
    {
        public static void Run()
        {
            Console.Write("Wpisz cenę: ");
            var price = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nIf:");
            if (price >= 100)
                Console.WriteLine($"Rabat 15%! -{price - (price * 0.85)}\n");
            else if (price >= 60)
                Console.WriteLine($"Rabat 5%! -{price - (price * 0.95)}\n");
            else
                Console.WriteLine("Niestety nie przysługuję rabat.\n");

            Console.WriteLine("Switch:");
            switch (price)
            {
                case >= 100:
                    Console.WriteLine($"Rabat 15%! -{price - (price * 0.85)}\n");
                    break;
                case >= 60:
                    Console.WriteLine($"Rabat 5%! -{price - (price * 0.95)}\n");
                    break;
                default:
                    Console.WriteLine("Niestety nie przysługuję rabat.\n");
                    break;

            }
        }
    }
}
