using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Note
    {
        public long Id { get; set; }
        public long NoteId { get; set; }
        public long PersonId { get; set; }
        public byte[] NoteDate { get; set; }
        public string NoteTime { get; set; }
        public long NoteTypeConceptId { get; set; }
        public string NoteText { get; set; }
        public long? ProviderId { get; set; }
        public long? VisitOccurrenceId { get; set; }
        public string NoteSourceValue { get; set; }
    }
}
