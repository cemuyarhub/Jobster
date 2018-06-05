using JobsterV2.models.components;
using JobsterV2.models.components.builders;
using JobsterV2.models.components.directors;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.directors
{
    public class DefaultComponentTreeCreator : Director
    {

        public DefaultComponentTreeCreator()
        {
        }

        public override void Construct(ComponentBuilder builder)
        {
            builder.BuildRootController();
            builder.BuildDraftBox();
            builder.BuildProfile();
            builder.BuildSentBox();
            builder.BuildTemplateBox();
            builder.BuildTrashBox();

        }
    }
}
