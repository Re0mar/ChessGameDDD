using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameDDD.UnitTests.Domain
{
    [TestClass]
    public class MoveTests
    {
        [TestMethod]
        public void Create_TwoLocationsDiffer_allowed()
        {
            // Arrage
            var fromLocation = BoardLocation.Create("a1");
            var toLocation = BoardLocation.Create("a2");

            // Act
            Move.Create(fromLocation, toLocation);
        }

        [TestMethod]
        public void Create_TwoLocationsAreTheSame_BusinessRuleViolationException()
        {
            // Arrage
            var fromLocation = BoardLocation.Create("a1");
            var toLocation = BoardLocation.Create("a1");

            // Assert
            var ex = Assert.ThrowsException<BusinessRuleViolationException>(() => Move.Create(fromLocation, toLocation));
            Assert.AreEqual("Move is invalid because to and from are the same", ex.Message);
        }
    }
}