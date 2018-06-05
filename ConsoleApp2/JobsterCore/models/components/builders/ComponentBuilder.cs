using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.builders
{
  public abstract class ComponentBuilder:Builder

    {

        public abstract void BuildTrashBox();
        public abstract void BuildDraftBox();
        public abstract void BuildSentBox();
        public abstract void BuildTemplateBox();
        public abstract void BuildProfile();
        public abstract void BuildRootController();
           
    }
}
