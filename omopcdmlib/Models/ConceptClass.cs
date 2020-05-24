using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptClass
    {
        public int Id { get; set; }
        public string ConceptClassId { get; set; }
        public string ConceptClassName { get; set; }
        public int ConceptClassConceptId { get; set; }
    }
}
