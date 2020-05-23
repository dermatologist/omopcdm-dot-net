using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CohortAttribute
    {
        public int Id { get; set; }
        public int CohortDefinitionId { get; set; }
        public byte[] CohortStartDate { get; set; }
        public byte[] CohortEndDate { get; set; }
        public int SubjectId { get; set; }
        public int AttributeDefinitionId { get; set; }
        public byte[] ValueAsNumber { get; set; }
        public int? ValueAsConceptId { get; set; }
    }
}
