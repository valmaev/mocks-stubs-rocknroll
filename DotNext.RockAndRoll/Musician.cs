namespace DotNext.RockAndRoll
{
    public class Musician
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Musician(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }
    }
}