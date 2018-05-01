using ConsoleApp2.data;
using ConsoleApp2.models.logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.logger
{
    public class DBLogger : BaseLogger
    {
        string connectionString = string.Empty;
        public override void Log(Log log)
        {
            string query = "INSERT INTO log (user_id,message,user_ip,time,method_name,action_type) VALUES("
                + "'" + log.UserId+ "',"
                + "'" + log.Message + "',"
                + "'" + log.UserIp + "',"
                + "'" + log.Time+ "',"
                + "'" + log.MethodName + "',"
                + "'" + log.ActionType + "')";

            ReturnObject temp= DatabaseOperator.CreateOrUpdateOrDelete(query, models.Enums.OperationType.Create);



        }
    }
}
