using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ObservationPeriod
    {
        public int Id { get; set; }
        public int ObservationPeriodId { get; set; }
        public int PersonId { get; set; }
        public byte[] ObservationPeriodStartDate { get; set; }
        public byte[] ObservationPeriodEndDate { get; set; }
        public int PeriodTypeConceptId { get; set; }
    }
}
