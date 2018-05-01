using ConsoleApp2.models;
using ConsoleApp2.models.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.operators
{
   public static class MailTemplatesOperator
    {
        public static ReturnObject GetMailTemplates(int userId)
        {
            string query = "SELECT * FROM mail_templates WHERE user_id='" + userId + "'";


            List<MailTemplate> result = new List<MailTemplate>();



            ReturnObject obj = DatabaseOperator.Read(query);
            Reader reader = (Reader)obj.Object;
            MySqlDataReader dataReader = reader.DataReader;


           while (dataReader.Read())
            {
                MailTemplate tmp = new MailTemplate
                {
                    Id = (int)dataReader["id"],
                    Body = dataReader["body"].ToString(),
                    CV = dataReader["cv"].ToString(),
                    Name = dataReader["name"].ToString(),
                    Subject = dataReader["subject"].ToString(),
                    UserId = (int)dataReader["user_id"],
                    Status = (int)dataReader["status"],
                    CreateTime = (DateTime)dataReader["create_time"],
                    LastUpdateTime = (DateTime)dataReader["last_update_time"]

                };
                result.Add(tmp);

            }
            dataReader.Close();
            MailTemplateBox templateBox = new MailTemplateBox() {
                Box = result
            };
            obj.Object = templateBox;
            return obj;
         }

        public static ReturnObject InsertNewTemplate(MailTemplate temp)
        {
            string query = "INSERT INTO mail_templates (status,user_id,name,cv,body,subject,create_time,last_update_time) VALUES("
             + "'" + temp.Status + "',"
             + "'" + temp.UserId + "',"
             + "'" + temp.Name + "',"
             + "'" + temp.CV + "',"
             + "'" + temp.Body + "',"
             + "'" + temp.Subject + "',"
             + "'" + temp.CreateTime + "',"
            + "'" + temp.LastUpdateTime + "')";

            return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Create);
            
        }
        public static ReturnObject UpdateOrDeleteTemplate(MailTemplate temp, Enums.OperationType type)
        {
            if (type == Enums.OperationType.Delete)
                temp.Status = 0;

            string query = "UPDATE mail_templates SET "
           + "status='" + temp.Status + "',"
             + "user_id='" + temp.UserId + "',"
             + "name='" + temp.Name + "',"
             + "cv='" + temp.CV + "',"
             + "body='" + temp.Body + "',"
             + "subject='" + temp.Subject + "',"
             + "create_time='" + temp.CreateTime + "',"
            + "last_update_time='" + temp.LastUpdateTime + "')";

            if (type == Enums.OperationType.Update)
                return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Update);
            else
                return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Delete);


        }



    }
}
