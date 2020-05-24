using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CohortAttribute
    {
        public int Id { get; set; }
        public int CohortDefinitionId { get; set; }
        public string CohortStartDate { get; set; }
        public string CohortEndDate { get; set; }
        public int SubjectId { get; set; }
        public int AttributeDefinitionId { get; set; }
        public string ValueAsNumber { get; set; }
        public int? ValueAsConceptId { get; set; }
    }
}
