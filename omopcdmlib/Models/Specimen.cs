using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Specimen
    {
        public int Id { get; set; }
        public int SpecimenId { get; set; }
        public int PersonId { get; set; }
        public int SpecimenConceptId { get; set; }
        public int SpecimenTypeConceptId { get; set; }
        public string SpecimenDate { get; set; }
        public string SpecimenTime { get; set; }
        public string Quantity { get; set; }
        public int? UnitConceptId { get; set; }
        public int? AnatomicSiteConceptId { get; set; }
        public int? DiseaseStatusConceptId { get; set; }
        public string SpecimenSourceId { get; set; }
        public string SpecimenSourceValue { get; set; }
        public string UnitSourceValue { get; set; }
        public string AnatomicSiteSourceValue { get; set; }
        public string DiseaseStatusSourceValue { get; set; }
    }
}
