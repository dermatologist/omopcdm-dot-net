using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ObservationPeriod
    {
        public long Id { get; set; }
        public long ObservationPeriodId { get; set; }
        public long PersonId { get; set; }
        public byte[] ObservationPeriodStartDate { get; set; }
        public byte[] ObservationPeriodEndDate { get; set; }
        public long PeriodTypeConceptId { get; set; }
    }
}
