using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.models;
using Jobster.models.components;
using Jobster.models.enums;
using Jobster.models.factories;

namespace Jobster.components.builders
{
    public class ComponentBuilder : models.components.builders.Builder
    {
        private static ComponentBuilder _instance;

        private Component _newComponent;

        private AbstractFactory _componentFactory;

        private int? _newObjectId;


        public static ComponentBuilder Instance()
        {
            if(_instance==null)
            _instance = new ComponentBuilder();
            return _instance;
        }


        public override void BuildNewComponent(Enums.ComponentNames componentName) //2
        {

            _newComponent = _componentFactory.Create(componentName, (int)_newObjectId);


        }

 
        public override Component GetResult()
        {
            return _newComponent;
        }

        public override void SetNewObjectId(int newObjectId)
        {
            _newObjectId = newObjectId;
        }


    }
}
