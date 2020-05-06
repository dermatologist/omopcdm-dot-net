using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CohortDefinition
    {
        public long Id { get; set; }
        public long CohortDefinitionId { get; set; }
        public string CohortDefinitionName { get; set; }
        public string CohortDefinitionDescription { get; set; }
        public long DefinitionTypeConceptId { get; set; }
        public string CohortDefinitionSyntax { get; set; }
        public long SubjectConceptId { get; set; }
        public byte[] CohortInitiationDate { get; set; }
    }
}
