using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            {
                new Song("The Beatles", "Get Back" ),
                new Song("Led Zeppelin", "When the levee breaks"),
                new Song("The Smashing Pumpkins", "1979"),
                new Song("Slayer", "Dead skin mask"),
                new Song("Hall & Oates", "Maneater"),
                new Song("Creed", "Take me higher")
            };

            goodSongs.AddRange(allSongs.Where(song => song.Artist != "Creed"));

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} {song.Name}");
            }

        }
    }
}
