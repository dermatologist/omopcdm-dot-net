using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Relationship
    {
        public long Id { get; set; }
        public string RelationshipId { get; set; }
        public string RelationshipName { get; set; }
        public string IsHierarchical { get; set; }
        public string DefinesAncestry { get; set; }
        public string ReverseRelationshipId { get; set; }
        public long RelationshipConceptId { get; set; }
    }
}
