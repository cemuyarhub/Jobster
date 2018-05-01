using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMailSend();
            Console.ReadLine();
        }

        public static void TestMailSend()
        {
            MailMessage mail = new MailMessage();
            AE.Net.Mail.MailMessage mailMessage = new AE.Net.Mail.MailMessage();
            mail.Attachments.Add(new Attachment("C:\\Users\\JOEY\\Desktop\\notes about design patterns\\Notes.txt"));
           

            Console.WriteLine(mail.ToString());
        }


    }
}
