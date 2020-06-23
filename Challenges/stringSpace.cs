using System;

namespace CSharp_Kata
{
    public class Space
    {
        public string sentence;

        public void StringSpace()
        {
            if (sentence.Contains(" "))
            {
                Console.WriteLine("Spaces");
            }
            else
            {
                 Console.WriteLine("No Spaces");
            }
        }

    }
}