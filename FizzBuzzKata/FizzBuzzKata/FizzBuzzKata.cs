using System;

namespace FizzBuzzKata
{
    public interface IFizzBuzzKata
    {
        /// <summary>
        /// Give an answer to the current game
        /// </summary>
        /// <param name="number">current number in the game sequence</param>
        /// <returns>appropriate answer to the current number</returns>
        string Answer(int number);
    }
    
    public class FizzBuzzKata : IFizzBuzzKata
    {
        public string Answer(int i)
        {
            return ((i%3) == 0 && (i%5) == 0) ? "fizzbuzz" : (i%3) == 0 ? "fizz" : (i%5) == 0 ? "buzz" : "";
        }
    }
}
