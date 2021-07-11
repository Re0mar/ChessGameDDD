using System;

namespace ChessGameDDD
{
    public class BusinessRuleViolationException : Exception
    {
        public BusinessRuleViolationException(string message)
            : base(message)
        {
        }
    }
}