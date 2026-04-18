using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techrel
{
    internal class MathHelper
    {
        public static int Findmax(int a, int b, int c)
        {
            int result = (a > b && a > c) ? a : (b > c && b > a) ? b : (c > a && c > b) ? c : 0;

            return result;
        }

        public static int GetAddition(int a, int b)
        => a + b;

    }
}
