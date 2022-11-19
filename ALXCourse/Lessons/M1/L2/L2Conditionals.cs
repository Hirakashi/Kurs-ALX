namespace ALXCourse.Lessons.M1.L2
{
    public class L2Conditionals
    {
        public static void Run()
        {
            Console.Write("Enter a number:");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Enter lower limit: ");
            var lowerLimit = int.Parse(Console.ReadLine());
            Console.Write("Enter upper limit: ");
            var upperLimit = int.Parse(Console.ReadLine());
            IsEven(x);
            IsBetween(x, lowerLimit, upperLimit);

        }
        private static void IsEven(int x)
        {
            if (x % 2 == 0)
                Console.WriteLine($"Number {x} is even.");
            else
                Console.WriteLine($"Number {x} is odd.");
        }
        private static void IsBetween(int x, int lowerLimit, int upperLimit)
        {
            if (x < lowerLimit)
                Console.WriteLine($"Number {x} is lower than {lowerLimit}!");
            else if (x >= lowerLimit && x <= upperLimit)
                Console.WriteLine($"Number {x} is between {lowerLimit} and {upperLimit}!");
            else
                Console.WriteLine($"Number {x} is higher than {upperLimit}!");
        }
    }
}
