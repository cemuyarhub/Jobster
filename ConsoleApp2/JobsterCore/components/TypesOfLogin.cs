using JobsterV2.models.components;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components
{
    public  class TypesOfLogin:PrimitiveComponent
    {
        public TypesOfLogin(int objectId) : base(Enums.ComponentNames.TypesOfLogin,objectId)
        {

        }

        public int Id { get; set; }

        public string Type { get; set; }

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
