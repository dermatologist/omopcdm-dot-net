﻿using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class VisitCost
    {
        public int Id { get; set; }
        public int VisitCostId { get; set; }
        public int VisitOccurrenceId { get; set; }
        public int? CurrencyConceptId { get; set; }
        public string PaidCopay { get; set; }
        public string PaidCoinsurance { get; set; }
        public string PaidTowardDeductible { get; set; }
        public string PaidByPayer { get; set; }
        public string PaidByCoordinationBenefits { get; set; }
        public string TotalOutOfPocket { get; set; }
        public string TotalPaid { get; set; }
        public int? PayerPlanPeriodId { get; set; }
    }
}
