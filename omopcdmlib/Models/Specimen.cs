using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Specimen
    {
        public long Id { get; set; }
        public long SpecimenId { get; set; }
        public long PersonId { get; set; }
        public long SpecimenConceptId { get; set; }
        public long SpecimenTypeConceptId { get; set; }
        public byte[] SpecimenDate { get; set; }
        public string SpecimenTime { get; set; }
        public byte[] Quantity { get; set; }
        public long? UnitConceptId { get; set; }
        public long? AnatomicSiteConceptId { get; set; }
        public long? DiseaseStatusConceptId { get; set; }
        public string SpecimenSourceId { get; set; }
        public string SpecimenSourceValue { get; set; }
        public string UnitSourceValue { get; set; }
        public string AnatomicSiteSourceValue { get; set; }
        public string DiseaseStatusSourceValue { get; set; }
    }
}
