using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Observation
    {
        public int Id { get; set; }
        public int ObservationId { get; set; }
        public int PersonId { get; set; }
        public int ObservationConceptId { get; set; }
        public string ObservationDate { get; set; }
        public string ObservationTime { get; set; }
        public int ObservationTypeConceptId { get; set; }
        public string ValueAsNumber { get; set; }
        public string ValueAsString { get; set; }
        public int? ValueAsConceptId { get; set; }
        public int? QualifierConceptId { get; set; }
        public int? UnitConceptId { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string ObservationSourceValue { get; set; }
        public int? ObservationSourceConceptId { get; set; }
        public string UnitSourceValue { get; set; }
        public string QualifierSourceValue { get; set; }
    }
}
