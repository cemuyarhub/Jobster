using JobsterV2.components.implementors;
using JobsterV2.components.navigation;
using JobsterV2.models.components;
using JobsterV2.models.components.navigation;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components
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
        public void AddComponent(Component c) {

            _components.Add(c);

            //Indexing
            //CFF: Adding/Removing procedures should be separated from the observer logic becuase of inefficieny regarding the area of too many observer instances would be in the system.
            Component root = FindRoot();
            root.GetComponentIndexer().Add(c);

        }
        public void RemoveComponent(Component c) {
            _components.Remove(c);
            //Indexing
            Component root = FindRoot();
            root.GetComponentIndexer().Remove(c);

        }
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
