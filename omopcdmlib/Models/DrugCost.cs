using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugCost
    {
        public int Id { get; set; }
        public int DrugCostId { get; set; }
        public int DrugExposureId { get; set; }
        public int? CurrencyConceptId { get; set; }
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
        public int? PayerPlanPeriodId { get; set; }
    }
}
