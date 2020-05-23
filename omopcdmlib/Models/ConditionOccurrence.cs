using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConditionOccurrence
    {
        public int Id { get; set; }
        public int ConditionOccurrenceId { get; set; }
        public int PersonId { get; set; }
        public int ConditionConceptId { get; set; }
        public byte[] ConditionStartDate { get; set; }
        public byte[] ConditionEndDate { get; set; }
        public int ConditionTypeConceptId { get; set; }
        public string StopReason { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string ConditionSourceValue { get; set; }
        public int? ConditionSourceConceptId { get; set; }
    }
}
