using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Kata.PrimeFactor.Tests
{
    public interface IPrimeFactors
    {
        //List<int> Generate(int given);
        List<int> GeneratePrime(int given);
    }
    
    public class PrimeFactors : IPrimeFactors   
    {
        public List<int> Generate(int given)
        {
            if (given == 1)
            {
                throw new ArgumentException("1 cannot by factored");
            }

            var divider = 2;
            var primeFactor = given;

            var primeFactors = FindPrimeFactors(ref primeFactor, divider);
            divider+=1;
            primeFactors.AddRange(FindPrimeFactors(ref primeFactor, divider));

            if (primeFactors.Count == 0)
            {
                //Its a prime number
                primeFactors.Add(given);
            }

            primeFactors.Sort();
            return primeFactors;
        }

        private List<int> FindPrimeFactors(ref int primeFactor, int divider)
        {
            var primeFactors = new List<int>();

            while (primeFactor%divider == 0)
            {
                primeFactor /= divider;
                if (primeFactor >= 1)
                {
                    primeFactors.Add(divider);
                }
            }
            return primeFactors;
        }


        public List<int> GeneratePrime(int givenNumer)
        {
            var primefactores = new List<int>();
            var primeFactor = givenNumer;
            var divisor = 2;
            while (CheckEven(primeFactor))
            {
             
                primeFactor = givenNumer / divisor;
                givenNumer = primeFactor;
               primefactores.Add(divisor);
            }
            divisor++;
            while (checkRemainderForOddNumbers(primeFactor))
            {
                primeFactor = givenNumer / divisor;
                givenNumer = primeFactor;
                primefactores.Add(divisor);
            }
            return primefactores;
        }

        private static bool CheckEven(int givenNumer)
        {
            return givenNumer%2 == 0;
        }

        private static bool checkRemainderForOddNumbers(int givenNumer)
        {
            return givenNumer % 3 == 0;
        }
    }
}