using ChessGameDDD.Domain.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameDDD.UnitTests.Domain
{
    [TestClass]
    public class BoardLocationTests
    {
        [TestMethod]
        public void Create_ValidRankLocation_NoException()
        {
            // Act
            BoardLocation.Create("a1");
            BoardLocation.Create("a2");
            BoardLocation.Create("a3");
            BoardLocation.Create("a4");
            BoardLocation.Create("a5");
            BoardLocation.Create("a6");
            BoardLocation.Create("a7");
            BoardLocation.Create("a8");
        }

        [TestMethod]
        public void Create_ValidFileLocation_NoException()
        {
            // Act
            BoardLocation.Create("a1");
            BoardLocation.Create("b1");
            BoardLocation.Create("c1");
            BoardLocation.Create("d1");
            BoardLocation.Create("e1");
            BoardLocation.Create("f1");
            BoardLocation.Create("g1");
            BoardLocation.Create("h1");
        }

        [TestMethod]
        public void Create_ValidBoardLocation_RankAndFileAreSplittedCorrectly()
        {
            // Act
            var sut = BoardLocation.Create("a1");
            // Assert
            Assert.AreEqual(sut.File, 'a');
            Assert.AreEqual(sut.Rank, '1');
        }

        [TestMethod]
        public void Create_InvalidBoardRank_BusinessRuleViolationException()
        {
            // Act
            var ex = Assert.ThrowsException<BusinessRuleViolationException>(() => BoardLocation.Create("a9"));
            // Assert
            Assert.AreEqual("Boardlocation is invalid", ex.Message);
        }

        [TestMethod]
        public void Create_InvalidBoardFile_BusinessRuleViolationException()
        {
            // Act
            var ex = Assert.ThrowsException<BusinessRuleViolationException>(() => BoardLocation.Create("i1"));
            // Assert
            Assert.AreEqual("Boardlocation is invalid", ex.Message);
        }
    }
}