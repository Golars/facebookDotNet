using System;
using Facebook;
using Xunit;

namespace FacebookUnitTest
{
    public class ConfigTest
    {
        [Fact]
        public void InitTest()
        {
            var Config = new Config("v5", "http://test/");
            Assert.Equal("http://test/v5", Config.GetUrl());
        }
    }
}