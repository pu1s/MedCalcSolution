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
            Console.ReadLine();
        }

        
    }

    public class ActionNew
    {
        public Limit limit1;

        public async void GetEmptyLimit()
        {
            MedicalProcedures mp = new MedicalProcedures();
            for(int i = 1; i<10; i++)
            {
                var t = await mp.IndexBodyMassAsync(i+1, i*i, new Limit("a", 0, 100), new Limit("b", 0, 200));
                Console.WriteLine(t.ToString());
            }
            
            
        }
    }
}
