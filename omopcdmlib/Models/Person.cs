using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class Person
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public long GenderConceptId { get; set; }
        public long YearOfBirth { get; set; }
        public long? MonthOfBirth { get; set; }
        public long? DayOfBirth { get; set; }
        public string TimeOfBirth { get; set; }
        public long RaceConceptId { get; set; }
        public long EthnicityConceptId { get; set; }
        public long? LocationId { get; set; }
        public long? ProviderId { get; set; }
        public long? CareSiteId { get; set; }
        public string PersonSourceValue { get; set; }
        public string GenderSourceValue { get; set; }
        public long? GenderSourceConceptId { get; set; }
        public string RaceSourceValue { get; set; }
        public long? RaceSourceConceptId { get; set; }
        public string EthnicitySourceValue { get; set; }
        public long? EthnicitySourceConceptId { get; set; }
    }
}
