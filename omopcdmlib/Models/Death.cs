using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Death
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public byte[] DeathDate { get; set; }
        public int DeathTypeConceptId { get; set; }
        public int? CauseConceptId { get; set; }
        public string CauseSourceValue { get; set; }
        public int? CauseSourceConceptId { get; set; }
    }
}
