using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public partial class MedicalProcedures
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wight"></param>
        /// <param name="hieght"></param>
        /// <param name="limitWigth"></param>
        /// <param name="limitHieght"></param>
        /// <param name="callbackAction"></param>
        public float IndexBodyMass(float wight, float hieght, Limit limitWigth,  Limit limitHieght)
        {
            float result = 0f;
            if (wight == 0 && hieght == 0) return result;
            if (!limitHieght.IsTry && !limitWigth.IsTry) return result;
            else if((wight< limitWigth.Upper) || (wight > limitWigth.Lower) && (hieght < limitHieght.Upper) || (hieght > limitHieght.Lower))
            {
                result = wight / (hieght * hieght);
            }
            return result;
        }

        public Task<float> IndexBodyMassAsync(float wight, float hieght, Limit limitWigth, Limit limitHieght)
        { 
            return new Task<float>( () => {
                
                return IndexBodyMass(wight, hieght, limitWigth, limitHieght); 
            });         
        }
    }
}
