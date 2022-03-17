using System;
using MimeKit; // <-- Pašto siuntimo daiktas: https://stackoverflow.com/questions/449887/sending-e-mail-using-c-sharp
using MailKit.Net.Smtp;
using Restaurant_System;

namespace CS_OO_Restaurant_System.Functionality
{
    public class MailingSystem : Form1
    {
        public static void MIMEMessage()
        {
            // Mime stands for Multiple Internet Mail Extensions
            // Tools -> Nuget Package Manager -> Package manager console: pm> Install-Package MailKit
            // Less secure app access (G Account security settings)
            MimeMessage message = new MimeMessage(); // <-- Sukuriu naują message objektą, į kurį talpinsiu datą laiško
            message.From.Add(new MailboxAddress("C# Restaurant Cheque", "donatascodeacad@gmail.com")); // <-- šitą dalį gavėjas matys kaip sender lauką

            message.To.Add(MailboxAddress.Parse("donatascodeacad@gmail.com")); // <-- Adresato laukas; parse konvertuoja string'ą į pašto adreso duomenį
            message.To.Add(MailboxAddress.Parse("donatascodeacad@gmail.com"));

            message.Subject = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day} Purchase";

            //MailingSystem.MIMEMessage(rtReceipt);

            message.Body = new TextPart("plain") {
                //Text = "Testas"
                Text = cheque
            };
            #region (!) SENSITIVE DATA
            //Console.Write("Email: ");
            string emailAdress = "DonatasCodeAcad@gmail.com";
            //Console.Write("Password: ");
            string password = "lalala123654789";
            #endregion

            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true); // 465 port'as. bool klausia ar naudojamas SSL
                client.Authenticate(emailAdress, password); // <-- autentikacija
                client.Send(message); // <-- nurodymas siųsti
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true); // <-- atsijungiama
                client.Dispose();        // <-- trinamas objektas
            }
        }
    }
}

// DonatasCodeAcad@gmail.com
// lalala123654789
//feel free to join this empty gmail