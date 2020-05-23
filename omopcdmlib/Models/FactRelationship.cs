using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class FactRelationship
    {
        public int Id { get; set; }
        public int DomainConceptId1 { get; set; }
        public int FactId1 { get; set; }
        public int DomainConceptId2 { get; set; }
        public int FactId2 { get; set; }
        public int RelationshipConceptId { get; set; }
    }
}
