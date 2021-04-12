using System;
using System.Collections.Generic;

namespace PrimeNumbersLab
{
    enum Prime
    {
        Prime,
        NotPrime
    }

    public class PrimeNumbers
    {
        public int GetPrime(int userInput)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            Prime primes;

            for (int i = 4; primeNumbers.Count < userInput; i++)
            {
                int primeCount = primeNumbers.Count;

                for (int i2 = 0; i2 < primeCount; i2++)
                {
                    if (i % primeNumbers[i2] == 0)
                    {
                        break;
                    }
                    else if (i2 == primeCount - 1)
                    {
                        primeNumbers.Add(i);
                    }
                }
            }

            int userinputPrime = primeNumbers[userInput - 1];

            if (primeNumbers.Contains(userinputPrime))
            {
                primes = Prime.Prime;
            }
            else
            {
                primes = Prime.NotPrime;
            }
            return primeNumbers[userInput - 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers test = new PrimeNumbers();

            Console.WriteLine("Let's locate some primes!");
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.");

            bool done = false;
            while (!done)
            {
                Console.WriteLine("Which prime number are you looking for?");
                int userInput = Int32.Parse(Console.ReadLine());

                int n = test.GetPrime(userInput);
                Console.WriteLine($"The number {userInput} prime is {n}.");

                Console.WriteLine("Do you want to find another prime number? y/n");
                string userContinue = Console.ReadLine();

                if (userContinue == "y" || userContinue == "Y")
                {
                    done = false;
                    continue;
                }
                if (userContinue == "n" || userContinue == "N")
                {
                    done = true;
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter y/n.");
                }
            }

        }
    }
}
