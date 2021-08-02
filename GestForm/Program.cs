using System;
using System.Collections.Generic;

namespace GestForm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = RandomListGenerator.Generate();
            //Console.WriteLine(numberList..ToString());
            foreach (int n in numberList)
            {
                Console.WriteLine(n.ToString() + " -> " + Gestform.Work(n));
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
