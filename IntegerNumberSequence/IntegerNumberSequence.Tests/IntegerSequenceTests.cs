using NUnit.Framework;

namespace IntegerNumberSequence.Tests
{
    /*
    Code Kata to process an integer sequence to determine the following statistics:

    Minimum Value
    Maximum Value
    Average Value
    E.g. For a integer sequence "6, 9, 15, -2, 92, 11" we have the following answers:

    Minimum Value: -2
    Maximum Value: 92
    Average Value: 21.83
    */
    public class IntegerSequenceTests
    {
        private int[] _numbers = {6, 9, 15, -2, 92, 11};
        
        [Test]
        public void Should_Return_Minium_Value()
        {
            var integerSequence = new IntegerSequence(_numbers);

            integerSequence.FindExtremaValues();
            var foundMiniumValue = integerSequence.Min;

            Assert.That(foundMiniumValue, Is.EqualTo(-2));
        }

        [Test]
        public void Should_When_Finding_Minium_Value_If_Array_Is_Empty_Min_Value_Minus_One()
        {
            _numbers = new int[] { };

            var integerSequence = new IntegerSequence(_numbers);
            integerSequence.FindExtremaValues();
            var foundMiniumValue = integerSequence.Min;

            Assert.That(foundMiniumValue, Is.EqualTo(-1));
        }

        [Test]
        public void Should_When_Finding_Minium_Value_If_Array_Is_Null_Return_Minus_One()
        {
            _numbers = null;
            var integerSequence = new IntegerSequence(_numbers);

            integerSequence.FindExtremaValues();
            var foundMiniumValue = integerSequence.Min;

            Assert.That(foundMiniumValue, Is.EqualTo(-1));
        }

        [Test]
        public void Should_Return_Maxium_Value()
        {
            var integerSequence = new IntegerSequence(_numbers);

            integerSequence.FindExtremaValues();
            var foundMaximumValue = integerSequence.Max;

            Assert.That(foundMaximumValue, Is.EqualTo(92));
        }

        [Test]
        public void Should_When_Finding_Maximum_Value_If_Array_Is_Empty_Return_Minus_One()
        {
            _numbers = new int[] { };
            var integerSequence = new IntegerSequence(_numbers);

            integerSequence.FindExtremaValues();
            var foundMaximumValue = integerSequence.Max;

            Assert.That(foundMaximumValue, Is.EqualTo(-1));
        }

        [Test]
        public void Should_When_Finding_Maximum_Value_If_Array_Is_Null_Return_Minus_One()
        {
            _numbers = null;
            var integerSequence = new IntegerSequence(_numbers);

            integerSequence.FindExtremaValues();
            var foundMaximumValue = integerSequence.Max;

            Assert.That(foundMaximumValue, Is.EqualTo(-1));
        }

        [Test]
        public void Should_Return_The_Average_Value()
        {
            var integerSequence = new IntegerSequence(_numbers);

            var foundAverageValue = integerSequence.FindAverageValue();

            Assert.That(foundAverageValue, Is.EqualTo(21.83));
        }

        [Test]
        public void Should_When_Finding_Average_Value_If_Array_Is_Empty_Return_Minus_One()
        {
            _numbers = new int[] { };

            var integerSequence = new IntegerSequence(_numbers);
            var foundAverageValue = integerSequence.FindAverageValue();

            Assert.That(foundAverageValue, Is.EqualTo(-1));
        }

        [Test]
        public void Should_When_Finding_Average_Value_If_Array_Is_Null_Return_Minus_One()
        {
            _numbers = null;

            var integerSequence = new IntegerSequence(_numbers);
            var foundAverageValue = integerSequence.FindAverageValue();

            Assert.That(foundAverageValue, Is.EqualTo(-1));
        }
    }
}
