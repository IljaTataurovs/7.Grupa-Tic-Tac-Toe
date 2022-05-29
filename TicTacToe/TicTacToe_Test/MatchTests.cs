using Xunit;

namespace TicTacToe.Tests
{
    public class MatchTests
    {
        [Fact]
        public void ChangePlayer_WhenX_ThenO()
        {
            Match p1 = new Match();
            char ret = p1.ChangePlayer('X');
            Assert.Equal('O', ret);
        }
    }
}