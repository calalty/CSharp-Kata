/*
 TASK
 * Find out if number inputted by user...
 is ODD or EVEN...
 */

 using System;

 namespace CSharp_Kata
 {

    class OddorEven
    {
        public void isOddorEven(int n)
        {
            
            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");
            }
        }
           
            
    }

}