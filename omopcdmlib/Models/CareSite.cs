using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CareSite
    {
        public int Id { get; set; }
        public int CareSiteId { get; set; }
        public string CareSiteName { get; set; }
        public int? PlaceOfServiceConceptId { get; set; }
        public int? LocationId { get; set; }
        public string CareSiteSourceValue { get; set; }
        public string PlaceOfServiceSourceValue { get; set; }
    }
}
