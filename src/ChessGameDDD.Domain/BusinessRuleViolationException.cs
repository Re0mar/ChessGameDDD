using System;

namespace ChessGameDDD
{
    internal class BusinessRuleViolationException : Exception
    {
        public BusinessRuleViolationException(string message)
            : base(message)
        {
        }
    }
}