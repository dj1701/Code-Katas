using System;

namespace NasaCountDown
{
    public interface INasaCountdown
    {
        /// <summary>
        /// Issue the NASA countdown
        /// </summary>
        /// <param name="start">number to start with</param>
        /// <returns>array with numbers from 'start' to 0</returns>
        int[] Countdown(int start);
    }
    
    public class NasaCountdown : INasaCountdown
    {
        public int[] Countdown(int start)
        {
            if (start == -1) return new int[] {};
            
            var arraySize = start+1;
            var countDown = new int[arraySize];
            
            for(var index=0; index<=start; index++)
            {
                countDown[index] = index;
            }

            return countDown;
        }
    }
}
