using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Week9
{
    class Song
    {      
        public string Title { get; set; }

        public string Artist { get; set; }
        public double Duration { get; set; }
       
        public Genre MusicGenre { get; set; }

        public Song(string title, string artist, double duration, Genre musicGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }
        public Song(string title, string artist) : this(title, artist, 0, Genre.Other) { }

        public Song() : this("Unknown", "Unknown") { }

        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}").ToString();
        }
    }

    public enum Genre { Rock, Pop, Dance, Other }
}
