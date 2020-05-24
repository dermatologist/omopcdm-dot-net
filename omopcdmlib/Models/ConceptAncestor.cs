using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class ConceptAncestor
    {
        public int Id { get; set; }
        public int AncestorConceptId { get; set; }
        public int DescendantConceptId { get; set; }
        public int MinLevelsOfSeparation { get; set; }
        public int MaxLevelsOfSeparation { get; set; }
    }
}
