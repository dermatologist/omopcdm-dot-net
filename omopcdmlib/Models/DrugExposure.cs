using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugExposure
    {
        public int Id { get; set; }
        public int DrugExposureId { get; set; }
        public int PersonId { get; set; }
        public int DrugConceptId { get; set; }
        public string DrugExposureStartDate { get; set; }
        public string DrugExposureEndDate { get; set; }
        public int DrugTypeConceptId { get; set; }
        public string StopReason { get; set; }
        public int? Refills { get; set; }
        public string Quantity { get; set; }
        public int? DaysSupply { get; set; }
        public string Sig { get; set; }
        public int? RouteConceptId { get; set; }
        public string EffectiveDrugDose { get; set; }
        public int? DoseUnitConceptId { get; set; }
        public string LotNumber { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string DrugSourceValue { get; set; }
        public int? DrugSourceConceptId { get; set; }
        public string RouteSourceValue { get; set; }
        public string DoseUnitSourceValue { get; set; }
    }
}
