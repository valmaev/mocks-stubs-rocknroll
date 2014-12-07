namespace DotNext.RockAndRoll.UnitTests
{
    public class MusicianBuilder
    {
        private string _firstName = "foo";
        private string _lastName = "bar";

        public MusicianBuilder WithFirstName(string value)
        {
            _firstName = value;
            return this;
        }

        public MusicianBuilder WithLastName(string value)
        {
            _lastName = value;
            return this;
        }

        public Musician Build()
        {
            return new Musician(_firstName, _lastName);
        }
    }
}