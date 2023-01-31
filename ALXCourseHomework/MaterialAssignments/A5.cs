

namespace ALXCourseHomework.MaterialAssignments
{
    internal class A5
    {
        public static void Run()
        {
            Console.Write("Podaj rozmiar macierzy: ");
            int a = int.Parse(Console.ReadLine());
            int[,] macierz = new int[a, a];
            for (int i = 0; i < a-1; i++) 
            { for (int j = 0; j < a-1; j++)
                {
                    if (i == j)
                        macierz[i, j] = 1;
                    else
                        macierz[i, j] = 0;
                    Console.Write($"{macierz[i, j]} ");
                }
            Console.WriteLine();
            }
        }

        public static void Run1()
        {
            string[] towary = new string[] { "Imbusy", "Nasadki", "Młotek", };
        }
    }
}
