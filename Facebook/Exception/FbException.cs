namespace Facebook.Exception
{
    public class FbException : System.Exception
    {
        public FbException(string message) : base(message)
        {}
    }
}