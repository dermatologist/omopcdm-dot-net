using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptAncestor
    {
        public long Id { get; set; }
        public long AncestorConceptId { get; set; }
        public long DescendantConceptId { get; set; }
        public long MinLevelsOfSeparation { get; set; }
        public long MaxLevelsOfSeparation { get; set; }
    }
}
