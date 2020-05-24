using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Cohort
    {
        public int Id { get; set; }
        public int CohortDefinitionId { get; set; }
        public int SubjectId { get; set; }
        public string CohortStartDate { get; set; }
        public string CohortEndDate { get; set; }
    }
}
