using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class VisitOccurrence
    {
        public int Id { get; set; }
        public int VisitOccurrenceId { get; set; }
        public int PersonId { get; set; }
        public int VisitConceptId { get; set; }
        public byte[] VisitStartDate { get; set; }
        public string VisitStartTime { get; set; }
        public byte[] VisitEndDate { get; set; }
        public string VisitEndTime { get; set; }
        public int VisitTypeConceptId { get; set; }
        public int? ProviderId { get; set; }
        public int? CareSiteId { get; set; }
        public string VisitSourceValue { get; set; }
        public int? VisitSourceConceptId { get; set; }
    }
}
