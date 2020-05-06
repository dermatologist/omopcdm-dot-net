using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DeviceCost
    {
        public long Id { get; set; }
        public long DeviceCostId { get; set; }
        public long DeviceExposureId { get; set; }
        public long? CurrencyConceptId { get; set; }
        public byte[] PaidCopay { get; set; }
        public byte[] PaidCoinsurance { get; set; }
        public byte[] PaidTowardDeductible { get; set; }
        public byte[] PaidByPayer { get; set; }
        public byte[] PaidByCoordinationBenefits { get; set; }
        public byte[] TotalOutOfPocket { get; set; }
        public byte[] TotalPaid { get; set; }
        public long? PayerPlanPeriodId { get; set; }
    }
}
