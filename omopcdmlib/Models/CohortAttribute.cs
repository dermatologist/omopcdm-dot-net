using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CohortAttribute
    {
        public long Id { get; set; }
        public long CohortDefinitionId { get; set; }
        public byte[] CohortStartDate { get; set; }
        public byte[] CohortEndDate { get; set; }
        public long SubjectId { get; set; }
        public long AttributeDefinitionId { get; set; }
        public byte[] ValueAsNumber { get; set; }
        public long? ValueAsConceptId { get; set; }
    }
}
