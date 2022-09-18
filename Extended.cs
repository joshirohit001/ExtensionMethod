using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal static class Extended
    {
        public static int SquareOfNumber(this int number)
        {
            int result = number * number;
            return result;
        }
    }
}
