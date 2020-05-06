using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class FactRelationship
    {
        public long Id { get; set; }
        public long DomainConceptId1 { get; set; }
        public long FactId1 { get; set; }
        public long DomainConceptId2 { get; set; }
        public long FactId2 { get; set; }
        public long RelationshipConceptId { get; set; }
    }
}
