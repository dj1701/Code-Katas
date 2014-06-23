using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    /*
    Any number divisible by three is replaced by the word fizz and any divisible by five by the word buzz. 
    Numbers divisible by both become fizzbuzz. 
    */

    [TestFixture]
    public class given_a_number
    {
        [TestCase(9,"fizz")]
        [TestCase(6,"fizz")]
        [TestCase(21,"fizz")]
        [TestCase(51, "fizz")]
        [TestCase(57,"fizz")]
        public void Should_be_able_to_divid_by_there_return_fizz(int number, string expectedResult)
        {
            IFizzBuzzKata fizzBuzz = new FizzBuzzKata();

            var actualAnswer = fizzBuzz.Answer(number);

            Assert.That(actualAnswer, Is.EqualTo(expectedResult));
        }

        [TestCase(25,"buzz")]
        [TestCase(50,"buzz")]
        [TestCase(20,"buzz")]
        [TestCase(100,"buzz")]
        [TestCase(125,"buzz")]
        public void Should_be_able_divid_by_five_return_buzz(int number, string expectedResult)
        {
            IFizzBuzzKata fizzBuzz = new FizzBuzzKata();

            var actualAnswer = fizzBuzz.Answer(number);

            Assert.That(actualAnswer, Is.EqualTo(expectedResult));
        }

        [TestCase(8, "")]
        [TestCase(49, "")]
        [TestCase(56, "")]
        [TestCase(23, "")]
        [TestCase(256, "")]
        public void Should_If_not_divisible_by_either_three_or_five_Return_Empty_String(int number, string expectedResult)
        {
            IFizzBuzzKata fizzBuzz = new FizzBuzzKata();

            var actualAnswer = fizzBuzz.Answer(number);

            Assert.That(actualAnswer, Is.EqualTo(expectedResult));
        }

        [TestCase(120, "fizzbuzz")]
        [TestCase(150, "fizzbuzz")]
        [TestCase(195, "fizzbuzz")]
        [TestCase(180, "fizzbuzz")]
        [TestCase(225, "fizzbuzz")]
        public void Should_be_able_divid_by_either_five_or_three_Return_fizzbuzz(int number, string expectedResult)
        {
            IFizzBuzzKata fizzBuzz = new FizzBuzzKata();

            var actualAnswer = fizzBuzz.Answer(number);

            Assert.That(actualAnswer, Is.EqualTo(expectedResult));
        }
    }
}
