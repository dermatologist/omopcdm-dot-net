using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Concept
    {
        public int Id { get; set; }
        public int ConceptId { get; set; }
        public string ConceptName { get; set; }
        public string DomainId { get; set; }
        public string VocabularyId { get; set; }
        public string ConceptClassId { get; set; }
        public string StandardConcept { get; set; }
        public string ConceptCode { get; set; }
        public string ValidStartDate { get; set; }
        public string ValidEndDate { get; set; }
        public string InvalidReason { get; set; }

        public string GetNameForTest {
            get{
                return "Concept";
            }
        }
    }
}
