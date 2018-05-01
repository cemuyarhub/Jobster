using Jobster.models.components.observers;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components.directors
{
   public abstract class Director
    {
        protected int _objectIndex;

        protected Enums.ComponentNames _componentName;

        public Enums.ComponentNames GetComponentName() { return _componentName; }

        public int GetObjectIndex() { return _objectIndex; }


        protected List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }

        public abstract void Construct(builders.Builder builder, enums.Enums.ComponentNames componentType);
    }
}
