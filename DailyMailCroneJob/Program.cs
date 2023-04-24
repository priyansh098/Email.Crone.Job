using System.Net;
using System.Net.Mail;

namespace DailyMailCroneJob
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail();
        }
        public static void SendEmail()
        {
            Console.WriteLine("Start at " + DateTime.Now);
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("From@email.com");
            mail.To.Add("To@email.com");
            mail.Subject = "Important Email";
            mail.Body = "Hello, How are you???";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("From@email.com", "Password");
            client.EnableSsl = true;
            int Id = 1;
            while (Id <= 1000)
            {
                Id++;
                client.Send(mail);
            }
            Console.WriteLine("Stop at " + DateTime.Now);
            Console.ReadLine();
        }
    }
}