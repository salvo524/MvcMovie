using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace MvcMovie.Models{
    public class MovieGenreViewModel{

        public List<Movie> movies; // pass list of movie model
        public SelectList genres; //list of genre
        public string movieGenre { get; set; } //selected genre, this value will set for search
        
    }
}