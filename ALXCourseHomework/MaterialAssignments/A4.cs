
namespace ALXCourseHomework.MaterialAssignments
{
    public class A4
    {
        public static void Run()
        {
            double[,] tabela = new double[5, 4]
            {
            {  3.58 ,  5 ,  10 ,  2  },
            {  9.61 ,  5,  25 ,  5 },
            {  8.52 ,  8 ,  18 ,  3  },
            {  10.25 ,  8 ,  36 ,  6 },
            {  6.17 ,  23 ,  4 , 1  },
            };
            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                Console.WriteLine($"Id: {i + 1}");
                double brutto = tabela[i, 0] + (tabela[i, 0] * tabela[i, 1] / 100);
                Console.WriteLine($"Cena brutto: {Math.Round(brutto,2)}");
                Console.WriteLine($"Cena za pudełko: {Math.Round(brutto * tabela[i,2],2)}");
                Console.WriteLine($"Cena całego zasobu w magazynie: {Math.Round(tabela[i,0] * tabela[i,2] * tabela[i,3], 2)}\n");
            }
        }
        public static void Run1()
        {
            Console.Write("Podaj Liczbę: ");            
            double liczba = double.Parse(Console.ReadLine().Replace(".",","));

            Console.WriteLine("Dzielniki:\n");
            for (double i = Math.Round(liczba); i >= 0; i--)
            {
                for (double j = 0.99; j >= 0; j -= 0.01)
                {
                    j = Math.Round(j, 2);
                    double reszta = liczba % (i + j);
                    if (reszta == 0)
                    {
                        Console.WriteLine(i+j);
                    }
                }
            }
        }
    }
}
