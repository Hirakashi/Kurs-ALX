using ALXCourse.Assignments.M2.L2.Enums;

namespace ALXCourse.Assignments.M2.L2
{
    public class StorageService
    {
        public List<Book> FactBasedShelve = new List<Book>();
        public List<Book> FantasyShelve = new List<Book>();
        public List<Book> SciFiShelve = new List<Book>();
        public List<Book> RomanceShelve = new List<Book>();
        public List<Book> ThrillerShelve = new List<Book>();

        public static Book CreateBook()
        {
            Book book = new Book();
            Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>()
            {
                {"factbased",Genre.FACTBASED},
                {"fantasy",Genre.FANTASY},
                {"scifi",Genre.SCI_FI},
                {"romance",Genre.ROMANCE},
                {"thriller",Genre.THRILLER }
            };

            Console.WriteLine("Enter title: ");
            book.Title = Console.ReadLine();
            Console.WriteLine("Enter Genre: ");
            string genre = Console.ReadLine()
                .ToLower()
                .Replace(" ", "")
                .Replace("-", "");
            book.Genre = genreDictionary[genre];
            return book;
        }
        public static void ClassifyBook(Book book, StorageService shelves)
        {
            switch (book.Genre)
            {
                case Genre.FACTBASED:
                    shelves.FactBasedShelve.Add(book);
                    break;
                case Genre.FANTASY:
                    shelves.FantasyShelve.Add(book);
                    break;
                case Genre.SCI_FI:
                    shelves.SciFiShelve.Add(book);
                    break;
                case Genre.ROMANCE:
                    shelves.RomanceShelve.Add(book);
                    break;
                case Genre.THRILLER:
                    shelves.ThrillerShelve.Add(book);
                    break;
                default:
                    Console.WriteLine("Error during shelfe assignmnent");
                    break;
            }
        }
    }
}
