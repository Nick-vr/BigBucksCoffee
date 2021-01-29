namespace BigBucksCoffee
{
    internal class Settings
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Settings(string title)
        {
            Title = title;
        }
    }
}