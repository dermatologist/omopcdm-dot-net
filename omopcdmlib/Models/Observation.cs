using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Observation
    {
        public long Id { get; set; }
        public long ObservationId { get; set; }
        public long PersonId { get; set; }
        public long ObservationConceptId { get; set; }
        public byte[] ObservationDate { get; set; }
        public string ObservationTime { get; set; }
        public long ObservationTypeConceptId { get; set; }
        public byte[] ValueAsNumber { get; set; }
        public string ValueAsString { get; set; }
        public long? ValueAsConceptId { get; set; }
        public long? QualifierConceptId { get; set; }
        public long? UnitConceptId { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string ObservationSourceValue { get; set; }
        public long? ObservationSourceConceptId { get; set; }
        public string UnitSourceValue { get; set; }
        public string QualifierSourceValue { get; set; }
    }
}
