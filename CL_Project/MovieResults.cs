using System;
using System.Collections.Generic;

namespace CL_Project
{
    public class MovieResults
    {
        public int page { get; set; }
        public IEnumerable<MovieInfo> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}
