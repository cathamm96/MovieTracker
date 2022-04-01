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


        public static MovieInfo GetMovieInfo(string movieName)
        {
            MovieInfo movieInfo = null;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.themoviedb.org/3/movie/550?api_key=d6bfcd253942f1907271911a59cbbe44&query=" + WebUtility.UrlEncode(movieName));
            var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                string body = response.Content.ReadAsStringAsync().Result;
                JsonSerializer.Deserialize<MovieInfo>(body);
                movieInfo = JsonSerializer.Deserialize<MovieInfo>(body);
            }

            return movieInfo;

        }
    }
}
