using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit;

namespace DotNext.RockAndRoll.UnitTests
{
    public class AutoMockDataAttribute : AutoDataAttribute
    {
        public AutoMockDataAttribute() : base(
            new Fixture().Customize(
                new AutoNSubstituteCustomization())) {}
    }
}