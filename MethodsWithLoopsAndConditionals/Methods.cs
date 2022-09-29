using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void GrandCount() //Write a method that will print to the console all numbers 1000 through -1000
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            
        
        }

       public static void TripleThreat()  //Method 2- Write a method that will print to the console numbers 3 through 999 by 3 each time
        {
            for (int j = 3; j<= 999; j+=3)
            {
                Console.WriteLine(j);
            }
        }
       // public static void NotEqual(int num l, int num m)  //Method to accept 2 integers and check for equal or not 
          
           // if (Num l == num m )

       

    }
}
