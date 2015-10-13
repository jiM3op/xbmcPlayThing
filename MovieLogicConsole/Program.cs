using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLogicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            xbmc_TVShow TheWalkingDead = new xbmc_TVShow();
            List<string> Test = new List<string>();
            Test.Add("S01E01");
            Test.Add("S01E02");
            Test.Add("S01E03");
            Test.Add("S01E04");
            Test.Add("S01E05");
            Test.Add("S01E06");

            TheWalkingDead.AddEpisodes(Test);


            TheWalkingDead.Title = "The Walking Dead";
            TheWalkingDead.Rating = 8.6;
            TheWalkingDead.SeasonCount = 6;
            TheWalkingDead.URL = @"http://amc.com";
            // TheWalkingDead.EpisodeCount = 10;
            TheWalkingDead.Description = "Zombie Apocalypse baby.... shit ya pants!";

            Console.WriteLine("The Walking Dead hat " + TheWalkingDead.EpisodeCount.ToString() + " Episoden");
            Console.ReadKey();


        }
    }
}
