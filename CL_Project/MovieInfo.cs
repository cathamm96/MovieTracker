using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CL_Project
{
    public class MovieInfo
    {
        //API Key: d6bfcd253942f1907271911a59cbbe44
        //API Request URL: https://api.themoviedb.org/3/movie/550?api_key=d6bfcd253942f1907271911a59cbbe44

        public class Summary
        {
            [JsonPropertyName("tagline")]
            public string Title { get; set; }
        }

        public class Info
        {
            [JsonPropertyName("results")]
            public IEnumerable<Summary> Summaries { get; set; }
        }

        public async Task<IEnumerable<Summary>> GetMovieInfo(string query)
        {
            List<Info> info = new List<Info>();

            var url = $"https://api.themoviedb.org/3/movie/550?api_key=d6bfcd253942f1907271911a59cbbe44";
            var parameters = $"?query"

            HttpClient Client = new();
            Client.BaseAddress = new Uri(url);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await Client.GetAsync(parameters).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
            }

        }
    }
}
