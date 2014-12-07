using Ploeh.AutoFixture;
using Xunit;

namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianTestCase
    {
        [Fact]
        public void FullName_Always_ShouldReturnConcatenationOfNames()
        {
            var fixture = new Fixture();
            var firstName = fixture.Create<string>();
            var lastName = fixture.Create<string>();
            var sut = new Musician(firstName, lastName);

            Assert.Equal(firstName + " " + lastName, sut.FullName);
        }
    }
}