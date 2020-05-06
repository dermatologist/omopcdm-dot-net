using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Death
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public byte[] DeathDate { get; set; }
        public long DeathTypeConceptId { get; set; }
        public long? CauseConceptId { get; set; }
        public string CauseSourceValue { get; set; }
        public long? CauseSourceConceptId { get; set; }
    }
}
