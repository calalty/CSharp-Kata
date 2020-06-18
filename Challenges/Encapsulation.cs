using System;

namespace CSharp_Kata
{
    class Encapsulation
    {
        private double salary;

        private string jobRole;

        public void DisplayMe()
        {
            salary = 10;
            jobRole = "Frube eater";
            Console.WriteLine($"My role is {jobRole} and i am paid £{salary}m to do it");
        }
    }
}