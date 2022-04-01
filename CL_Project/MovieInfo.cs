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
        //https://api.themoviedb.org/3/search/movie?api_key={api_key}&query=Jack+Reacher

        public string title { get; set; }
        public string release_date { get; set; }
        public string overview { get; set; }
    }
}
