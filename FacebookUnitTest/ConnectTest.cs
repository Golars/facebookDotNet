using System;
using Facebook;
using Facebook.Entity;
using Xunit;
using Xunit.Abstractions;

namespace FacebookUnitTest
{
    public class ConnectTest
    {
        private readonly ITestOutputHelper _output;

        public ConnectTest(ITestOutputHelper output)
        {
            this._output = output;
        }
        
        [Fact]
        public void GetUserByTokenAsync()
        {
            var Config = new Config();
            var Connect = new Connect(Config);

            var Token = new Token("EAAEz2eMHkdQBAAszTQUMJhz1kHzz059KEexP0MssGgNs6jZAwpvTWlEBqvLdM4jXr37jlDjDBdaghX7KJ83g6GMZAgqqerrgih3LF7X756Q7bzgyXYkEK6TfzZAwR3Ja09gH4ccAcEZC00vRORl8ZBoDFTl7zla8ZD");
            var userTask = Connect.GetUserByTokenAsync(Token);
            userTask.Wait();
            
            _output.WriteLine(userTask.Result.Id);
            _output.WriteLine(userTask.Result.Name);
            _output.WriteLine(userTask.Result.Email);
            _output.WriteLine(userTask.Result.Cover);
            _output.WriteLine(userTask.Result.ToString());
        }
    }
}