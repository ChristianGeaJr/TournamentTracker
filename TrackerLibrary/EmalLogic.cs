using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace TrackerLibrary
{
    public static class EmalLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {

            SendEmail(new List<string>() { to }, new List<string>(), subject, body);
            //MessageBox.Show($"To: {to} \n {body}");
        }

        public static void SendEmail(List<string> to, List<string> bcc, string subject, string body)
        {
            //MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookUp("senderEmail"), GlobalConfig.AppKeyLookUp("senderDisplayName"));

            //MailMessage mail = new MailMessage();
            //foreach (string email in to)
            //{
            //    mail.To.Add(email); 
            //}
            //foreach (string email in bcc)
            //{
            //    mail.Bcc.Add(email);
            //}
            //mail.From = fromMailAddress;
            //mail.Subject = subject;
            //mail.Body = body;
            //mail.IsBodyHtml = true;

            //SmtpClient client = new SmtpClient();

            //client.Send(mail);


            foreach (string email in to)
            {
                MessageBox.Show($"To: {email} \n {body}");
            }
            foreach (string email in bcc)
            {
                MessageBox.Show($"To: {email} \n {body}");
            }


        }
    }
}
