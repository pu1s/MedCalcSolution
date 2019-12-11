using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public partial class MedicalProcedures
    {

        public float IndexBodyMass(float weight, float height, Limit limitWeight, Limit limitHeight)
        {
            const float FAILED = -1f;
            if(!limitWeight.IsTry && !limitHeight.IsTry) return FAILED;
            if(weight> limitWeight.Upper && weight < limitWeight.Lower) return FAILED;
            if (height > limitHeight.Upper && height < limitHeight.Lower) return FAILED;
            return weight / (height * height);
        }

        public float IndexBodyMass(float weight, float height, Limit limitWeight, Limit limitHeight, ref int errorCode)
        {
            const float FAILED = -1f;
            const int ERROR_LIMIT = 0x000;
            const int ERROR_RANGE = 0x001;
            const int ERROR_ARGUM = 0x002;
            if (weight == 0 || height == 0)
            {
                errorCode = ERROR_ARGUM;
                return FAILED;
            }
            if (!limitWeight.IsTry && !limitHeight.IsTry) 
            { 
                errorCode = ERROR_LIMIT; 
                return FAILED; 
            }
            if (weight > limitWeight.Upper && weight < limitWeight.Lower)
            {
                errorCode = ERROR_RANGE;
                return FAILED;
            }

            if (height > limitHeight.Upper && height < limitHeight.Lower) return FAILED;
            return weight / (height * height);
        }

        public async Task<float> IndexBodyMassAsync(float weight, float height, Limit limitWeight, Limit limitHeight)
            {
                return await Task.Run(() => IndexBodyMass(weight, height, limitWeight, limitHeight));
            }
    }
}
