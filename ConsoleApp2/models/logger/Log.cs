using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.logger
{
   public class Log
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Message { get; set; }

        public string UserIp { get; set; }

        public string MethodName { get; set; }


        public DateTime Time { get; set; }

        public Enums.ActionType ActionType { get; set; }



    }
}
