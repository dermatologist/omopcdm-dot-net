using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class VisitOccurrence
    {
        public long Id { get; set; }
        public long VisitOccurrenceId { get; set; }
        public long PersonId { get; set; }
        public long VisitConceptId { get; set; }
        public byte[] VisitStartDate { get; set; }
        public string VisitStartTime { get; set; }
        public byte[] VisitEndDate { get; set; }
        public string VisitEndTime { get; set; }
        public long VisitTypeConceptId { get; set; }
        public long? ProviderId { get; set; }
        public long? CareSiteId { get; set; }
        public string VisitSourceValue { get; set; }
        public long? VisitSourceConceptId { get; set; }
    }
}
