using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public partial class MedicalProcedures
    {
       
        public float IndexBodyMass(float weight, float height, Limit limitWeight,  Limit limitHeight)
        {
            var res = weight / (height * height);
            return res;
        }


        public async Task<float> IndexBodyMassAsync(float weight, float height, Limit limitWeight, Limit limitHeight)
        {
           var t = new Task<float>(() =>
            {
                return IndexBodyMass(weight, height, limitWeight, limitHeight);
            });
            t.Start();
            return t.Result;
        }
    }
}
