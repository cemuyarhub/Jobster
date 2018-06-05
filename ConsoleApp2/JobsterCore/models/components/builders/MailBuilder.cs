using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.builders
{
   public abstract class MailBuilder:Builder
    {


        public abstract void BuildTemplate();

        public abstract void BuildTargetMailAdress();


    }
}
