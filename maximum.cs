﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    public class maximum<utype> where utype:IComparable
    {
        public static void max(utype a, utype b, utype c)
        {
            if (a.CompareTo(b)>0 && a.CompareTo(c) > 0|| a.CompareTo(b) >= 0 && a.CompareTo(c) > 0|| a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine(a + " is the greatest");
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0|| b.CompareTo(a) >= 0 && b.CompareTo(c) > 0|| b.CompareTo(a) > 0 && b.CompareTo(c) >=0)
            {
                Console.WriteLine(b + " is the greatest");
            }
            else if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0|| c.CompareTo(a) > 0 && c.CompareTo(b) >= 0|| c.CompareTo(a) >= 0 && c.CompareTo(b) > 0)
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
