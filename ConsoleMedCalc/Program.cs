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
            Console.WriteLine(limit1.ToString());
        }
    }
}
