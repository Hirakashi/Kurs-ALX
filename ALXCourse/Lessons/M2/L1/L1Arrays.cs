
namespace ALXCourse.Lessons.M2.L1
{
    public class L1Arrays
    {
        public static void Run()
        {
            int[] intarray = { 1, 2, 3, 4, 5, 6, };
            int[] intarray1 = new int[5];
            intarray1[2] = 178;
            ShowArray(intarray);
            ShowArray(intarray1);
            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };
        }
        public static void Run1()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";
            ShowArray(shoppingArray);
            shoppingArray[1] = "eggs";
            ShowArray(shoppingArray);
            shoppingArray[2] = "butter";
            ShowArray(shoppingArray);
            shoppingArray[3] = "apples";
            ShowArray(shoppingArray);
            shoppingArray[4] = "Bananas";
            ShowArray(shoppingArray);
            shoppingArray[5] = "Peppers";
            ShowArray(shoppingArray);
            shoppingArray[3] = "";
            ShowArray(shoppingArray);
            shoppingArray[1] = "";
            ShowArray(shoppingArray);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        public static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        public static void ShowMatrix(int[,] matrix)
        {
            int a = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = a;
                    a++;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void Run2()
        {
            int[,] intMatrix1 = new int[16, 10];
        ShowMatrix(intMatrix1);
        }
    }
}
