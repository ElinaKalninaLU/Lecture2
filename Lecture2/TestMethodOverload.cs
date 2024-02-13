using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    public static class TestMethodOverload
    {
        public static string transformtotext(int i)
        {
            Debug.Print("int version");
            return i.ToString();
        }

       public static string transformtotext(bool b)
        {
            Debug.Print("bool version");
            return b.ToString();
        }

        public static string transformtotext(bool b, int i)
        {
            Debug.Print("bool version");
            return b.ToString();
        }
    }
}
