using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Windows.Forms;

namespace textPicture
{
    internal class SendMail
    {
        public string emailAddress = "binh1920042018@gmail.com", passWord = "pmov zdhb zrhd ayrn";
        Random rand = new Random();

        public int Work(string MailReiciever)
        {
            int otp = rand.Next(1000, 10000);
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hồ Vũ Thanh Bình", "binh1920042018@gmail.com"));
            message.To.Add(MailboxAddress.Parse(MailReiciever));

            message.Subject = "Code for register";
            message.Body = new TextPart("plain")
            {

                Text = "this is your code, dont share it with anybody: " + otp.ToString() 
            };


            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(emailAddress, passWord);
                client.Send(message);
                MessageBox.Show("Code sent!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }

            return otp;
        }
    }
}
