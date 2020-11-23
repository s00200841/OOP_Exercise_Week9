using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("ED SHEERAN", "BEAUTIFUL PEOPLE", 3.15, Genre.Pop);
            Song s2 = new Song("REGARD", "RIDE IT", 3.37, Genre.Dance);
            Song s3 = new Song("TONES & I", "DANCE MONKEY", 4.21, Genre.Dance);
            Song s4 = new Song("POST MALONE", "CIRCLES", 3.25, Genre.Pop);
            Song s5 = new Song("ED SHEERAN", "SOUTH OF THE BORDER", 4.26, Genre.Other);
            Song s6 = new Song("TONY FAKES", "MAKE-UP HISTORY");
            Song s7 = new Song();

            List<Song> playlist = new List<Song>();
            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);
            playlist.Add(s6);
            playlist.Add(s7);

            Display(playlist);
            Console.WriteLine();
            playlist.Sort();
            Display(playlist);
            Console.WriteLine();
            Shuffle(playlist);
            Display(playlist);
           
            Console.ReadLine();
        }

        private static void Display(List<Song> playlist)
        {
            Console.WriteLine("{0,-12}{1,-20}{2,-10}{3}","Artist","Song","Duration","Genre");
            foreach (Song song in playlist)
            {
                Console.WriteLine(song);
            }
        }

        private static void Shuffle(List<Song> playlist)
        {
            Random rng = new Random();
            int numberOfSongs = playlist.Count;
            while(numberOfSongs > 1)
            {
                numberOfSongs--;
                int randomNumber = rng.Next(numberOfSongs+1);
                Song song = playlist[randomNumber];
                playlist[randomNumber] = playlist[numberOfSongs];
                playlist[numberOfSongs] = song;
            }
        }
    }
}
