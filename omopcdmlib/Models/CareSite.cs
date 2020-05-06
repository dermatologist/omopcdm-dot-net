using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CareSite
    {
        public long Id { get; set; }
        public long CareSiteId { get; set; }
        public string CareSiteName { get; set; }
        public long? PlaceOfServiceConceptId { get; set; }
        public long? LocationId { get; set; }
        public string CareSiteSourceValue { get; set; }
        public string PlaceOfServiceSourceValue { get; set; }
    }
}
