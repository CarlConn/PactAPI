using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;
using RestSharpTest.Model;
using System;
using System.Collections.Generic;

namespace RestSharpTest
{
    [TestClass]
    public class UnitTest1
    {
        private string baseURL = "https://reqres.in/api/";

        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient(baseURL);
            var request = new RestRequest("data/{id}", Method.GET);
            request.AddUrlSegment("id", 2);
            var response = client.Execute<Data>(request);
            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response);
            string name = response.Data.color;

        }
    }
}
