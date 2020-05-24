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
        public string PaidCopay { get; set; }
        public string PaidCoinsurance { get; set; }
        public string PaidTowardDeductible { get; set; }
        public string PaidByPayer { get; set; }
        public string PaidByCoordinationBenefits { get; set; }
        public string TotalOutOfPocket { get; set; }
        public string TotalPaid { get; set; }
        public string IngredientCost { get; set; }
        public string DispensingFee { get; set; }
        public string AverageWholesalePrice { get; set; }
        public int? PayerPlanPeriodId { get; set; }
    }
}
