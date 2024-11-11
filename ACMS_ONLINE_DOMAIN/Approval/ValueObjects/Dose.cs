using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_DOMAIN.Approval.ValueObjects
{
    // Value Object: Dose
    public class Dose
    {
        public double? DoseUnits { get; private set; }  
        public int? DoseRepeat { get; private set; }   
        public int? DoseDuration { get; private set; }
        public int? DoseDurType { get;private set; }
        public int? MinUnits { get;private set; }




        public Dose(float? doseUnits, int? doseRepeat, int? doseDuration)
        {
            if (doseUnits.HasValue && doseUnits <= 0) throw new ArgumentException("Dose units must be positive");
            if (doseRepeat.HasValue && doseRepeat <= 0) throw new ArgumentException("Dose repeat must be positive");
            if (doseDuration.HasValue && doseDuration <= 0) throw new ArgumentException("Dose duration must be positive");

            DoseUnits = doseUnits;
            DoseRepeat = doseRepeat;
            DoseDuration = doseDuration;
        }

        
        public double? CalculateTotalQuantity()
        {
            if (!DoseUnits.HasValue || !DoseRepeat.HasValue || !DoseDuration.HasValue)
                return null;

            return  DoseRepeat.Value * DoseDuration.Value / DoseUnits.Value/*handle devide by zero! */;
        }

        
    }

}
