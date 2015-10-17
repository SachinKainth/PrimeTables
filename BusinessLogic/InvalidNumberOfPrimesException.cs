using System;

namespace BusinessLogic
{
    public class InvalidNumberOfPrimesException : Exception
    {
        public InvalidNumberOfPrimesException(string message) : base(message){}
    }
}