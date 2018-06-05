using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.models;
using JobsterV2.models.components;
using JobsterV2.models.components.builders;
using JobsterV2.models.enums;
using JobsterV2.models.factories;

namespace JobsterV2.components.builders
{
    public class StandardComponentBuilder : ComponentBuilder
    {
        private static StandardComponentBuilder _instance;

        private Component _product;

        private AbstractFactory _componentFactory;



        public static StandardComponentBuilder Instance()
        {
            if(_instance==null)
            _instance = new StandardComponentBuilder();
            return _instance;
        }


        private Component BuildNewComponent(Enums.ComponentNames componentName) //2
        {
            if (_componentFactory == null)
                _componentFactory = new ComponentFactory();
            return _componentFactory.Create(componentName);


        }

 
        public override Component GetResult()
        {
            return _product;
        }

        public override void BuildTrashBox()
        {

            _product.Add(BuildNewComponent(Enums.ComponentNames.TrashBox),_product.GetRootObjectId());
        }

        public override void BuildDraftBox()
        {
            _product.Add(BuildNewComponent(Enums.ComponentNames.DraftBox), _product.GetRootObjectId());
        }

        public override void BuildSentBox()
        {
            _product.Add(BuildNewComponent(Enums.ComponentNames.SentBox), _product.GetRootObjectId());
        }

        public override void BuildTemplateBox()
        {
            _product.Add(BuildNewComponent(Enums.ComponentNames.MailTemplateBox), _product.GetRootObjectId());
        }

        public override void BuildProfile()
        {
            _product.Add(BuildNewComponent(Enums.ComponentNames.UserProfile), _product.GetRootObjectId());
        }

        public override void BuildRootController()
        {
            _product=BuildNewComponent(Enums.ComponentNames.Jobster);
        }

        public override void BuildFirstInstance()
        {
            throw new NotImplementedException();
        }
    }
}
