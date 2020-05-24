using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public int PersonId { get; set; }
        public string NoteDate { get; set; }
        public string NoteTime { get; set; }
        public int NoteTypeConceptId { get; set; }
        public string NoteText { get; set; }
        public int? ProviderId { get; set; }
        public int? VisitOccurrenceId { get; set; }
        public string NoteSourceValue { get; set; }
    }
}
