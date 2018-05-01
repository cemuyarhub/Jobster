using Jobster.components.authentication;
using Jobster.models.components;
using Jobster.models.enums;
using Jobster.models.factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class ComponentFactory : AbstractFactory
    {
        public static AbstractFactory Instance()
        {
            if (_instance == null)
                _instance = new ComponentFactory();

            return _instance;
        }




        public override Component Create(Enums.ComponentNames name, int objectId)
        {
            switch (name)
            {
                case Enums.ComponentNames.StandardMail: return new StandardMail(objectId);
                case Enums.ComponentNames.SentBox: return new SentBox(objectId);
                case Enums.ComponentNames.UserProfile: return new UserProfile(objectId);
                case Enums.ComponentNames.TypesOfLogin: return new TypesOfLogin(objectId);
                case Enums.ComponentNames.StandardMailTemplate: return new StandardMailTemplate(objectId);
                case Enums.ComponentNames.MailTemplateBox: return new MailTemplateBox(objectId);
                case Enums.ComponentNames.GmailAuthentication: return new GmailAuthentication(objectId);
                case Enums.ComponentNames.MicrosoftAuthentication: return new MicrosoftAuthentication(objectId);
                case Enums.ComponentNames.Jobster: return new Jobster(objectId);
                default: return null;
                    
            }

        }
    }
}
