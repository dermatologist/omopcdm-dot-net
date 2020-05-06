using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DeviceExposure
    {
        public long Id { get; set; }
        public long DeviceExposureId { get; set; }
        public long PersonId { get; set; }
        public long DeviceConceptId { get; set; }
        public byte[] DeviceExposureStartDate { get; set; }
        public byte[] DeviceExposureEndDate { get; set; }
        public long DeviceTypeConceptId { get; set; }
        public string UniqueDeviceId { get; set; }
        public long? Quantity { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string DeviceSourceValue { get; set; }
        public long? DeviceSourceConceptId { get; set; }
    }
}
