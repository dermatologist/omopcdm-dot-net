using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Measurement
    {
        public int Id { get; set; }
        public int MeasurementId { get; set; }
        public int PersonId { get; set; }
        public int MeasurementConceptId { get; set; }
        public byte[] MeasurementDate { get; set; }
        public string MeasurementTime { get; set; }
        public int MeasurementTypeConceptId { get; set; }
        public int? OperatorConceptId { get; set; }
        public byte[] ValueAsNumber { get; set; }
        public int? ValueAsConceptId { get; set; }
        public int? UnitConceptId { get; set; }
        public byte[] RangeLow { get; set; }
        public byte[] RangeHigh { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string MeasurementSourceValue { get; set; }
        public int? MeasurementSourceConceptId { get; set; }
        public string UnitSourceValue { get; set; }
        public string ValueSourceValue { get; set; }
    }
}
