using ALXCourse.Assignments.M2.L2.Enums;
using ALXCourse.Lessons.M2.L1.ClassesAndEnums;


namespace ALXCourse.Assignments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            Console.WriteLine("Book storage service running...");
            char appStatus = 'r';
            StorageService bookStorage = new StorageService();
            while (appStatus == 'r')
            {
                Console.WriteLine("What would you like to do?\n a = Add book   s = Show shelves   other = exit");
                appStatus = char.Parse(Console.ReadLine());
                switch (appStatus)
                {
                    case 'a':
                        Book book = StorageService.CreateBook();
                        StorageService.ClassifyBook(book, bookStorage);
                        appStatus = 'r';
                        break;
                    case 's':
                        PresentShelves(bookStorage);
                        appStatus= 'r';
                        break;
                    default:
                        Console.WriteLine("Exiting...");
                        break;
                }
            }
        }

        public static void PresentShelves(StorageService bookStorage)
        {
            Console.WriteLine("Fact Based: ");
            ShowList(bookStorage.FactBasedShelve);
            Console.WriteLine("Fantasy: ");
            ShowList(bookStorage.FantasyShelve);
            Console.WriteLine("Sci-Fi: ");
            ShowList(bookStorage.SciFiShelve);
            Console.WriteLine("Romance: ");
            ShowList(bookStorage.RomanceShelve);
            Console.WriteLine("Thriller: ");
            ShowList(bookStorage.ThrillerShelve);
        }
        
        
        public static void ShowList(List<Book> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (Book item in list)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();
        }

    }
}
