using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    public class maximum<utype> where utype:IComparable
    {   
        utype[] array;                                                                    //instance variables array
        public maximum(utype[] array)                           //parameterized constructor
        {
            this.array = array;                                                     //initializing the values of the instance variables
        }
        public void sort()                                                   //sorting the array
        {
             Array.Sort(array); 
        }
        public void display()               //displaying the elements of the array
        {
            foreach(var utype in array)
            {
                Console.Write(utype+" ");
            }
            Console.WriteLine();
        }
        public utype max()                  //DISPLAYING THE LAST ELEMENT AS IT IS THE GREATEST ELEMENT
        {
            return array[array.Length-1];
        }
    }
}
