using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugEra
    {
        public int Id { get; set; }
        public int DrugEraId { get; set; }
        public int PersonId { get; set; }
        public int DrugConceptId { get; set; }
        public byte[] DrugEraStartDate { get; set; }
        public byte[] DrugEraEndDate { get; set; }
        public int? DrugExposureCount { get; set; }
        public int? GapDays { get; set; }
    }
}
