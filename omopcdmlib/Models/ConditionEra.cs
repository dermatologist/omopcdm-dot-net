using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConditionEra
    {
        public long Id { get; set; }
        public long ConditionEraId { get; set; }
        public long PersonId { get; set; }
        public long ConditionConceptId { get; set; }
        public byte[] ConditionEraStartDate { get; set; }
        public byte[] ConditionEraEndDate { get; set; }
        public long? ConditionOccurrenceCount { get; set; }
    }
}
