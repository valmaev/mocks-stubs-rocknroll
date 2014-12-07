using Xunit;
using Xunit.Extensions;

namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianTestCase
    {
        [Theory]
        [InlineData("foo", "bar")]
        [InlineData("bar", "baz")]
        [InlineData("baz", "qux")]
        public void FullName_Always_ShouldReturnConcatenationOfNames(
            string firstName,
            string lastName)
        {
            var sut = MusicianFactory.Create(firstName, lastName);
            Assert.Equal(firstName + " " + lastName, sut.FullName);
        }
    }
}