using Xunit;

namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianTestCase
    {
        [Fact]
        public void FullName_Always_ShouldReturnConcatenationOfNames()
        {
            // Arrange
            const string firstName = "foo";
            const string lastName = "bar";
            var sut = new Musician(firstName, lastName);

            // Assert
            const string expected = "foo bar";
            Assert.Equal(expected, sut.FullName);
        }
    }
}