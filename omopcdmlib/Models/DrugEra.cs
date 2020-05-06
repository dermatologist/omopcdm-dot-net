using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugEra
    {
        public long Id { get; set; }
        public long DrugEraId { get; set; }
        public long PersonId { get; set; }
        public long DrugConceptId { get; set; }
        public byte[] DrugEraStartDate { get; set; }
        public byte[] DrugEraEndDate { get; set; }
        public long? DrugExposureCount { get; set; }
        public long? GapDays { get; set; }
    }
}
