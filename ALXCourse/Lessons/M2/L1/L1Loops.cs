
namespace ALXCourse.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<String> names = new List<string>();
            names.Add("Adrian");
            names.Add("Mateusz");
            names.Add("Monika");
            names.Add("Klaudia");
            names.Add("Katarzyna");
            names.Add("Grzegorz");
            
            foreach(string name in names)
            {
                name.ToLower();
                Console.WriteLine(name);
            }
        }
        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            for (int i = 0 ; i < (numbers.Length); i++)
            {
                Console.WriteLine($"{i}: {numbers[i]}");
            }
            Console.WriteLine();
            for (int i = (numbers.Length -1); i >= 0; i--)
            {
                Console.WriteLine($"{i}: {numbers[i]}");
            }
        }
        public static void RunWhile()
        {
            char c = 'a';
            while (c != 'n')
            {
                Console.WriteLine("You are in the loop...");
                Console.Write("Press n to exit loop: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }
        public static void RunWhile1()
        { 
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine($"{i}: {numbers[i]}");
                i++;
            }
        }
        public static void WhileAdventure()
        {
            while (true)
            {
                Console.Write("___\\o/_________||||");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
                Console.Write("___\\o/_______||||__");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
                Console.Write("___\\o/_____||||____");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
                Console.Write("___\\o/___||||______");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
                Console.Write("___\\o/_||||________");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
                Console.Write("___\\o/-||||________");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
                Console.Write("___\\o/-****________");
                Thread.Sleep(250);
                Console.SetCursorPosition(Console.CursorLeft - 19, Console.CursorTop);
            }
        }
    }
}
