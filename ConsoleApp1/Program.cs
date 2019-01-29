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
                ""objectWithArray"": {
                    items: [
                    {
                        text: ""test 1""
                    },
                    {
                        text: ""test 2""
                    }
                    ]
                },
    
                ""objectWithArray2"": {
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

            // items array in obj will have 4 items as [{"Text":"test 1"},{"Text":"test 2"},{"Text":"test 1"},{"Text":"test 2"}]
            var obj = jObject.ToObject<RootObject>(serializer);
            
            Console.WriteLine(JsonConvert.SerializeObject(obj));            

        }
    }
}