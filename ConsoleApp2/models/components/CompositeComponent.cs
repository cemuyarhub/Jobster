using Jobster.components.implementors;
using Jobster.components.navigation;
using Jobster.models.components;
using Jobster.models.components.navigation;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components
{
    public abstract class CompositeComponent : Component
    {
        protected List<Component> _components;
        public CompositeComponent(Enums.ComponentNames name,int objectId) : base(name, objectId)
        {
            _implementor = new CompositeImplementor();
            _components = new List<Component>();
        }


        public List<Component> GetComponents() { return _components; }
        public void SetComponent(int index, Component c) { _components[(int)index] = c; }
        public void AddComponent(Component c) { _components.Add(c); }
        public void RemoveComponent(Component c) { _components.Remove(c); }
        public Component GetComponent(int index) { return _components[(int)index]; }


        public override Component FindRoot()
        {
            return _implementor.DoFindRoot(this);

        }

      
       

        public override void Modify(Component c, int objectId)
        {
            _implementor.DoModify(c, objectId,this);
        }

        public override Component Get(int objectId )
        {
           return  _implementor.DoGet(objectId, this);

        }

     
       public override void Add(Component c, int objectId)
        {
            _implementor.DoAdd(c, objectId, this);

        }

        public override void Remove(Component c, int objectId)
        {
            _implementor.DoRemove(c,objectId, this);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override Iterator CreateIterator()
        {
            return new CompositeIterator(this);
        }

        public override void Move(Component c, int fromCompositeObjectId, int targetCompositeId)
        {
            _implementor.DoMove(c, fromCompositeObjectId, targetCompositeId, this);
        }
    }
}
