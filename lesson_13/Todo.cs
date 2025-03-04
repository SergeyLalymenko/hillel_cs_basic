namespace lesson_13
{
    class Todo
    {
        private readonly string _text;
        private readonly int _id;
        private bool _isDone = false;

        public Todo(string text, int id)
        {
            _text = text;
            _id = id;
        }

        public string Text
        {
            get { return _text; }
        }

        public int Id
        {
            get { return _id; }
        }

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
    }
}
