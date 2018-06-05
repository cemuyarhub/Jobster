using ConsoleApp2.models;
using JobsterV2.models.components;
using JobsterV2.models.components.implementations;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.implementors
{
    public class CompositeImplementor : ComponentImplementor
    {
        public override void DoAccept()
        {
            throw new NotImplementedException();
        }

    
        public override void DoAdd(Component c, int objectId, Component modifier)
        {
            CompositeComponent compositeModifier = (CompositeComponent)DoFindRoot(modifier);

            if (compositeModifier.IsObjectIdEquals(objectId))
            {
                compositeModifier.AddComponent(c);
                c.SetAncestor(modifier);
            }
            else
            {
                foreach (var item in compositeModifier.GetComponents())
                {
                    item.Add(c, objectId);
                }
            }
        }

        public override Component DoFindRoot(Component modifier)
        {
            if (modifier.GetAncestor() == null)
                return modifier;

            return modifier.GetAncestor().FindRoot();
        }

  
        public override Component DoGet(int objectId, Component modifier)
        {
           
            CompositeComponent compositeModifier = (CompositeComponent)DoFindRoot(modifier);

            int? index = TravelTreeAndReturnIndex(objectId, compositeModifier);

            return (index != null) ? compositeModifier.GetComponent((int)index) : null;
        }

    

        public override void DoModify(Component c, int objectId, Component modifier)
        {
            CompositeComponent compositeModifier = (CompositeComponent)DoFindRoot(modifier);

            int? index = TravelTreeAndReturnIndex(objectId, compositeModifier);
            if (index != null)
            {
                compositeModifier.SetComponent((int)index, c);
            }
        }

        public override void DoMove(Component c, int fromCompositeObjectId, int targetCompositeObjectId, Component modifier)
        {
            DoRemove(c, fromCompositeObjectId, modifier);
            DoAdd(c, targetCompositeObjectId,modifier);
        }

        public override void DoRemove(Component c, int objectId, Component modifier)
        {
            CompositeComponent compositeModifier = (CompositeComponent)DoFindRoot(modifier);

            if (compositeModifier.IsObjectIdEquals(objectId)) {
                compositeModifier.RemoveComponent(c);
                c.SetAncestor(null);
            }
            else
            {
                foreach (var item in compositeModifier.GetComponents())
                {
                    item.Remove(c, objectId);
                }
            }
        }

        private int? TravelTreeAndReturnIndex(int objectId, CompositeComponent compositeModifier)
        {
           
            foreach (var c in compositeModifier.GetComponents())
            {
                if (c.IsObjectIdEquals(objectId))
                {
                    return compositeModifier.GetComponents().IndexOf(c);
                }
                if (c.IsComposite())
                {
                    c.Get(objectId);
                }

            }
            return null;
        }

    }
}
