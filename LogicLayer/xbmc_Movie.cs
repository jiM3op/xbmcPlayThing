using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DSXBMCPlaythingTableAdapters;


namespace LogicLayer
{
    public class xbmc_Movie : xbmc_media
    {

        public string FilePath;
        public string IMDBid;

        public static List<xbmc_Movie> GetAllMovies()
        {
            movieviewTableAdapter taMovies = new movieviewTableAdapter();
            var dtMovies = taMovies.GetAllMovies();
            List<xbmc_Movie> allMovies = new List<xbmc_Movie>();
            foreach (DSXBMCPlaything.movieviewRow movie in dtMovies.Rows)
            {

                xbmc_Movie currentMovie = new xbmc_Movie();
                currentMovie.Title = movie.c00;
                currentMovie.Description = movie.c01;
                currentMovie.Rating = Convert.ToDouble(movie.c05)/1000000;
                currentMovie.FilePath = movie.c22;
                currentMovie.IMDBid = movie.c09;
                currentMovie.URL = @"http://www.imdb.com/title/" + currentMovie.IMDBid;
                allMovies.Add(currentMovie);

            }

            return allMovies;
        }   

    }
}
