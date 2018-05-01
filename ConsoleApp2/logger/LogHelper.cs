using ConsoleApp2.models.logger;
using ConsoleApp2.utils;
using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.models.Enums;

namespace ConsoleApp2.logger
{
    public static class LogHelper
    {
        private static BaseLogger logger = null;
        public static void Log(LogTarget target, string message, ActionType type, string methodName)
        {
            Log log = GenerateLogObject(message,type, methodName);
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(log);
                    break;
                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(log);
                    break;
              default:
                    return;
            }
        }

        private static Log GenerateLogObject(string message,ActionType type, string methodName)
        {
            Log obj = new Log()
            {
                //UserId
                UserIp = Tools.GetLocalIPAddress(),
                Time=DateTime.Now,
                ActionType=type,
                MethodName= methodName
            };
            return obj;

        }

    }
}
