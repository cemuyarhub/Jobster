using ConsoleApp2.models;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.implementations
{
   public abstract class ComponentImplementor
    {
        public abstract void DoAccept();

        public abstract void DoModify(Component c, int fromCompositeObjectId, Component modifier);

        public abstract Component DoGet(int objectId,  Component modifier);

        public abstract Component DoFindRoot(Component modifier);

        public abstract void DoAdd(Component c, int fromCompositeObjectId, Component modifier);

        public abstract void DoRemove(Component c, int fromCompositeObjectId, Component modifier);

        public abstract void DoMove(Component c, int fromCompositeObjectId, int targetCompositeObjectId, Component modifier);


    }
}
