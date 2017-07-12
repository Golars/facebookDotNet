namespace Facebook.Entity
{
    public class Token
    {
        private readonly string _token;

        public Token(string token) {
            _token = token;
        }

        public string GetValue()
        {
            return _token;
        }
    }
}