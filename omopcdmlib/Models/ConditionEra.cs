using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConditionEra
    {
        public int Id { get; set; }
        public int ConditionEraId { get; set; }
        public int PersonId { get; set; }
        public int ConditionConceptId { get; set; }
        public string ConditionEraStartDate { get; set; }
        public string ConditionEraEndDate { get; set; }
        public int? ConditionOccurrenceCount { get; set; }
    }
}
