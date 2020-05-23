using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class AttributeDefinition
    {
        public int Id { get; set; }
        public int AttributeDefinitionId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
        public int AttributeTypeConceptId { get; set; }
        public string AttributeSyntax { get; set; }
    }
}
