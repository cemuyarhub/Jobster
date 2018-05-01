using Jobster.models.data;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.data
{
  public class StandardReturnObject:ReturnObject
    {
        private Enums.ComponentNames _componentName;
        public void SetComponentName(Enums.ComponentNames componentName)
        {
            _componentName = componentName;
        }

        public Enums.ComponentNames GetComponentName() { return _componentName; }

        public override Boolean IsSucess()
        {
            if (Result == Enums.DataReturnType.Success)
                return true;
            else
                return false;
        }

        public override Boolean IsObjectExist()
        {
            if (!Component.Equals(null))
                return true;
            else
                return false;

        }


    }
}
