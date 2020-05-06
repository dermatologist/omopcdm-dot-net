using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class AttributeDefinition
    {
        public long Id { get; set; }
        public long AttributeDefinitionId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
        public long AttributeTypeConceptId { get; set; }
        public string AttributeSyntax { get; set; }
    }
}
