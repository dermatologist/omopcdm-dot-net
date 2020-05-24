using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Provider
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string Npi { get; set; }
        public string Dea { get; set; }
        public int? SpecialtyConceptId { get; set; }
        public int? CareSiteId { get; set; }
        public int? YearOfBirth { get; set; }
        public int? GenderConceptId { get; set; }
        public string ProviderSourceValue { get; set; }
        public string SpecialtySourceValue { get; set; }
        public int? SpecialtySourceConceptId { get; set; }
        public string GenderSourceValue { get; set; }
        public int? GenderSourceConceptId { get; set; }
    }
}
