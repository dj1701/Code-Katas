using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Kata.PrimeFactor.Tests
{
    [TestFixture]
    public class PrimeFactorTests
    {
        [Test]
        public void Given_a_value_of_1_expect_argument_exception_with_error_message()
        {
            var primeFactors = new PrimeFactors();
            const string expectedExceptionMessage = "1 cannot by factored";

            var argumentException = Assert.Throws<ArgumentException>(() => primeFactors.Generate(1));
            Assert.That(argumentException.Message, Is.EqualTo(expectedExceptionMessage));
        }

        [Test]
        public void Given_a_value_of_2_expect_prime_factor_2()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(2);
            var expected = new List<int> {2};

            Assert.That(listOfPrimeFactors,Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_3_expect_prime_factor_3()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(3);
            var expected = new List<int> { 3 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_4_expect_prime_factors_2x2()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(4);
            var expected = new List<int> {2,2};

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_5_expect_prime_factor_5()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(5);
            var expected = new List<int> { 5 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_6_expect_prime_factors_2x3()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(6);
            var expected = new List<int> { 2, 3 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_7_expect_prime_factor_7()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(7);
            var expected = new List<int> { 7 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_8_expect_prime_factors_2x2x2()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(8);
            var expected = new List<int> { 2,2,2 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_9_expect_prime_factors_3x3()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(9);
            var expected = new List<int> { 3,3 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }


        [Test]
        public void Given_a_value_of_73_expect_prime_number_73()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(73);
            var expected = new List<int> { 73 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_72_expect_prime_factors_2x2x2x3x3()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(72);
            var expected = new List<int> { 2,2,2,3,3 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_7919_expect_prime_number_7919()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(7919);
            var expected = new List<int> { 7919 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }

        [Test]
        public void Given_a_value_of_7919_expect_prime_factors_2x2x2x2x3x3x5x5()
        {
            var primeFactors = new PrimeFactors();

            var listOfPrimeFactors = primeFactors.Generate(7920);
            var expected = new List<int> { 2,2,2,2,3,3,5 };

            Assert.That(listOfPrimeFactors, Is.EqualTo(expected));
        }
    }
}
