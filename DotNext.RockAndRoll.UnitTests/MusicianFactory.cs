namespace DotNext.RockAndRoll.UnitTests
{
    public static class MusicianFactory
    {
        public static Musician Create(
            string firstName = null,
            string lastName = null)
        {
            return new Musician(
                firstName ?? "foo",
                lastName ?? "bar");
        }
    }
}