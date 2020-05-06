using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Measurement
    {
        public long Id { get; set; }
        public long MeasurementId { get; set; }
        public long PersonId { get; set; }
        public long MeasurementConceptId { get; set; }
        public byte[] MeasurementDate { get; set; }
        public string MeasurementTime { get; set; }
        public long MeasurementTypeConceptId { get; set; }
        public long? OperatorConceptId { get; set; }
        public byte[] ValueAsNumber { get; set; }
        public long? ValueAsConceptId { get; set; }
        public long? UnitConceptId { get; set; }
        public byte[] RangeLow { get; set; }
        public byte[] RangeHigh { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string MeasurementSourceValue { get; set; }
        public long? MeasurementSourceConceptId { get; set; }
        public string UnitSourceValue { get; set; }
        public string ValueSourceValue { get; set; }
    }
}
