using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CohortDefinition
    {
        public int Id { get; set; }
        public int CohortDefinitionId { get; set; }
        public string CohortDefinitionName { get; set; }
        public string CohortDefinitionDescription { get; set; }
        public int DefinitionTypeConceptId { get; set; }
        public string CohortDefinitionSyntax { get; set; }
        public int SubjectConceptId { get; set; }
        public byte[] CohortInitiationDate { get; set; }
    }
}
