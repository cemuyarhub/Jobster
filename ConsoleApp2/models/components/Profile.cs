using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.models.settings;
using ConsoleApp2.models;
using Jobster.models.enums;

namespace Jobster.models.components
{
    public abstract class Profile:PrimitiveComponent
    {
        public Profile( Enums.ComponentNames name, int objectId) :base(name,objectId)
        {
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public int TypeOfLoginId { get; set; }
        public int Status { get; set; }


    }
}
