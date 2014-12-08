using System;

namespace DotNext.RockAndRoll
{
    public class Musician
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private IInstrument _instrument;

        public Musician(string firstName, string lastName)
        {
            if (firstName == null)
                throw new ArgumentNullException("firstName");
            if (lastName == null)
                throw new ArgumentNullException("lastName");

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

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public IInstrument Instrument
        {
            get { return _instrument; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _instrument = value;
            }
        }

        public void BreakInstrument()
        {
            if (Instrument.Status == InstrumentStatus.Broken)
                throw new InvalidOperationException(
                    "Hey, I can't break already broken instrument!");

            Instrument.Status = InstrumentStatus.Broken;
        }
    }
}