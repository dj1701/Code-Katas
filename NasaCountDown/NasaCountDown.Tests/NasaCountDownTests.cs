using NUnit.Framework;

namespace NasaCountDown.Tests
{
    [TestFixture]
    public class NasaCountDownTests
    {
        [Test]
        public void Should_Return_Array_Of_One_Element_With_Count_Down_From_Zero()
        {
            int[] expectedCountDown = {0};
            INasaCountdown countdown = new NasaCountdown();

            var result = countdown.Countdown(0);

            Assert.That(result,Is.EqualTo(expectedCountDown));
            Assert.That(result.Length, Is.EqualTo(1));
        }

        [Test]
        public void Should_Return_Array_Of_Two_Elements_With_Count_Down_From_1()
        {
            int[] expectedCountDown = {0, 1};
            var nasaCountdown = new NasaCountdown();

            var result = nasaCountdown.Countdown(1);

            Assert.That(result,Is.EqualTo(expectedCountDown));
            Assert.That(result.Length, Is.EqualTo(2));
        }

        [Test]
        public void Should_Return_Array_Of_11_Elements_With_Count_Down_From_11()
        {
            int[] expectedCountDown = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var nasaCountdown = new NasaCountdown();

            var result = nasaCountdown.Countdown(10);

            Assert.That(result, Is.EqualTo(expectedCountDown));
            Assert.That(result.Length, Is.EqualTo(11));
        }

        [Test]
        public void Should_Return_Array_Of_20_Elements_With_Count_Down_From_19()
        {
            int[] expectedCountDown = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13, 14, 15, 16, 17, 18, 19};
            var nasaCountdown = new NasaCountdown();

            var result = nasaCountdown.Countdown(19);

            Assert.That(result, Is.EqualTo(expectedCountDown));
            Assert.That(result.Length, Is.EqualTo(20));
        }

        [Test]
        public void Should_Return_Array_Of_0_Length_If_Array_Is_Empty()
        {
            int[] expectedCountDown = {};
            var nasaCountdown = new NasaCountdown();

            var result = nasaCountdown.Countdown(-1);

            Assert.That(result, Is.EqualTo(expectedCountDown));
            Assert.That(result.Length, Is.EqualTo(0));
        }
    }
}
