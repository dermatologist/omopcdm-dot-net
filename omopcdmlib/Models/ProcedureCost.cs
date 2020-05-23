using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ProcedureCost
    {
        public int Id { get; set; }
        public int ProcedureCostId { get; set; }
        public int ProcedureOccurrenceId { get; set; }
        public int? CurrencyConceptId { get; set; }
        public byte[] PaidCopay { get; set; }
        public byte[] PaidCoinsurance { get; set; }
        public byte[] PaidTowardDeductible { get; set; }
        public byte[] PaidByPayer { get; set; }
        public byte[] PaidByCoordinationBenefits { get; set; }
        public byte[] TotalOutOfPocket { get; set; }
        public byte[] TotalPaid { get; set; }
        public int? RevenueCodeConceptId { get; set; }
        public int? PayerPlanPeriodId { get; set; }
        public string RevenueCodeSourceValue { get; set; }
    }
}
