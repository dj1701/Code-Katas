using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    internal class Calculate
    {
        public int Add(params string[] stringNumbers)
        {
            var ints = new List<int>();
            const string seperatorPattern = "(\n)|(;)|(,)";
            const string invalidPattern = @"(\W\W)|_";

            if (Regex.IsMatch(stringNumbers[0], invalidPattern)) throw new InvalidStringNumberInput("Invalid input: " + stringNumbers[0]);

            foreach (var result in Regex.Split(stringNumbers[0].ToString(CultureInfo.InvariantCulture), pattern: seperatorPattern))
            {
                var newConvertedNumber = 0;
                int.TryParse(result, out newConvertedNumber);
                ints.Add(newConvertedNumber);
            }

            return (ints.Count > 0) ? ints.Sum() : 0;
        }
    }
}
