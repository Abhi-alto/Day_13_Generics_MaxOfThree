using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    public class maximum<utype> where utype:IComparable
    {   
        public utype[] values;                                                                    //instance variables array
        public maximum(params utype[] values)                           //parameterized constructor with params 
        {
            this.values = values;                                                     //initializing the values of the instance variables
        }
        public void sort()                                                   //sorting the array
        {
             Array.Sort(values); 
        }
        public void display()               //displaying the elements of the array
        {
            foreach(var utype in values)
            {
                Console.Write(utype+" ");
            }
            Console.WriteLine();
        }
        public utype max()                  //DISPLAYING THE LAST ELEMENT AS IT IS THE GREATEST ELEMENT
        {
            return values[values.Length-1];
        }
    }
}
