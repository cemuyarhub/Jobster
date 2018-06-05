using JobsterV2.components.componentindexer;
using JobsterV2.models.components;
using JobsterV2.models.components.index;
using JobsterV2.models.components.observers;
using JobsterV2.models.components.state;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.observers
{
    class CompositeSwitcher : Observer
    {

        private Component _component;
        private State _state;
        private ComponentIndexer _componentIndexer;

        public CompositeSwitcher(Component c, ComponentIndexer componentIndexer)
        {
            _componentIndexer = componentIndexer;
            _component = c;//mail yaratiminda yada template yaratiminda eslestirilmesi gerekiyor
            _state = _component.State;
        }

        
        public override void Update()
        {
            if (_state != _component.State)
            {
                _state = _component.State;//belki bi memento olabilir...
                

                Component root = _component.FindRoot();
                int? targetCompositeObjectId = _componentIndexer.GetObjectId(_state.GetEqualiventComponentName());
                if (targetCompositeObjectId==null)
                    //EXCEPTION HANDLING

                root.Move(_component, _component.GetAncestor().ObjectId,(int)targetCompositeObjectId);
            }
        }

    }
}
