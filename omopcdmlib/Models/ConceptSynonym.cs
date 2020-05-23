using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptSynonym
    {
        public int Id { get; set; }
        public int ConceptId { get; set; }
        public string ConceptSynonymName { get; set; }
        public int LanguageConceptId { get; set; }
    }
}
