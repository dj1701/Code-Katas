using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Kata.PrimeFactor.Tests
{
    public interface IPrimeFactors
    {
        List<int> Generate(int given);
        //List<int> GeneratePrime(int given);
    }
    
    public class PrimeFactors : IPrimeFactors   
    {
        private readonly List<int> _primeFactors = new List<int>();
        
        public List<int> Generate(int given)
        {
            if (given == 1)
            {
                throw new ArgumentException("1 cannot by factored");
            }

            const int divider = 2;
            var primeFactor = given;

            FindPrimeFactors(primeFactor, divider);

            if (_primeFactors.Count == 0)
            {
                //Its a prime number
                _primeFactors.Add(given);
            }

            _primeFactors.Sort();
            return _primeFactors;
        }

        private List<int> FindPrimeFactors(int primeFactor, int divider)
        {
            while (primeFactor%divider == 0 && primeFactor > 0)
            {
                primeFactor /= divider;
                if (primeFactor >= 1)
                {
                    _primeFactors.Add(divider);
                }
            }
            divider+=1;
            if (primeFactor%divider == 0 && primeFactor > 0)
            {
                FindPrimeFactors(primeFactor, divider);
            }
            else
            {
                divider+=1;
                if (primeFactor%divider == 0 && primeFactor > 0)
                {
                    FindPrimeFactors(primeFactor, divider);
                }
            }
            return _primeFactors;
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