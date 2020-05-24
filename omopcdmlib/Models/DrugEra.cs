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
        public string DrugEraStartDate { get; set; }
        public string DrugEraEndDate { get; set; }
        public int? DrugExposureCount { get; set; }
        public int? GapDays { get; set; }
    }
}
