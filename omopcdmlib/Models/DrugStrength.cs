using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugStrength
    {
        public int Id { get; set; }
        public int DrugConceptId { get; set; }
        public int IngredientConceptId { get; set; }
        public byte[] AmountValue { get; set; }
        public int? AmountUnitConceptId { get; set; }
        public byte[] NumeratorValue { get; set; }
        public int? NumeratorUnitConceptId { get; set; }
        public byte[] DenominatorValue { get; set; }
        public int? DenominatorUnitConceptId { get; set; }
        public int? BoxSize { get; set; }
        public byte[] ValidStartDate { get; set; }
        public byte[] ValidEndDate { get; set; }
        public string InvalidReason { get; set; }
    }
}
