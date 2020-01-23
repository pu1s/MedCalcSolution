using System;
using MedCalc;

namespace ConsoleMedCalc
{
    class Program
    {

        static void Main(string[] args)
        {
            Limit l = new Limit();
            Limit l1 = new Limit(0, 1);
                go.Go();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
 
        class go
        {
            public static async void Go()
            {
                float a = await MedProc.IndexBodyMassAsync(1, 10);
                Console.WriteLine(a);
            }
        }
    }
  
}
