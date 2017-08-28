namespace Iterator.Iterator
{
    public class LAPaperIterator : IIterator
    {
        private string[] _reporters;
        private int _current;

        public LAPaperIterator(string[] _reporters)
        {
            this._reporters = _reporters;
            _current = 0;
        }

        public string CurrentItem()
        {
            return _reporters[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool isDone()
        {
            return _current >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_current++];
        }
    }
}
