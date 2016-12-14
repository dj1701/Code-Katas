using System;
using System.Collections.Generic;

namespace Kata.PrimeFactor.Tests
{
    public interface IPrimeFactors
    {
        List<int> Generate(int given);
    }
    
    public class PrimeFactors : IPrimeFactors   
    {
        public List<int> Generate(int given)
        {
            if (given == 1)
            {
                throw new ArgumentException("1 cannot by factored");
            }

            var primeFactors = FindPrimeFactors(given);

            if (primeFactors.Count == 0)
            {
                //Its a prime number
                primeFactors.Add(given);
            }

            primeFactors.Sort();
            return primeFactors;
        }

        private List<int> FindPrimeFactors(int value)
        {
            var primeFactors = new List<int>();

            for (var i = 2; i <= value; i++)
            {
                while ((value%i)==0)
                {
                    value /= i;
                    primeFactors.Add(i);
                }
            }

            return primeFactors;
        }
    }
}