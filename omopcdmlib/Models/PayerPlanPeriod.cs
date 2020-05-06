using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class PayerPlanPeriod
    {
        public long Id { get; set; }
        public long PayerPlanPeriodId { get; set; }
        public long PersonId { get; set; }
        public byte[] PayerPlanPeriodStartDate { get; set; }
        public byte[] PayerPlanPeriodEndDate { get; set; }
        public string PayerSourceValue { get; set; }
        public string PlanSourceValue { get; set; }
        public string FamilySourceValue { get; set; }
    }
}
