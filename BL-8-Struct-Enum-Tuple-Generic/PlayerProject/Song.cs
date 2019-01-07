using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProject
{
    class Song
    {
        public int Duration;
        public string Name;
        public Artist Artist;
        public Album Album;
        public string Lyrics;
        public bool PlaySong = false;
        public bool? _like;

        public Song()
        {

        }
        public Song(int duration, string name, Artist artist, Album album)
        {
            Duration = duration;
            Name = name;
            Artist = artist;
            Album = album;
            Lyrics = "Текст песни";
        }

        //BL8-Player2/3.LikeDislike
        public void Like()
        {
            _like = true;
        }

        public void Dislike()
        {
            _like = false;
        }
    }
}
