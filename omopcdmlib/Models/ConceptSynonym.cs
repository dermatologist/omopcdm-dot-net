using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptSynonym
    {
        public long Id { get; set; }
        public long ConceptId { get; set; }
        public string ConceptSynonymName { get; set; }
        public long LanguageConceptId { get; set; }
    }
}
