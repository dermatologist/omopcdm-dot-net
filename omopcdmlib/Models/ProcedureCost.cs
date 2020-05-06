using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ProcedureCost
    {
        public long Id { get; set; }
        public long ProcedureCostId { get; set; }
        public long ProcedureOccurrenceId { get; set; }
        public long? CurrencyConceptId { get; set; }
        public byte[] PaidCopay { get; set; }
        public byte[] PaidCoinsurance { get; set; }
        public byte[] PaidTowardDeductible { get; set; }
        public byte[] PaidByPayer { get; set; }
        public byte[] PaidByCoordinationBenefits { get; set; }
        public byte[] TotalOutOfPocket { get; set; }
        public byte[] TotalPaid { get; set; }
        public long? RevenueCodeConceptId { get; set; }
        public long? PayerPlanPeriodId { get; set; }
        public string RevenueCodeSourceValue { get; set; }
    }
}
