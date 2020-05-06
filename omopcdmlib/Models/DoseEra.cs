using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DoseEra
    {
        public long Id { get; set; }
        public long DoseEraId { get; set; }
        public long PersonId { get; set; }
        public long DrugConceptId { get; set; }
        public long UnitConceptId { get; set; }
        public byte[] DoseValue { get; set; }
        public byte[] DoseEraStartDate { get; set; }
        public byte[] DoseEraEndDate { get; set; }
    }
}
