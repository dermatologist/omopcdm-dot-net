using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Domain
    {
        public string DomainId { get; set; }
        public string DomainName { get; set; }
        public int DomainConceptId { get; set; }
    }
}
