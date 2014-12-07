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
            var sut = new MusicianBuilder()
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .Build();
            Assert.Equal(firstName + " " + lastName, sut.FullName);
        }
    }
}