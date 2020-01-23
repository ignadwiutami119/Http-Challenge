using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ScrapySharp;

namespace _4 {
    class Program {
        public static async Task Main (string[] args) {
            HttpClient client = new HttpClient ();
            HttpRequestMessage request = new HttpRequestMessage (HttpMethod.Get, "https://api.themoviedb.org/3/movie/550?api_key=a4c56a26e242d6de8f754831da132e90");
            HttpResponseMessage response = await client.SendAsync (request);
            Console.WriteLine (await response.Content.ReadAsStringAsync ());
        }
    }
}