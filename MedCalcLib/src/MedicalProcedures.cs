using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public partial class MedicalProcedures
    {
        
         
      public enum MedicalProcErrorCode : int
        {
            PROC_FAILED     = -0x001,
            PROC_SUCCESSFUL = 0x000,
            PROC_ERR_LIMIT  = 0x002,
            PROC_ERR_RANGE  = 0x004,
            PROC_ERR_AGRS   = 0x008,
        }
        public float IndexBodyMass(float weight, float height, Limit limitWeight, Limit limitHeight)
        {
            if(!limitWeight.IsTry && !limitHeight.IsTry) return (float)MedicalProcErrorCode.PROC_FAILED;
            if(weight> limitWeight.Upper && weight < limitWeight.Lower) return (float)MedicalProcErrorCode.PROC_FAILED;
            if (height > limitHeight.Upper && height < limitHeight.Lower) return (float)MedicalProcErrorCode.PROC_FAILED;
            return weight / (height * height);
        }

        public float IndexBodyMass(float weight, float height, Limit limitWeight, Limit limitHeight, ref int errorCode)
        {
            
            if (weight == 0 || height == 0)
            {
                errorCode = (int)MedicalProcErrorCode.PROC_ERR_AGRS;
                return (float)MedicalProcErrorCode.PROC_FAILED;
            }
            if (!limitWeight.IsTry && !limitHeight.IsTry) 
            { 
                errorCode = (int)MedicalProcErrorCode.PROC_ERR_LIMIT;
                return (float)MedicalProcErrorCode.PROC_FAILED;
            }
            if (weight > limitWeight.Upper && weight < limitWeight.Lower)
            {
                errorCode = (int)MedicalProcErrorCode.PROC_ERR_RANGE;
                return (float)MedicalProcErrorCode.PROC_FAILED;
            }

            if (height > limitHeight.Upper && height < limitHeight.Lower) return (float)MedicalProcErrorCode.PROC_FAILED;
            else
            return weight / (height * height);
        }

        public async Task<float> IndexBodyMassAsync(float weight, float height, Limit limitWeight, Limit limitHeight)
            {
                return await Task.Run(() => IndexBodyMass(weight, height, limitWeight, limitHeight));
            }
    }
}
