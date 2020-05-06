using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Location
    {
        public long Id { get; set; }
        public long LocationId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
        public string LocationSourceValue { get; set; }
    }
}
