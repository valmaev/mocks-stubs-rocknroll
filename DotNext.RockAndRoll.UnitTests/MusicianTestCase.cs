using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianTestCase
    {
        [Theory, AutoData]
        public void FullName_Always_ShouldReturnConcatenationOfNames(
            Musician sut)
        {
            Assert.Equal(sut.FirstName + " " + sut.LastName, sut.FullName);
        }

        [Theory, AutoMockData]
        public void BreakInstrument_Always_ShouldSetStatusToBroken(
            Musician sut)
        {
            sut.BreakInstrument();
            Assert.Equal(InstrumentStatus.Broken, sut.Instrument.Status);
        }
    }
}