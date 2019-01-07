using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProject
{
    class Player
    {
        private const int minVolume = 0;
        private const int maxVolume = 300;
        private int _volume;
        public bool Locked;
        public bool Playing;
        public List<Song> Song;
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < minVolume)
                {
                    _volume = minVolume;
                }
                if (value > maxVolume)
                {
                    _volume = maxVolume;
                }
                else
                {
                    _volume = value;
                }
            }
        }
        public void VolumeUp()
        {
            if (Locked)
                Console.WriteLine("Player is locked");
            else
            {
                Volume++;
                Console.WriteLine("Increase volume by one");
            }
        }
        public void VolumeDown()
        {
            if (Locked)
                Console.WriteLine("Player is locked");
            else
            {
                Volume--;
                Console.WriteLine("Decrease volume by one");
            }
        }
        public void VolumeChange(int step)
        {
            if (Locked)
                Console.WriteLine("Player is locked");
            else
            {
                Volume += step;
                Console.WriteLine($"To change the volume on: {step}");
            }

        }
        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Player is locked");
        }
        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Player is unlocked");
        }

        public bool Stop()
        {
            if (!Locked)
            {
                Playing = false;
                Console.WriteLine("Player is stopped");
            }
            else
                Console.WriteLine("Player is locked");
            return Playing;
        }
        public bool Start(List<Song> songs, bool loop = false)
        {

            if (!Locked)
            {
                Playing = true;
                Console.WriteLine("Player is playing");
                if (loop)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{songs[i].Name} - {songs[i].Lyrics}");
                    }
                }
                else
                {
                    Console.WriteLine($"{songs[0].Name} - {songs[0].Lyrics}");
                }
            }
            else
                Console.WriteLine("Player is locked");
            return Playing;
        }

        //------------------------------------------------------

        public List<Song> GetSongs()
        {
            List<Artist> artists = new List<Artist>()
            {
                new Artist("Queen", Artist.Genre.Rock),
                new Artist("Marilyn Manson", Artist.Genre.Rock),
                new Artist("Maroon 5", Artist.Genre.Rock),
                new Artist("Nirvana", Artist.Genre.Rock),
                new Artist("Green Day",Artist.Genre.Rock)
            };
            List<Album> album = new List<Album>()
            {
                new Album("Queen II", 1974),
                new Album("Sweet Dreams", 2000),
                new Album("Makes Me Wonder", 2008),
                new Album("Nevermind", 1991),
                new Album("Greatest", 2017)
            };

            List<Song> songs = new List<Song>()
            {
                new Song(120, "I want to break free", artists[0], album[0]),
                new Song(130, "Bowling for Columbine", artists[1], album[1]),
                new Song(200, "Makes Me Wonder", artists[2], album[2]),
                new Song(240, "Flash Gordon", artists[3], album[3]),
                new Song(300, "Windowpane", artists[4], album[4])
            };
            return songs;
        }

        public Song CreateSongs()
        {
            var artist = new Artist("Queen", Artist.Genre.Rock);
            var album = new Album();
            album.Name = "Bohemian Rhapsody";
            album.Year = 1975;
            var song = new Song()
            {
                Album = album,
                Duration = 100,
                Name = "I want to break free",
                Artist = artist
            };

            return song;
        }

        public List<Song> Shuffle(List<Song> songs)
        {
            List<Song> newSong = new List<Song>();
            Random rand = new Random();
            int count = 0;
            while (songs.Count >= 1)
            {
                count = rand.Next(songs.Count);
                newSong.Add(songs[count]);
                songs.RemoveAt(count);
            }
            return newSong;
        }

        public List<Song> SortByTitle(List<Song> songs)
        {
            List<string> songName = new List<string>();
            foreach (var i in songs)
            {
                songName.Add(i.Name);
            }
            songName.Sort();
            List<Song> newListSongs = new List<Song>();
            for (int i = 0; i < songName.Count; i++)
            {
                if (songName[i] == songs[i].Name)
                {
                    newListSongs.Add(songs[i]);
                }
            }
            var sortedName = newListSongs.OrderBy(u => u.Name).ToList();
            return sortedName;
        }

        //BL8-Player1/3.SongTuples
        public void IncludeTheSong(Song song)//песня, которую необходимо включить
        {
            if (Playing)
            {
                song.PlaySong = true;
                Console.WriteLine($"The song is played: {song.Name}");
            }
        }
        public (string name, (int hours, int minutes, int seconds), bool play) GetSongData(Song song)
        {
            return (
                song.Name,
                (song.Duration / 3600,
                (song.Duration % 3600) / 60,
                (song.Duration % 3600) % 60
                ),
                song.PlaySong);
        }

        public void ListSongs(List<Song> songs, Song includeSong)//(список песен, какую песню включить)
        {
            IncludeTheSong(includeSong);
            for (int i = 0; i < songs.Count; i++)
            {
                var song = GetSongData(songs[i]);
                Console.WriteLine($"{song.name}-{song.play} - {song.Item2.hours}:{song.Item2.minutes}:{song.Item2.seconds}");
            }
        }

        //BL8-P3/3.Anonymous
        public object GetSongData_2(Song song)
        {
            var durationMinutes = song.Duration / 60;
            var durationSeconds = song.Duration % 60;
            var anonim = new { song.Name, song.Album.Year, durationMinutes, durationSeconds };
            Console.WriteLine($"{anonim.Name} - {anonim.Year} - {anonim.durationMinutes} - {anonim.durationSeconds}");
            return anonim;
        }
    }
}
