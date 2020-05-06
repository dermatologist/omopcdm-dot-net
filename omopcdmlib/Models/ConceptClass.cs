using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptClass
    {
        public long Id { get; set; }
        public string ConceptClassId { get; set; }
        public string ConceptClassName { get; set; }
        public long ConceptClassConceptId { get; set; }
    }
}
