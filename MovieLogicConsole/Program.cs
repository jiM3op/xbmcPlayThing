using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;


namespace MovieLogicConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            List<xbmc_Movie> alleFilme = xbmc_Movie.GetAllMovies();

            List<xbmc_Movie> myMovies = xbmc_Movie.GetAllMovies();

            foreach (xbmc_Movie currentMovie in myMovies)
            {
                
                Console.Clear();
                Console.WriteLine("Total Movie Count is " + myMovies.Count.ToString());
                Console.WriteLine(currentMovie.Title + " " + currentMovie.URL);
                Console.WriteLine("Press any Key for next Movie...");
            

                Console.ReadKey();
                



            }

            Console.ReadKey();

            
        }
    }
}
