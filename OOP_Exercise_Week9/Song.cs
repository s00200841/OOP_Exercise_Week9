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

        public Song(string artist, string title, double duration, Genre musicGenre)
        {
            Artist = artist;
            Title = title;          
            Duration = duration;
            MusicGenre = musicGenre;
        }
        public Song(string artist, string title) : this(artist, title, 0, Genre.Other) { }

        public Song() : this("Unknown", "Unknown") { }

        public override string ToString()
        {
            return string.Format($"{Artist,-12} {Title,-20} {Duration,-10} {MusicGenre}").ToString();
        }
    }

    public enum Genre { Rock, Pop, Dance, Other }
}
