using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    public class maximum
    {
        public static void max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is the greatest");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine(b + " is the greatest");
            }
            else if (c>a && c>b)
            {
                Console.WriteLine(c + " is the greatest");
            }
            else
            {
                Console.WriteLine("All three are equal");
            }
        }
    }
}
