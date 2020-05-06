using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConditionOccurrence
    {
        public long Id { get; set; }
        public long ConditionOccurrenceId { get; set; }
        public long PersonId { get; set; }
        public long ConditionConceptId { get; set; }
        public byte[] ConditionStartDate { get; set; }
        public byte[] ConditionEndDate { get; set; }
        public long ConditionTypeConceptId { get; set; }
        public string StopReason { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string ConditionSourceValue { get; set; }
        public long? ConditionSourceConceptId { get; set; }
    }
}
