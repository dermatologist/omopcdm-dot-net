using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptRelationship
    {
        public int Id { get; set; }
        public int ConceptId1 { get; set; }
        public int ConceptId2 { get; set; }
        public string RelationshipId { get; set; }
        public string ValidStartDate { get; set; }
        public string ValidEndDate { get; set; }
        public string InvalidReason { get; set; }
    }
}
