using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace CL_Project
{
    public static class MovieUtility
    {
        public static MovieInfo GetMovieInfo(string movieName)
        {
            MovieInfo movieInfo = new MovieInfo();

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.themoviedb.org/3/search/movie?api_key=d6bfcd253942f1907271911a59cbbe44&query=" + WebUtility.UrlEncode(movieName));
            var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                string body = response.Content.ReadAsStringAsync().Result;
                var movieResults = JsonSerializer.Deserialize<MovieResults>(body);

                movieInfo = movieResults.results.FirstOrDefault();
            }

            return movieInfo;
        }
    }
}
