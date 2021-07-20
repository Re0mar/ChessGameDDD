using ChessGameDDD.Domain.BusinessRules.PieceRules;
using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameDDD.UnitTests.Domain.PieceRules
{
    [TestClass]
    public class RookRulesTests
    {
        [TestMethod]
        public void DirectionIsAllowed_HorizontalRookMove_returnsTrue()
        {
            // Arrange
            var rookPiece = new Rook();
            var toLocation = BoardLocation.Create("a1");
            var fromLocation = BoardLocation.Create("b1");

            var horizontalMove = Move.Create(fromLocation, toLocation);

            // Act
            RookRules.DirectionIsAllowed(rookPiece, horizontalMove);
        }

        [TestMethod]
        public void DirectionIsAllowed_VerticalRookMove_allowed()
        {
            // Arrange
            var rookPiece = new Rook();
            var fromLocation = BoardLocation.Create("a1");
            var toLocation = BoardLocation.Create("a2");
            var horizontalMove = Move.Create(fromLocation, toLocation);

            // Act
            RookRules.DirectionIsAllowed(rookPiece, horizontalMove);
        }

        [TestMethod]
        public void DirectionIsAllowed_DiagonalRookMove_BusinessRuleException()
        {
            // Arrange
            var rookPiece = new Rook();
            var fromLocation = BoardLocation.Create("a1");
            var toLocation = BoardLocation.Create("b2");
            var horizontalMove = Move.Create(fromLocation, toLocation);

            // Act
            var ex = Assert.ThrowsException<BusinessRuleViolationException>(() => RookRules.DirectionIsAllowed(rookPiece, horizontalMove));

            // Assert
            Assert.AreEqual("Move direction not allowed for rook", ex.Message);
        }
    }
}