using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLogicConsole
{
    public class xbmc_TVShow : xbmc_media
    {

        public int EpisodeCount {

            get {

                int _episodes = 0;
                foreach (string x in Episodes)
                { _episodes++; }

                return _episodes;

            }
            

        }


        public xbmc_TVShow() {

            Episodes = new List<string>();

        }

        public int SeasonCount;
        
        public List<string> Episodes;
        public List<string> EpisodeFiles;

        public void AddEpisodes(List<string> _episodes )
        {
            foreach (string x in _episodes)
            { Episodes.Add(x); }
            
        }


    }
}
