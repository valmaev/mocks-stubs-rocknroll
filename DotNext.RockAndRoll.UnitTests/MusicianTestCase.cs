using Xunit;
using Xunit.Extensions;

namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianTestCase
    {
        [Theory]
        [InlineData("foo", "bar", "foo bar")]
        [InlineData("bar", "baz", "bar baz")]
        [InlineData("baz", "qux", "baz qux")]
        public void FullName_Always_ShouldReturnConcatenationOfNames(
            string firstName,
            string lastName,
            string expected)
        {
            var sut = new Musician(firstName, lastName);
            Assert.Equal(expected, sut.FullName);
        }
    }
}