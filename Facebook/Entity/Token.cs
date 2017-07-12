namespace Facebook.Entity
{
    public class Token
    {
        private readonly string _token;

        public Token(string token) {
            this._token = token;
        }

        public string GetValue()
        {
            return this._token;
        }
    }
}