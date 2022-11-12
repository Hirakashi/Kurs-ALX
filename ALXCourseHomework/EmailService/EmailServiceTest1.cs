using ALXCourseHomework.EmailService.Classes;
using ALXCourseHomework.EmailService;

namespace ALXCourseHomework.EmailService
{
    public class EmailServiceTest1
    {
        public static void Run()
        {
            Email email = new Email();
            email.To = "ALX@gmail.com";
            email.From = "ChetnyNaKurs@gmail.com";
            email.Subject = "Zapis na kurs";
            email.Body = "Dzień dobry\n\nChciałbym się zapytać o warunki zapisów na kurs C#\n\nPozdrawiam,\nZiutek";
            EmailService.SendEmail(email);
        }
    }
}
