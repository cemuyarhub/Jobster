using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.builders
{
public abstract class TemplateBuilder:Builder
    {

        public abstract void BuildSubject(object subject);

        public abstract void BuildContext(object context);

        public abstract void BuildAttachments(CompositeComponent attachments);

    }
}
