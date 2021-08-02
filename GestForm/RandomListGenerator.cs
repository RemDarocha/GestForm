using System;
using System.Collections.Generic;
using System.Text;

namespace GestForm
{
    public static class RandomListGenerator
    {

        public static List<int> Generate()
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ret.Add(RandomIntegerGenerator());
            }
            return ret;
        }

        private static int RandomIntegerGenerator()
        {
            Random rand = new Random();
            int ret = rand.Next(2001);
            ret = ret - 1000;
            return ret;
        }


    }
}
