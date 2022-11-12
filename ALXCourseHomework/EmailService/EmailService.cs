using ALXCourseHomework.EmailService.Classes;

namespace ALXCourseHomework.EmailService
{
    public class EmailService
    {
        public static void SendEmail(Email email)
        {
            Console.WriteLine("Email has been sent:");
            Console.WriteLine($"To: {email.To}");
            Console.WriteLine($"From: {email.From}");
            Console.WriteLine($"Subject: {email.Subject}");
            Console.WriteLine($"\n{email.Body}");

        }
    }
}
