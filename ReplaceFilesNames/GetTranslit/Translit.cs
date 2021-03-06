﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTranslit
{
    class Translit
    {
        private static readonly Dictionary<Char, String> _dict = new Dictionary<Char, String>
              {
                  {'а', "a"},
                  {'б', "b"},
                  {'в', "v"},
                  {'г', "g"},
                  {'д', "d"},
                  {'е', "e"},
                  {'ё', "yo"},
                  {'ж', "zh"},
                  {'з', "z"},
                  {'и', "i"},
                  {'й', "j"},
                  {'к', "k"},
                  {'л', "l"},
                  {'м', "m"},
                  {'н', "n"},
                  {'о', "o"},
                  {'п', "p"},
                  {'р', "r"},
                  {'с', "s"},
                  {'т', "t"},
                  {'у', "u"},
                  {'ф', "f"},
                  {'х', "h"},
                  {'ц', "c"},
                  {'ч', "ch"},
                  {'ш', "sh"},
                  {'щ', "sch"},
                  {'ъ', "j"},
                  {'ы', "i"},
                  {'ь', "j"},
                  {'э', "e"},
                  {'ю', "yu"},
                  {'я', "ya"},
                  {'А', "A"},
                  {'Б', "B"},
                  {'В', "V"},
                  {'Г', "G"},
                  {'Д', "D"},
                  {'Е', "E"},
                  {'Ё', "Yo"},
                  {'Ж', "Zh"},
                  {'З', "Z"},
                  {'И', "I"},
                  {'Й', "J"},
                  {'К', "K"},
                  {'Л', "L"},
                  {'М', "M"},
                  {'Н', "N"},
                  {'О', "O"},
                  {'П', "P"},
                  {'Р', "R"},
                  {'С', "S"},
                  {'Т', "T"},
                  {'У', "U"},
                  {'Ф', "F"},
                  {'Х', "H"},
                  {'Ц', "C"},
                  {'Ч', "Ch"},
                  {'Ш', "Sh"},
                  {'Щ', "Sch"},
                  {'Ъ', "J"},
                  {'Ы', "I"},
                  {'Ь', "J"},
                  {'Э', "E"},
                  {'Ю', "Yu"},
                  {'Я', "Ya"}
              };
 
        public static String GetTranslat(String input)
        {
            return input.Aggregate("", (current, _char) => current + (Char.IsLetter(_char) ? _dict[_char] : _char.ToString()));
        }
    }
}

