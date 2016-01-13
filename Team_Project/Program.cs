using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new List<Song>();

            // Uncomment 1 item at a time and check the results

            //PrintSongs(songs);
        }

        static void PrintSongs(List<Song> song)
        {
            var lsongs = from s in song
                         where s.Duration > 3
                         select s;

            foreach (var ls in lsongs)
                Console.WriteLine("{0} - {1}", ls.SongName, ls.Duration);
        }
    }
}
