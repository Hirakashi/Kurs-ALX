
namespace ALXCourse.Lessons.Assignments.M1.Classes
{
    public class Notebook
    {
        public string Color;
        public int NumOfPages;
        public string CoverMaterial;
        
        public Notebook(int numOfPages)
        {
            NumOfPages = numOfPages;
        }
        
        public Notebook(string color, int numOfPages, string coverMaterial)
        {
            Color = color;
            NumOfPages = numOfPages;
            CoverMaterial = coverMaterial;
        }

        public static void Throw()
        {
            Console.WriteLine("Thud!");
        }
        
        public static void TearPage()
        {
            Console.WriteLine("Thrrr!");
        }
    }
}
