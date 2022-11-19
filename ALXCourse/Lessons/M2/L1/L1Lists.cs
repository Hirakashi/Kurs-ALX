
namespace ALXCourse.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppingList = new List<string>();
            
            shoppingList.Add("Milk");
            ShowList(shoppingList);
            shoppingList.Add("Eggs");
            ShowList(shoppingList);
            shoppingList.Add("Bread");
            ShowList(shoppingList);
            shoppingList.Add("Rice");
            ShowList(shoppingList);
            shoppingList.Add("Tofu");
            ShowList(shoppingList);
            
            shoppingList.Remove("Tofu");
            ShowList(shoppingList);
            shoppingList.Remove("Bread");
            ShowList(shoppingList);
            shoppingList.Remove("Eggs");
            ShowList(shoppingList);
            shoppingList.Remove("Rice");
            ShowList(shoppingList);
            shoppingList.Remove("Milk");
            ShowList(shoppingList);
        }
        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
