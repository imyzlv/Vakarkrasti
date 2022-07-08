using System;
using System.Net.Mail;
using System.Net;
namespace Vakarkrasti.Services
{
    public class EmailSender
    {
        public static void SendEmail(string from, string name, string fullMessage, string phoneNumber)
        {
            string to = "imants.treidis@gmail.com";
            //string from = "ss@gmail.com.com";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(from);
            message.To.Add(to);

            message.Subject = "Jauns ziņojums no " + name;
            message.Body = fullMessage;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Credentials = new System.Net.NetworkCredential("imants.treidis@gmail.com", "");
            client.UseDefaultCredentials = false;
            client.Port = 587;
            client.EnableSsl = true;


            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }
    }
}

