using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace QueringForArticles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Write a console application, which searches for news articles
                    by given a query string and a count of articles to retrieve.
		
                    The application should ask the user for input and print the
                    Titles and URLs of the articles.
                    For news articles search use the Feedzilla API and use
                    one of WebClient, HttpWebRequest or HttpClient
            */

            var httpClient = new HttpClient();
            string baseUrl = "http://api.feedzilla.com/";            

            // Input
            Console.Write("Name of the searched article: ");
            string searchQuery = Console.ReadLine();

            Console.Write("Nubmer of articles you to retrive: ");
            int count = int.Parse(Console.ReadLine());

            // service url and search query
            string serviceUrl = string.Format("v1/articles/search.json?q={0}&count={1}", searchQuery, count);          
            
            // Responce of the server
            var result = Get<RootObject>(baseUrl, httpClient, serviceUrl);

            // Output
            foreach (var article in result.articles)
            {
                Console.WriteLine("Article: {0}, \nURL: {1}",article.title, article.url);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        
        public static T Get<T>(string baseUrl, HttpClient httpClient, string serviceUrl, string mediaType = "application/json")
        {
            var request = new HttpRequestMessage();

            request.RequestUri = new Uri(baseUrl + serviceUrl);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
            request.Method = HttpMethod.Get;

            var response = httpClient.SendAsync(request).Result;

            var returnObj = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(returnObj);
        }
    }
}
