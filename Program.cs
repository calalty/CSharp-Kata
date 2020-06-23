using System;

namespace CSharp_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Pie slices = new Pie();
            Console.Write("Can we split a pie fairly? ");
            Console.Write("Please enter number of slices: ");
            slices.numberOfSlices = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number of people: ");
            slices.numberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number of slices per person: ");
            slices.slicesPerPerson = Convert.ToInt32(Console.ReadLine());
            slices.Slices();
            

            Console.WriteLine("---------");

            OddorEven oddOrEven = new OddorEven();
            oddOrEven.isOddorEven(2);

            Console.WriteLine("---------");

            AgeCalculator checkAge = new AgeCalculator();
            Console.Write("Please enter age: ");
            string userInput = Console.ReadLine();
            checkAge.Calculator(Convert.ToInt32(userInput));
            Console.WriteLine($"as this person is {userInput} years of age");

            Console.WriteLine("---------");

            Prime primeNum = new Prime();
            Console.Write("Please enter a number: ");
            primeNum.num = Convert.ToInt32(Console.ReadLine());
            primeNum.PrimeNum();

            Console.WriteLine("---------");

            Space stringSpace = new Space();
            Console.Write("Please enter a string: ");
            stringSpace.sentence = Console.ReadLine();
            stringSpace.StringSpace();

            Console.WriteLine("---------");

            // HackerSpeak hackerSpeak = new HackerSpeak();
            // hackerSpeak.HackerLang("hello");







        }
    }
}
