using JobsterV2.models.components;
using JobsterV2.models.components.directors;
using JobsterV2.models.components.observers;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.componentindexer
{
    public class NameBasedIndexer : ComponentIndexer
    {
        private Dictionary<int,Enums.ComponentNames> _objectStack = new Dictionary<int, Enums.ComponentNames>();
        public NameBasedIndexer ()
        {

        }

        public override int? GetObjectId(Object identifier)//for composite components
        {
            Enums.ComponentNames name = (Enums.ComponentNames)identifier;

            foreach (var item in _objectStack)
            {
                if (item.Value == name)
                {
                    return item.Key;
                }
            }
            return null;
        }

        public override void Add(Component component)
        {
            _objectStack.Add(component.ObjectId, component.GetName());
        }

        public override void Remove(Component component)
        {
            _objectStack.Remove(component.ObjectId);
        }
    }
}
