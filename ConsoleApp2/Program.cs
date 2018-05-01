using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using send_actionable_message;
using ConsoleApp2.controllers;

namespace ConsoleApp2
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        //a57b7f5e-05e3-4da4-8da2-651b6f1da262

        //tmjpvYIFKHB144%+rpP32*)

        UserController uc = new UserController();
        static void Main(string[] args)
        {


            Program ins = new Program();
            //Console.WriteLine(ins.uc.authenticate());
            
            
            
            //  ins.sendEMailThroughOUTLOOK();

            Console.Read();

        }

        public void authGmail()
        {




        }

        //method to send email to outlook
        public void sendEMailThroughOUTLOOK()
        {
            send_actionable_message.Program.authenticate();

        }
    }
}