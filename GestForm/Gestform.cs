using System;
using System.Collections.Generic;
using System.Text;

namespace GestForm
{
    public static class Gestform
    {
        public static string Work(int n)
        {
            string ret = "";
            if (n % 3 == 0) ret = "Geste";
            if (n % 5 == 0) ret = "Forme";
            if (n % 3 == 0 && n % 5 == 0) ret = "Gestform";
            if (ret == "") ret = n.ToString();
            return ret;
        }
    }
}
