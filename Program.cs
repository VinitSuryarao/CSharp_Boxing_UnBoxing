using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing :- Convert Value Type to Object Type
            int a = 102;
            Object b = a;

            // Unboxing :- Convert Object Type to Value Type
            object x = 105;
            int y = Convert.ToInt32(x);

        }
    }
}
