using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MusicApp
{
    public class Playlist
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal song_duration { get; set; }
        public string Singer { get; set; }
        // watsup with the structuring
        public List<Playlist> PLaylists { get; set; } = new List<Playlist>()
        {
            new Playlist(){ id = 1, name = "Song of Angels", Singer= "Dunsin Oyekan", song_duration = 1.30m  },
            new Playlist(){ id = 2, name = "Wrong turn", Singer= "Gilbert", song_duration = 3.30m  },
            new Playlist(){ id = 3, name = "bring it on", Singer= "P Square", song_duration = 4.30m  },
            new Playlist(){ id = 4, name = "Out of my belly", Singer= "Prospa Ochimana", song_duration = 3.30m  },
        };

        public static void Error_Message()
        {
            Console.WriteLine("INVALID INPUT. PLease Enter words or letters!");
        }

        public void play(Playlist playlist)
        {
            Console.WriteLine($"playing {playlist.name}");
            playlist.play(playlist);
        }

        public void DisplaySongs()
        {
            foreach (Playlist song in PLaylists)
            {
                Console.WriteLine($"ID: {song.id} , Name: {song.name}");
            }
        }
        public void RemoveSong(Playlist playlist)
        {
            PLaylists.Remove(playlist);

        }

        public void NewSong() { }
        public void addSong(Playlist playlist)
        {
        begin: Console.WriteLine("input song name");
            String? New_name = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(name))
            {
                Console.Clear();
                Error_Message();
                goto begin;
            }
        singer: Console.WriteLine($" Sounds good!. Who sang {name}?");
            String? New_singer = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(Singer))
            {
                Console.Clear();
                Error_Message();
                goto singer;
            }
        song_duration: Console.WriteLine($"How long is the song");
            if (decimal.TryParse(Console.ReadLine(), out decimal New_songDuration))
            {
                int New_id = PLaylists.Last().id + 1;
                PLaylists.Add(new Playlist() { id = New_id, name = New_name, Singer = New_singer, song_duration = New_songDuration }) ;
                goto song_duration;
            }
            else
            {
                Console.Clear();
                Error_Message();
                goto begin;
            }
            PLaylists.Add(playlist);
            //HOw to  new LISt with arguments to List
        }
    }
}
