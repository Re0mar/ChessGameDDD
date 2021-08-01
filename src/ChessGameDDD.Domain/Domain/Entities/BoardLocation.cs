using ChessGameDDD.Domain.Core;
using System.Collections.Generic;
using System.Linq;

namespace ChessGameDDD.Domain.Domain.Entities
{
    public class BoardLocation : ValueObject
    {
        private static readonly char[] allowedRanks = { '1', '2', '3', '4', '5', '6', '7', '8' };
        private static readonly char[] allowedFiles = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        public char Rank { get; set; }
        public char File { get; set; }

        private BoardLocation()
        {
        }

        public static BoardLocation Create(string locationString)
        {
            var file = locationString[0];
            var rank = locationString[1];
            if (!allowedRanks.Contains(rank) ||
                !allowedFiles.Contains(file))
            {
                throw new BusinessRuleViolationException("Boardlocation is invalid");
            }

            return new BoardLocation
            {
                Rank = locationString[1],
                File = locationString[0]
            };
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return allowedFiles;
            yield return allowedRanks;
        }

        public override string ToString()
        {
            return "" + File + Rank;
        }
    }
}