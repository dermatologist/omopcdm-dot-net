using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Cohort
    {
        public int Id { get; set; }
        public int CohortDefinitionId { get; set; }
        public int SubjectId { get; set; }
        public byte[] CohortStartDate { get; set; }
        public byte[] CohortEndDate { get; set; }
    }
}
