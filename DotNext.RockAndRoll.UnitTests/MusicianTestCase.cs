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
            var sut = fixture.Create<Musician>();

            Assert.Equal(sut.FirstName + " " + sut.LastName, sut.FullName);
        }
    }
}