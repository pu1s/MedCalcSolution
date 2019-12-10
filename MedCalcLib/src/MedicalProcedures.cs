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

//#pragma warning disable CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
        public async Task<float> IndexBodyMassAsync(float weight,
//#pragma warning restore CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
                                                    float height,
                                                    Limit limitWeight,
                                                    Limit limitHeight)
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
