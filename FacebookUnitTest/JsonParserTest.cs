using System;
using Newtonsoft.Json.Schema;
using Xunit;

namespace FacebookUnitTest
{
    public class JsonParserTest
    {
        [Fact]
        public void ParseJsonTest()
        {
            string schemaJson = @"{
              'description': 'A person',
              'type': 'object',
              'properties': {
                'name': {'type':'string'},
                'hobbies': {
                  'type': 'array',
                 'items': {'type':'string'}
               }
              }
            }";

            JsonSchema schema = JsonSchema.Parse(schemaJson);
            Console.WriteLine(schema);
    
            foreach (var property in schema.Properties)
            {
                Console.WriteLine(property.Key + " - " + property.Value.Type);
            }  
                       
            Console.WriteLine("Json Parse!");
            Assert.False(false);
        }
    }
}