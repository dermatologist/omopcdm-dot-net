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
        public byte[] DoseValue { get; set; }
        public byte[] DoseEraStartDate { get; set; }
        public byte[] DoseEraEndDate { get; set; }
    }
}
