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
        public byte[] ValidStartDate { get; set; }
        public byte[] ValidEndDate { get; set; }
        public string InvalidReason { get; set; }
    }
}
