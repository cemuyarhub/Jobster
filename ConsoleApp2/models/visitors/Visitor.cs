using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.visitors
{
   public abstract class Visitor
    {
        public Visitor(Mediator mediator)
        {
            _mediator = mediator;
        }

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


    }
}
