using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    public  class Song {
        //プロパティ
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        //コンストラクタ
        public Song(string Title, string ArtistName, int Length) {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;

        }
    }
    
}
