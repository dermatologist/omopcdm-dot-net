using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DoseEra
    {
        public int Id { get; set; }
        public int DoseEraId { get; set; }
        public int PersonId { get; set; }
        public int DrugConceptId { get; set; }
        public int UnitConceptId { get; set; }
        public string DoseValue { get; set; }
        public string DoseEraStartDate { get; set; }
        public string DoseEraEndDate { get; set; }
    }
}
