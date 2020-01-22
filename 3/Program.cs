using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _3 {
    class Program {
        public static async Task Main (string[] args) {
            HttpClient client = new HttpClient ();
            HttpRequestMessage reqPost = new HttpRequestMessage (HttpMethod.Get, "https://jsonplaceholder.typicode.com/posts");
            HttpResponseMessage resPost = await client.SendAsync (reqPost);
            var getJsonPost = await resPost.Content.ReadAsStringAsync ();

            HttpRequestMessage reqUser = new HttpRequestMessage (HttpMethod.Get, "https://jsonplaceholder.typicode.com/users");
            HttpResponseMessage resUser = await client.SendAsync (reqUser);
            var getJsonUser = await resUser.Content.ReadAsStringAsync ();

            var result = JsonConvert.SerializeObject(new {UserDetails = getJsonPost, AccountDetails = getJsonUser});

            Console.WriteLine(result);
        }


    }
}