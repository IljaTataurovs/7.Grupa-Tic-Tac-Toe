using Xunit;
namespace TicTacToeVers2.Tests
{
    public class DataTests
    {
        [Theory]
        [InlineData("a1", "a1")]
        [InlineData("1a", "a1")]
        [InlineData("b1", "b1")]
        [InlineData("1b", "b1")]
        [InlineData("1c", "c1")]
        [InlineData("c1", "c1")]
        [InlineData("a2", "a2")]
        [InlineData("2a", "a2")]
        [InlineData("b2", "b2")]
        [InlineData("2b", "b2")]
        [InlineData("2c", "c2")]
        [InlineData("c2", "c2")]
        [InlineData("a3", "a3")]
        [InlineData("3a", "a3")]
        [InlineData("b3", "b3")]
        [InlineData("3b", "b3")]
        [InlineData("3c", "c3")]
        [InlineData("c3", "c3")]

        public void CheckAndOrder_When_Then(string no, string uz)
        {
            string[] board64 = { "a", "b", "c", "d", "e", "f", "g", "h", "1", "2", "3", "4", "5", "6", "7", "8" };
            SpelesLogika spelesLogika = new SpelesLogika();
            string ret = spelesLogika.CheckAndOrder(no, board64);
            Assert.Equal(uz, ret);
        }
    }
}
