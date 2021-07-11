using System;

namespace ChessGameDDD.Domain.Domain.Entities
{
    public class BoardLocation
    {
        public char Rank { get; set; }
        public char File { get; set; }

        private BoardLocation()
        {
        }

        public static BoardLocation Create(string locationString)
        {
            return new BoardLocation
            {
                Rank = locationString[0],
                File = locationString[1]
            };
        }
    }
}