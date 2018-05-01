using ConsoleApp2.models;
using Jobster.models.components.implementations;
using Jobster.models.components.navigation;
using Jobster.models.components.observers;
using Jobster.models.components.state;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components
{
   public abstract class Component:IStateable
    {
        protected Component _ancestor;

        protected ComponentImplementor _implementor;

      //  protected Boolean _status=true;
        
        public int ObjectId { get; set; }

        protected State _state;

        public State State { get => _state; set => _state = State; }

        public void SetAncestor(Component c)
        {
            _ancestor = c;
        }
        public Component GetAncestor()
        {
            return _ancestor;
        }

        private Enums.ComponentNames _name;
        public Component(Enums.ComponentNames name, int id)
        {
             ObjectId = id;
            _name = name;
        }

        public Enums.ComponentNames GetName()
        {
            return _name;
        }

        public abstract void Modify(Component c, int objectId);

        public abstract Component Get(int objectId);

        public abstract Component FindRoot();

        public abstract void Add(Component c, int targetCompositeId);

        public abstract void Move(Component c, int fromCompositeObjectId, int targetCompositeId);


        public abstract void Remove(Component c, int objectId);

        public abstract Boolean IsComposite();

        public  Boolean IsObjectIdEquals(int objectId)
        {
            return objectId == ObjectId;
        }

        public void AddToTree(Component c, int targetCompositeId)
        {
            Component root = FindRoot();
            root.Add(c, targetCompositeId);
        }

        public abstract Iterator CreateIterator();

        public abstract void Save();

        public abstract void LoadFromDb();

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

        public void ChangeState(Enums.StateTypes type)
        {
            _state.ChangeState(this, type);
            Notify();
        }
    }
}
