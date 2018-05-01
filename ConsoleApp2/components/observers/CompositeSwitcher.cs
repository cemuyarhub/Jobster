using Jobster.models.components;
using Jobster.models.components.observers;
using Jobster.models.components.state;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.observers
{
    class CompositeSwitcher : Observer
    {

        private Component _component;
        private State _state;
        private ComponentIndexer _componentIndexer;

        public CompositeSwitcher(Component c, DictionaryComponentIndexer componentIndexer)
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
                _componentIndexer.GetObjectId()
                



            }


        }


    }
}
