using System;
using System.Collections.Generic;
using System.Text;
using Jobster.models.enums;

namespace Jobster.models.components
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
