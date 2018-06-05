using JobsterV2.models.components;
using JobsterV2.models.components.navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.navigation
{
    public class CompositeIterator : Iterator
    {
        private int _current = 0;
        private CompositeComponent _compositeComponent;


        public CompositeIterator(CompositeComponent compositeComponent)
        {
            _compositeComponent = compositeComponent;
        }

        public override object First()
        {
            return _compositeComponent.GetComponents()[0];
        }

        // Gets next iteration item

        public override object Next()
        {
            object ret = null;
            if (_current < _compositeComponent.GetComponents().Count - 1)
            {
                ret = _compositeComponent.GetComponents()[++_current];
            }

            return ret;
        }

        // Gets current iteration item

        public override object CurrentItem()
        {
            return _compositeComponent.GetComponents()[_current];
        }

        // Gets whether iterations are complete

        public override bool IsDone()
        {
            return _current >= _compositeComponent.GetComponents().Count;
        }
    }
}
