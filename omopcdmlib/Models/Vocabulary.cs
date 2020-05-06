using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Vocabulary
    {
        public string VocabularyId { get; set; }
        public string VocabularyName { get; set; }
        public string VocabularyReference { get; set; }
        public string VocabularyVersion { get; set; }
        public long VocabularyConceptId { get; set; }
    }
}
