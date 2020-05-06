using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugStrength
    {
        public long Id { get; set; }
        public long DrugConceptId { get; set; }
        public long IngredientConceptId { get; set; }
        public byte[] AmountValue { get; set; }
        public long? AmountUnitConceptId { get; set; }
        public byte[] NumeratorValue { get; set; }
        public long? NumeratorUnitConceptId { get; set; }
        public byte[] DenominatorValue { get; set; }
        public long? DenominatorUnitConceptId { get; set; }
        public long? BoxSize { get; set; }
        public byte[] ValidStartDate { get; set; }
        public byte[] ValidEndDate { get; set; }
        public string InvalidReason { get; set; }
    }
}
