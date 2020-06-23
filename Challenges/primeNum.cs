using System;

namespace CSharp_Kata
{
    public class Prime
    {
        public int num;
        public void PrimeNum()
        {
            for (int i = 2; i < num; i++)
            {
            
                if (num % i == 0)
                {
                    Console.WriteLine($"is a prime number");
                }
            
                else 
                {
                
                   Console.WriteLine($"is not a prime number");
                }
            }
            
        }
    }
}