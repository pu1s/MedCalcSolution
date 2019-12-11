using System;
using MedCalc;

namespace ConsoleMedCalc
{
    class Program
    {

        

        static void Main(string[] args)
        {
            ActionNew actionNew = new ActionNew();
            actionNew.GetEmptyLimit();

            Console.WriteLine("Hello World!");
        }

        
    }

    public class ActionNew
    {
        public Limit limit1;

        public void GetEmptyLimit()
        {
            limit1 = Limit.Empty;
            limit1 = new Limit("Up", 0, 10);
            var a = limit1.IsTry;
            MedicalProcedures ass = new MedicalProcedures();
            var m = ass.IndexBodyMassAsync(10, 20, new Limit("aa", 0, 25), new Limit("dw", 0, 26)).Result;
            Console.WriteLine(m.ToString());
        }
    }
}
