namespace DotNext.RockAndRoll
{
    public class Guitar
    {
        private readonly string _modelName;
        private readonly int _stringsCount;

        public Guitar(string modelName, int stringsCount)
        {
            _modelName = modelName;
            _stringsCount = stringsCount;
        }

        public string ModelName
        {
            get { return _modelName; }
        }

        public int StringsCount
        {
            get { return _stringsCount; }
        }
    }
}