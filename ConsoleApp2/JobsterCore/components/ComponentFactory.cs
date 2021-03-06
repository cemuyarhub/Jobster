﻿using JobsterV2.components.authentication;
using JobsterV2.models.components;
using JobsterV2.models.components.index;
using JobsterV2.models.enums;
using JobsterV2.models.factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components
{
    public class ComponentFactory : AbstractFactory
    {
    

        public static AbstractFactory Instance(IndexCounter incrementor)
        {
            if (_instance == null)
            {
                _instance = new ComponentFactory();
                _instance.SetIncrementor(incrementor);
             }

            return _instance;
        }

    
     

        public override Component Create(Enums.ComponentNames name)
        {
            _incrementor.IncrementIndex();
            int objectId = _incrementor.GetIndex();
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

        public override void SetIncrementor(IndexCounter incrementor)
        {
            _incrementor = incrementor;
        }
    }
}
