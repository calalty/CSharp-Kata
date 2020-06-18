using System;

namespace CSharp_Kata
{
    class Pie 
    {
        public int numberOfSlices;

        public int numberOfPeople;

        public int slicesPerPerson;
        public void Slices()
        {
            if (numberOfSlices / numberOfPeople >= slicesPerPerson ) 
            {
                Console.WriteLine("it's possible to split a pie fairly");
            }
            else 
            {
                Console.WriteLine("it's not possible to split a pie fairly");
            }
        }
    }
}