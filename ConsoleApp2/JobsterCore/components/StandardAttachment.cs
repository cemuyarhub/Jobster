using JobsterV2.models.components;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components
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

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
