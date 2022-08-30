using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using Microsoft.VisualBasic;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise01 {
    class StrConv : TextProcessor{
        //private string num = @"Sample.txt"; 

        //protected override void Execute(string line) {
        //    Console.WriteLine(Strings.StrConv(File.ReadAllText(num), VbStrConv.Narrow, 0));

        //}

        private static Dictionary<char, char> dictionary = new Dictionary<char, char>(){
            {'０','0'},{ '１','1'},{ '２','2'},{ '３','3'},{ '４','4'},{ '５','5'},{ '６','6'},{ '７','7'},
            { '８','8'},{ '９','9'}
        };
        protected override void Execute(string line) {
            string s = Regex.Replace(line, "[0-9]", c => dictionary[c.Value[0]].ToString());
            Console.WriteLine(s);
        }




    }
}
