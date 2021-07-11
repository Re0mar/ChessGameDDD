using ChessGameDDD.Domain.Core;
using ChessGameDDD.Events;
using System.Collections.Generic;

namespace ChessGameDDD.Domain.Entities
{
    public class Move
        : ValueObject
    {
        public string Rank { get; set; }
        public int File { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Rank;
            yield return File;
        }

        internal Event MapToMoveMade()
        {
            return new MoveMadeEvent();
        }
    }
}