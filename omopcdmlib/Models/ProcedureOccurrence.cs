using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ProcedureOccurrence
    {
        public long Id { get; set; }
        public long ProcedureOccurrenceId { get; set; }
        public long PersonId { get; set; }
        public long ProcedureConceptId { get; set; }
        public byte[] ProcedureDate { get; set; }
        public long ProcedureTypeConceptId { get; set; }
        public long? ModifierConceptId { get; set; }
        public long? Quantity { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string ProcedureSourceValue { get; set; }
        public long? ProcedureSourceConceptId { get; set; }
        public string QualifierSourceValue { get; set; }
    }
}
