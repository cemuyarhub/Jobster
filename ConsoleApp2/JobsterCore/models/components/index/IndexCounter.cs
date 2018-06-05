using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.index
{
   public abstract class IndexCounter
    {
        public abstract void IncrementIndex();
        public abstract int GetIndex();
        

    }
}
