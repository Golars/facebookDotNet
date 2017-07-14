using System;
using Facebook.Entity;
using Newtonsoft.Json;

namespace Facebook.Decoder
{
    public class UserDecoder
    {
        public User FbUser { get; }

        public  UserDecoder(String jsonString)
        {
            FbUser = (User) JsonConvert.DeserializeObject(jsonString, typeof(User));
        }
    }
    
}