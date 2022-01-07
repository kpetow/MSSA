using System;

namespace CinemaChallenge.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public DateTime ShowTime { get; set; }
    }
}