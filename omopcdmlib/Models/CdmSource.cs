using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class CdmSource
    {
        public long Id { get; set; }
        public string CdmSourceName { get; set; }
        public string CdmSourceAbbreviation { get; set; }
        public string CdmHolder { get; set; }
        public string SourceDescription { get; set; }
        public string SourceDocumentationReference { get; set; }
        public string CdmEtlReference { get; set; }
        public byte[] SourceReleaseDate { get; set; }
        public byte[] CdmReleaseDate { get; set; }
        public string CdmVersion { get; set; }
        public string VocabularyVersion { get; set; }
    }
}
