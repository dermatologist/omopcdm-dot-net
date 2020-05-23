using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DeviceExposure
    {
        public int Id { get; set; }
        public int DeviceExposureId { get; set; }
        public int PersonId { get; set; }
        public int DeviceConceptId { get; set; }
        public byte[] DeviceExposureStartDate { get; set; }
        public byte[] DeviceExposureEndDate { get; set; }
        public int DeviceTypeConceptId { get; set; }
        public string UniqueDeviceId { get; set; }
        public int? Quantity { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string DeviceSourceValue { get; set; }
        public int? DeviceSourceConceptId { get; set; }
    }
}
