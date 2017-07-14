using System;
using System.Net.Http;
using System.Threading.Tasks;
using Facebook.Decoder;
using Facebook.Entity;

namespace Facebook
{
    public class Connect
    {
        
        private Config Config { get; }

        public Connect(Config config)
        {
            this.Config = config;
        }

        public async Task<User> GetUserByTokenAsync(Token token)
        {
            Console.Write("ASSINC START");
            var client = new HttpClient();
            client.BaseAddress = new Uri(Config.GetUrl());
            var facebookTask = client.GetAsync(this.PrepareUrl("me", "id,name,email,picture.width(720).height(720)", token));
            Console.WriteLine(client.BaseAddress.ToString());
            
            var msg = await facebookTask;
            var json = await msg.Content.ReadAsStreamAsync();
            UserDecoder userDecoder = new UserDecoder(json);
            Console.Write(msg.Content);
            Console.Write("ASSINC");
            
            return userDecoder.FbUser;

        }

        private string PrepareUrl(string path, string queryParams, Token token)
        {
            return path + "?access_token=" + token.GetValue() + "&fields=" + queryParams;
        }
    }
}