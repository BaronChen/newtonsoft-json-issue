using System;
using ConsoleApp1.classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new JsonSerializer();

            serializer.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var testString = @"{
                ""derivedObjectWithArray"": {
                    items: [
                    {
                        text: ""test 1""
                    },
                    {
                        text: ""test 2""
                    }
                    ]
                },
    
                ""objectWithArray"": {
                    items: [
                    {
                        text: ""test 1""
                    },
                    {
                        text: ""test 2""
                    }
                    ]
                }
            }";

            var jObject = JObject.Parse(testString);

            // items array in obj will have 4 items
            var obj = jObject.ToObject<DerivedObject>(serializer);
            
            Console.WriteLine(JsonConvert.SerializeObject(obj));            

        }
    }
}