using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class PayerPlanPeriod
    {
        public int Id { get; set; }
        public int PayerPlanPeriodId { get; set; }
        public int PersonId { get; set; }
        public string PayerPlanPeriodStartDate { get; set; }
        public string PayerPlanPeriodEndDate { get; set; }
        public string PayerSourceValue { get; set; }
        public string PlanSourceValue { get; set; }
        public string FamilySourceValue { get; set; }
    }
}
