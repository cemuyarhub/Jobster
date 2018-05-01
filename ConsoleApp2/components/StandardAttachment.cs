using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class StandardAttachment : Attachment
    {
        public StandardAttachment(Enums.ComponentNames name, int id) : base(name, id)
        {
        }

        public override string GetFileDirectory()
        {
            return fileDirectory;
        }

        public override int GetIndex()
        {
            return index;        }

        public override void LoadFromDb()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}
