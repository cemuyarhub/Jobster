using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.enums
{
   public static class Enums
    {
        public enum OperationType
        {
            Create,
            Update,
            Delete,
            Read
        }

        public enum DataReturnType
        {
            Success,
            Failure
        }

        public enum ActionType
        {
            Db=1,
            Mail=2,
            Authentication=3
        }

        public enum LogTarget
        {
          Database, File
        }

        public enum ComponentNames
        {
            StandardMail,DraftBox,TrashBox, SentBox, UserProfile, TypesOfLogin, StandardMailTemplate, MailTemplateBox, GmailAuthentication, MicrosoftAuthentication, Jobster,StandardAttachment, Attachments
        }

        public enum StateTypes
        {
            Draft,Trash,Sent,MailTemplate
        }

        public enum ObserverType
        {
            AddComponent, RemoveComponent, CompositeSwitcher
        }
    }
}
