using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace CL_Project
{
    public class MovieInfo
    {
        //API Key: d6bfcd253942f1907271911a59cbbe44
        //API Request URL: https://api.themoviedb.org/3/movie/550?api_key=d6bfcd253942f1907271911a59cbbe44

        public class MovieInfoResult
        {
            public string Tagline { get; set; }
            public string Overview { get; set; }
            public string Original_language { get; set; }
        }

        public MovieInfoResult[] Results { get; set; }
    }

    public class GetMovieInfo
        {
        public static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.themoviedb.org/3/movie/550?api_key=d6bfcd253942f1907271911a59cbbe44&query=" + WebUtility.UrlEncode(movieName));
            var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                string body = response.Content.ReadAsStringAsync().Result;
                MovieInfo movieInfo = JsonSerializer.Deserialize<MovieInfo>(body);

                if (movieInfo != null && movieInfo.Results != null && movieInfo.Results.Length > 0)
                {
                    Console.WriteLine("Best Match:");
                    Console.WriteLine($"\t{ movieInfo.Results[0].Tagline}");
                    Console.WriteLine($"\t{ movieInfo.Results[0].Overview}");
                    Console.WriteLine($"\t{ movieInfo.Results[0].Original_language}");
                }

                else
                {
                    Console.WriteLine("No Match Found!");
                }
            }
        }
    }  
}
