using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    public class Song {
        //メンバ変数
        private string Title; //歌のタイトル
        private string ArtistName; //アーティスト名
        private int Length;//演奏時間、単位は秒

        //コンストラクタ
        public Song(string Title, string ArtistName, int Length) {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;

        }
    }
    
}
