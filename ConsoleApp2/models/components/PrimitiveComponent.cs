using Jobster.components.implementors;
using Jobster.models.components;
using Jobster.models.components.navigation;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components
{
    public abstract class PrimitiveComponent : Component
    {
        public PrimitiveComponent(Enums.ComponentNames name, int id) : base(name, id)
        {
            _implementor = new PrimitiveImplementor();
        }

        public override void Add(Component c, int targetCompositeId)
        {
            throw new NotImplementedException();
        }

        public override Iterator CreateIterator()
        {
            throw new NotImplementedException();
        }

        public override Component FindRoot()
        {
           return _implementor.DoFindRoot(this);
        }

        public override Component Get(int objectId)
        {
            throw new NotImplementedException();
        }

        public override bool IsComposite()
        {
            return false;
        }

        public override void Modify(Component c, int objectId)
        {
            throw new NotImplementedException();
        }

        public override void Move(Component c, int fromCompositeObjectId, int targetCompositeId)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c, int objectId)
        {
            throw new NotImplementedException();
        }
    }
}
