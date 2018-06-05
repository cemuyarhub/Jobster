using System;
using System.Collections.Generic;
using System.Text;
using JobsterV2.models.enums;

namespace JobsterV2.models.components
{
    public abstract class Attachment : PrimitiveComponent
    {
        protected int index;
        protected string fileDirectory;
        public Attachment(Enums.ComponentNames name, int id) : base(name, id)
        {
        }

        public abstract string GetFileDirectory();
        public abstract int GetIndex();

    }
}
