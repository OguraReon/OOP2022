using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook {
    [Serializable]
    public class Person{
        [System.ComponentModel.DisplayName("名前")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("メールアドレス")]
        public string MailAddress { get; set; }
        [System.ComponentModel.DisplayName("住所")]
        public string Adress { get; set; }
        [System.ComponentModel.DisplayName("会社")]
        public string Company { get; set; }
        public List<Grouptype>listGroup { get; set; }
        [System.ComponentModel.DisplayName("登録日")]
        public DateTime Registration { get; set; }
        [System.ComponentModel.DisplayName("グループ")]
        public string Grop {
            get {
                string groups = "";
                foreach (Grouptype group in listGroup) {
                    groups += "[" + group + "]";
                }
                return groups;
            }
        }
        [System.ComponentModel.DisplayName("電話番号")]
        public KindNumberType kindNumber { get; set; }
        [System.ComponentModel.DisplayName("電話番号")]
        public string TellNumber { get; set; }
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }
        public enum Grouptype {
            家族,
            友人,
            仕事,
            その他,
        }
        public enum KindNumberType {
            自宅,
            携帯,
            その他,
        }
    }
}
