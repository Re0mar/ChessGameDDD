using ChessGameDDD.Domain.Core;
using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Events;
using System;
using System.Collections.Generic;

namespace ChessGameDDD.Domain.Entities
{
    public class Move
        : ValueObject
    {
        public BoardLocation StartLocation { get; set; }
        public BoardLocation ToLocation { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return StartLocation;
            yield return ToLocation;
        }

        public override string ToString()
        {
            return StartLocation.ToString() + " -> " + ToLocation.ToString();
        }

        internal Event MapToMoveMade()
        {
            return new MoveMadeEvent();
        }
    }
}