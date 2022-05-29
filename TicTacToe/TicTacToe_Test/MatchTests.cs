using Xunit;

namespace TicTacToe.Tests
{
    public class MatchTests
    {
        //[Fact]
        [Theory]
        [InlineData('X', 'O')]
        [InlineData('O', 'X')]
        public void ChangePlayer_WhenX_ThenO(char first, char second)
        {
            Match p1 = new Match();
            char ret = p1.ChangePlayer(first);
            Assert.Equal(second, ret);
        }
    }
}