using System;

namespace StringCalculator
{
    public class InvalidStringNumberInput : Exception
    {
        private string _message;

        public InvalidStringNumberInput(string message) : base(message)
        {
            this._message = message;
        }
    }
}