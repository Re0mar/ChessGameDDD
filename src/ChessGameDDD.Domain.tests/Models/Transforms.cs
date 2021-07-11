using ChessGameDDD.Domain.Domain.Entities;
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
    }
}