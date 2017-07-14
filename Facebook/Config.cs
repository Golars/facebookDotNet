namespace Facebook
{
    public class Config
    {
        private readonly string _url;

        private readonly string _version;

        public Config(string version = "v2.9", string url = "https://graph.facebook.com/")
        {
            _url = url;
            _version = version;
        }

        public string GetUrl()
        {
            return _url + _version;
        }
    }
}