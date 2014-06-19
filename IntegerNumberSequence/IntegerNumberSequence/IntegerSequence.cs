using System;

namespace IntegerNumberSequence
{
    public class IntegerSequence
    {
        private readonly int[] _numbers;

        public IntegerSequence(int[] numbers)
        {
            this._numbers = numbers;
            this.Max = -1;
            this.Min = -1;
        }

        public int Max { get; set; }
        public int Min { get; set; }

        public void FindExtremaValues()
        {
            if (ArrayIsNotInitized()) return;
            
            Min = this._numbers[0];
            Max = this._numbers[0];

            for (var index = 0; index <= this._numbers.Length - 1; index++)
            {
                var currentElementValue = this._numbers[index];
                if (Min >= currentElementValue)
                {
                    Min = currentElementValue;
                }

                if (Max <= currentElementValue)
                {
                    Max = currentElementValue;
                }
            }
        }

        private bool ArrayIsNotInitized()
        {
            return this._numbers == null || this._numbers.Length == 0;
        }

        public double FindAverageValue()
        {
            if (ArrayIsNotInitized()) return -1;
            
            double total = 0;
            double arrayLegnth = this._numbers.Length;
            
            for (var index = 0; index <= arrayLegnth - 1; index++)
            {
                total += this._numbers[index];
            }

            return Math.Truncate((total / arrayLegnth) * 100) / 100;
        }
    }
}