using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public class MedProc
    {
        public static float IndexBodyMass(float wieght, NamedLimit wiegthLimit, float hiegth, NamedLimit hiegthLimit, int flag = 0, Delegate del = null)
        {
            // Проверка аргументов

        }

        public static float IndexBodyMass(float w, float h, NamedLimit namedLimit)
        {
            if (w == 0) throw new ArgumentNullException(@"Аргумент не может равняться нулю!");
            return w / (h * h);
        }

        public static Task<float> IndexBodyMassAsync(float w, float h)
        {
            return Task.Run(() => {
                return IndexBodyMass(w, h);
            });
        }
    }
}
