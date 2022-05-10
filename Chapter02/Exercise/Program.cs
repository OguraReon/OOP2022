using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            var song1 = new Song("Album1", "Aさん", 2400);
            var song2 = new Song("Album2", "Bさん", 380);
            var song3 = new Song("Album3", "Cさん", 7000);

            var songs = new List<Song>();
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);


        }
    }
}
