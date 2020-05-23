using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class SourceToConceptMap
    {
        public int Id { get; set; }
        public string SourceCode { get; set; }
        public int SourceConceptId { get; set; }
        public string SourceVocabularyId { get; set; }
        public string SourceCodeDescription { get; set; }
        public int TargetConceptId { get; set; }
        public string TargetVocabularyId { get; set; }
        public byte[] ValidStartDate { get; set; }
        public byte[] ValidEndDate { get; set; }
        public string InvalidReason { get; set; }
    }
}
