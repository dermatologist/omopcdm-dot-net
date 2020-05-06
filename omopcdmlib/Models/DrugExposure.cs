using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugExposure
    {
        public long Id { get; set; }
        public long DrugExposureId { get; set; }
        public long PersonId { get; set; }
        public long DrugConceptId { get; set; }
        public byte[] DrugExposureStartDate { get; set; }
        public byte[] DrugExposureEndDate { get; set; }
        public long DrugTypeConceptId { get; set; }
        public string StopReason { get; set; }
        public long? Refills { get; set; }
        public byte[] Quantity { get; set; }
        public long? DaysSupply { get; set; }
        public string Sig { get; set; }
        public long? RouteConceptId { get; set; }
        public byte[] EffectiveDrugDose { get; set; }
        public long? DoseUnitConceptId { get; set; }
        public string LotNumber { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string DrugSourceValue { get; set; }
        public long? DrugSourceConceptId { get; set; }
        public string RouteSourceValue { get; set; }
        public string DoseUnitSourceValue { get; set; }
    }
}
