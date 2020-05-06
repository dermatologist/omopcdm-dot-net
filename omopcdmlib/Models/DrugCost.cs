using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugCost
    {
        public long Id { get; set; }
        public long DrugCostId { get; set; }
        public long DrugExposureId { get; set; }
        public long? CurrencyConceptId { get; set; }
        public byte[] PaidCopay { get; set; }
        public byte[] PaidCoinsurance { get; set; }
        public byte[] PaidTowardDeductible { get; set; }
        public byte[] PaidByPayer { get; set; }
        public byte[] PaidByCoordinationBenefits { get; set; }
        public byte[] TotalOutOfPocket { get; set; }
        public byte[] TotalPaid { get; set; }
        public byte[] IngredientCost { get; set; }
        public byte[] DispensingFee { get; set; }
        public byte[] AverageWholesalePrice { get; set; }
        public long? PayerPlanPeriodId { get; set; }
    }
}
