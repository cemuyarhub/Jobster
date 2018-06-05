using JobsterV2.models.components.index;
using JobsterV2.models.components.observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.observers
{
    public class ComponentIndexIncrementor : IndexCounter
    {
        private int _index = 0;

        public override int GetIndex()
        {
            return _index;
        }

        public override void IncrementIndex()
        {
            _index++;
        }

         
    }
}
