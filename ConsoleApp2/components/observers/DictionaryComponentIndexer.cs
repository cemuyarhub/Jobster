using Jobster.models.components.directors;
using Jobster.models.components.observers;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.observers
{
    public class DictionaryComponentIndexer : ComponentIndexer
    {
        private Director _director;
        private Dictionary<Enums.ComponentNames, int> _objectStack = new Dictionary<Enums.ComponentNames, int>();
        public DictionaryComponentIndexer (Director director)
        {
            _director = director;
        }

        public override void Update()
        {

            _objectStack.Add(_director.GetComponentName(), _director.GetObjectIndex());


        }

        public void RemoveFromObjectStack(Enums.ComponentNames name)
        {
            _objectStack.Remove(name);
        }


        public override int? GetObjectId(Enums.ComponentNames name)
        {
            return _objectStack.GetValueOrDefault(name);
        }
    }
}
