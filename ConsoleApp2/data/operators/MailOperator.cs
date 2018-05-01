using ConsoleApp2.models;
using ConsoleApp2.models.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.operators
{
    public static class MailOperator
    {



        public static ReturnObject GetMailsByUserId(int user_id)
        {

            string query = "SELECT * FROM sent_mails WHERE user_id='"+ user_id + "'";

            List<Mail> mailList = new List<Mail>();

            ReturnObject obj = DatabaseOperator.Read(query);
            Reader reader = (Reader)obj.Object;
            MySqlDataReader dataReader = reader.DataReader;


            while (dataReader.Read())
            {
                Mail tmp = new Mail()
                {
                    Id = (int)dataReader["id"],
                UserId = (int)dataReader["user_id"],
                MailTemplateId = (int)dataReader["mail_template_id"],
               FromMail = dataReader["from_mail"].ToString(),
               TargetMail = dataReader["target_mail"].ToString(),
                SendDate = (DateTime)dataReader["send_date"],
                Status= (int)dataReader["status"]
                };

                mailList.Add(tmp);
               
            }
            dataReader.Close();
            MailBox box = new MailBox()
            {
                Box = mailList
            };
            obj.Object = box;
            return obj;
        }

        public static ReturnObject InsertNewMail(Mail mail)
        {
            string query = "INSERT INTO sent_mails (id,user_id,mail_template_id,from_mail,status,target_mail,send_date) VALUES("
                + "'" + mail.Id + "',"
                + "'" + mail.UserId+ "',"
                + "'" + mail.MailTemplateId + "',"
                + "'" + mail.FromMail + "',"
                 + "'" + mail.Status + "',"
                + "'" + mail.TargetMail + "',"
                + "'" + mail.SendDate + "')";
            return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Create);



        }

        public static ReturnObject UpdateOrDeleteMail(Mail mail, Enums.OperationType type)
        {
            if (type == Enums.OperationType.Delete)
                mail.Status = 0;

            string query = "UPDATE sent_mails SET "
               + "id='" + mail.Id + "',"
                + "user_id='" + mail.UserId + "',"
                + "mail_template_id='" + mail.MailTemplateId + "',"
                + "from_mail='" + mail.FromMail + "',"
                 + "status='" + mail.Status + "',"
                + "target_mail='" + mail.TargetMail + "',"
                + "send_date='" + mail.SendDate + "')";

            if (type == Enums.OperationType.Update)
                return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Update);
            else
                return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Delete);


        }

    }
}
