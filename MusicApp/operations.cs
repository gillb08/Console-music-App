using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class operations
    {
        public static void Run() {
            Console.WriteLine("::::::::  Welcome to MyMusicPLayer  :::::::");
            Console.WriteLine("What do you want to do today? \n 1: display all songs \n 2: Addsongs \n 3: remove songs \n 4: Checkout playlist ");
            
            
            Playlist playlist= new Playlist();
            String option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Loading all songs...");
                    playlist.DisplaySongs();
                    break;


                case "2":
                    Console.WriteLine("You have selected Add Song");

                    Playlist.Error_Message();
                    
                    
                    Console.WriteLine("Song have been added successfully");
                    playlist.DisplaySongs();

                    break;



                case "3": // Delete Songs
                    int removeIndex = 0;
                    Console.WriteLine("Whichsong will you like to delete");
                    removeIndex = Convert.ToInt32(Console.ReadLine());
                    // get the playlist and RemoveAT
                    break;
                case "4":
                    //Edit Songs
                    Console.WriteLine("You have selected 4");
                    break;

                default:
                    break;
            }
        }
    }
}
