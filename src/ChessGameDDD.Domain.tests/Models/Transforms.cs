using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace ChessGameDDD.Domain.tests.Models
{
    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation]
        public BoardLocation TransformToBoardLocation(string locationString)
        {
            return BoardLocation.Create(locationString);
        }

        [StepArgumentTransformation]
        public IEnumerable<MoveToCheck> TranformToMovesToCheck(Table table)
        {
            var movesToCheck = new List<MoveToCheck>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                movesToCheck.AddRange(
                    GetMovesForRow(row));
            }

            return movesToCheck;
        }

        private List<MoveToCheck> GetMovesForRow(TableRow row)
        {
            var file = Convert.ToChar(row[0]);
            var movesForRow = new List<MoveToCheck>();

            movesForRow.Add(GetMove(row, 'a', file));
            movesForRow.Add(GetMove(row, 'b', file));
            movesForRow.Add(GetMove(row, 'c', file));
            movesForRow.Add(GetMove(row, 'd', file));
            movesForRow.Add(GetMove(row, 'e', file));
            movesForRow.Add(GetMove(row, 'f', file));
            movesForRow.Add(GetMove(row, 'g', file));
            movesForRow.Add(GetMove(row, 'h', file));

            return movesForRow;
        }

        private MoveToCheck GetMove(TableRow row, char rank, char file)
        {
            return new MoveToCheck
            {
                ToLocation = BoardLocation.Create(Convert.ToString(rank) + file),
                ShouldBePossible = row[Convert.ToString(rank)].Equals("x")
            };
        }
    }
}