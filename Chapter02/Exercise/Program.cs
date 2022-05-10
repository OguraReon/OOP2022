using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            var songs = new Song[] {
                new Song("Album1", "Aさん", 240),
                new Song("Album2", "Bさん", 380),
                new Song("Album3", "Cさん", 700),
            };

            PrintSongs(songs);
        
        }
        private static void PrintSongs(Song[] songs) {

            
            foreach (var song in songs) { 
                Console.WriteLine("{0},{1},{2:m\\:ss}",
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));

             }
            

        }
    }
}
