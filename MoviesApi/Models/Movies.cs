using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MoviesApi.Models
{
    public class Movies
    {
        public int id { get; set; }

        public String name {get; set;}

        public int rating { get; set; }

        public String description { get; set; }

        public DateTime releaseDate { get; set; }
    }
}