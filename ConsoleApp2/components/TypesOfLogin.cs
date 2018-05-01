using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public  class TypesOfLogin:PrimitiveComponent
    {
        public TypesOfLogin(int objectId) : base(Enums.ComponentNames.TypesOfLogin,objectId)
        {

        }

        public int Id { get; set; }

        public string Type { get; set; }

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
