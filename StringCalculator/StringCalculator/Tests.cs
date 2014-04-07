using NUnit.Framework;

namespace StringCalculator
{
    public class Tests
    {
        [Test]
        public void ShouldReturnZeroForEmptyStringInput()
        {
            var numbers = string.Empty;
            var calc = new Calculate();

            var actual = calc.Add(numbers);

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void ShouldReturnOneForNumeric1StringInput()
        {
            const string numbers = "1";
            var calc = new Calculate();

            var actual = calc.Add(numbers);

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ShouldReturnThreeForNumeric1And2StringInput()
        {
            const string numbers = "1,2";
            var calc = new Calculate();

            var actual = calc.Add(numbers);

            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void ShouldReturnSumOfNumbersWithNewLineAndCommSeparaters()
        {
            const string numbers = "1\n2,3";
            var calculate = new Calculate();

            var actual = calculate.Add(numbers);

            Assert.That(actual, Is.EqualTo(6));
        }

        [Test]
        public void ShouldNotAcceptInputWithSeparatersNotSeparatingNumbers()
        {
            const string numbers = "1,\n";
            var calculate = new Calculate();

            var ex = Assert.Throws<InvalidStringNumberInput>(() => calculate.Add(numbers));

            Assert.That(ex.Message, Is.EqualTo(string.Format("Invalid input: {0}", numbers)));
        }
    }
}
