using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ProcedureOccurrence
    {
        public int Id { get; set; }
        public int ProcedureOccurrenceId { get; set; }
        public int PersonId { get; set; }
        public int ProcedureConceptId { get; set; }
        public byte[] ProcedureDate { get; set; }
        public int ProcedureTypeConceptId { get; set; }
        public int? ModifierConceptId { get; set; }
        public int? Quantity { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string ProcedureSourceValue { get; set; }
        public int? ProcedureSourceConceptId { get; set; }
        public string QualifierSourceValue { get; set; }
    }
}
