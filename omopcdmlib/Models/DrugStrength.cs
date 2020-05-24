using System;
using System.Collections.Generic;

namespace omopcdmlib.Models
{
    public partial class DrugStrength
    {
        public int Id { get; set; }
        public int DrugConceptId { get; set; }
        public int IngredientConceptId { get; set; }
        public string AmountValue { get; set; }
        public int? AmountUnitConceptId { get; set; }
        public string NumeratorValue { get; set; }
        public int? NumeratorUnitConceptId { get; set; }
        public string DenominatorValue { get; set; }
        public int? DenominatorUnitConceptId { get; set; }
        public int? BoxSize { get; set; }
        public string ValidStartDate { get; set; }
        public string ValidEndDate { get; set; }
        public string InvalidReason { get; set; }
    }
}
