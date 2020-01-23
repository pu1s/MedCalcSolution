using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public class Calculator
    {
        public static bool ArgumentExamination(ref float argument, Limit limit)
        {
            return argument < limit.Lower || argument > limit.Upper ? false : true;
        }
        public static bool ArgumentExamination(ref float argument, NamedLimit limit)
        {
            return argument < limit.Limit.Lower || argument > limit.Limit.Upper ? false : true;
        }

        public static float IndexBodyMass(float wieght, NamedLimit wieghtLimit, float hieght, NamedLimit hieghtLimit, int flag = 0)
        {
            // Проверка аргументов
            if (wieght == 0) throw new ArgumentOutOfRangeException(@"Аргумент вес не может быть равен нулю!");
            // Хотя в математическом плане противоречий нет, но по логике программы проверяе и второй аргумент 
            if (hieght == 0) throw new ArgumentOutOfRangeException(@"Аргумент рост не может быть равен нулю!");
            //
            // Проверка соответствия аргументов пределам
            //
            if (!ArgumentExamination(ref wieght, wieghtLimit)) throw new ArgumentOutOfRangeException(@"Первый аргумент выходит из предела!");
            //
            if (!ArgumentExamination(ref hieght, hieghtLimit)) throw new ArgumentOutOfRangeException(@"Второй аргумент выходит из предела!");
            //
            return wieght/(hieght * hieght);
        }



        public static Task<float> IndexBodyMassAsync(float wieght, NamedLimit wiegthLimit, float hiegth, NamedLimit hiegthLimit, int flag = 0)
        {
            return Task.Run(() =>
            {
                return IndexBodyMass(wieght, wiegthLimit, hiegth, hiegthLimit);
            });
        }
    }
}
