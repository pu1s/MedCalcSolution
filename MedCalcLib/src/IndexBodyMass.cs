using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public class IndexBodyMassData
    {
        public float Wieght { get; set; }
        public float Hieght { get; set; }

        public Limit WieghtLimit { get; set; }
        public Limit HieghtLimit { get; set; }

        public IndexBodyMassData(float wieght, float wieghtLimitLower, float wieghtLimitUpper, float hieght, float hieghtLimitLower, float hieghtLimitUpper)
        {
            Wieght = wieght;
            Hieght = hieght;
            WieghtLimit = new Limit(wieghtLimitLower, wieghtLimitUpper);
            HieghtLimit = new Limit(hieghtLimitLower, hieghtLimitUpper);
        }

        public IndexBodyMassData(float wieght, Limit wieghtLimit, float hieght, Limit hieghtLimit)
        {
            Wieght = wieght;
            Hieght = hieght;
            WieghtLimit = wieghtLimit;
            HieghtLimit = hieghtLimit;
        }
    }
}
