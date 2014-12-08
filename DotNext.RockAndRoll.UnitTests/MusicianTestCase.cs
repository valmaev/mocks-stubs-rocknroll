using Xunit;
using Xunit.Extensions;

namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianTestCase
    {
        [Theory, AutoMockData]
        public void FullName_Always_ShouldReturnConcatenationOfNames(
            Musician sut)
        {
            Assert.Equal(sut.FirstName + " " + sut.LastName, sut.FullName);
        }

        [Theory, ReadyToRockInstrument]
        public void BreakInstrument_WithReadyToRockInstrument_ShouldBreakIt(
            Musician sut)
        {
            sut.BreakInstrument();
            Assert.Equal(InstrumentStatus.Broken, sut.Instrument.Status);
        }
    }
}