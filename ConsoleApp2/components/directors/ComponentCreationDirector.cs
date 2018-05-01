using Jobster.models.components;
using Jobster.models.components.builders;
using Jobster.models.components.directors;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.directors
{
    public class ComponentCreationDirector : Director
    {
        private int _targetCompositeId;

        public ComponentCreationDirector()
        {
            _objectIndex = -1;
        }

        private void IncrementCounter() { _objectIndex++; }

        
        public override void Construct(Builder builder, Enums.ComponentNames componentType)
        {
            _componentName = componentType;
            IncrementCounter();
            builder.BuildNewComponent(componentType);
            Notify();//TODO CAN BE CHANGE
        }

    }
}
