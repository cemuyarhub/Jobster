using ConsoleApp2.models.logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2.logger
{
    public class FileLogger : BaseLogger
    {
        public string filePath = "logs/log.txt";
        public override void Log(Log log)
        {
            string text = log.UserId + "-" + log.Message + "-" + log.UserIp + "-" + log.Time + "-" + log.ActionType+"-" + log.MethodName;


            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }
    }
}
