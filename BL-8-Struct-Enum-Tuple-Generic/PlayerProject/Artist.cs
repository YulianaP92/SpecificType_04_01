using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProject
{
    class Artist
    {
        //BL8-Player3/3.SongGenres
        public enum Genre
        {
            Rock,
            Pop,
            Classical,
            Blues,
            Dance,
            Hip_hop
        }
        public string Name;
        public Genre _Genre;
        public Artist(string name, Genre genre)
        {
            Name = name;
            _Genre = genre;
        }
    }
}
