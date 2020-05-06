using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Provider
    {
        public long Id { get; set; }
        public long ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string Npi { get; set; }
        public string Dea { get; set; }
        public long? SpecialtyConceptId { get; set; }
        public long? CareSiteId { get; set; }
        public long? YearOfBirth { get; set; }
        public long? GenderConceptId { get; set; }
        public string ProviderSourceValue { get; set; }
        public string SpecialtySourceValue { get; set; }
        public long? SpecialtySourceConceptId { get; set; }
        public string GenderSourceValue { get; set; }
        public long? GenderSourceConceptId { get; set; }
    }
}
