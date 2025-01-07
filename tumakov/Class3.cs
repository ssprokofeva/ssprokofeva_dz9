using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{   public class BCipher : ICipher
    {
        private static readonly string AlphabetUpperCase = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static readonly string AlphabetLowerCase = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public string Encode(string input)
        {
            StringBuilder result = new StringBuilder(input.Length);
            foreach (char c in input)
            {
                int index = AlphabetUpperCase.IndexOf(c);
                if (index != -1)
                    result.Append(AlphabetUpperCase[AlphabetUpperCase.Length - index - 1]);
                else
                {
                    index = AlphabetLowerCase.IndexOf(c);
                    if (index != -1)
                        result.Append(AlphabetLowerCase[AlphabetLowerCase.Length - index - 1]);
                    else
                        result.Append(c);
                }
            }
            return result.ToString();
        }

        public string Decode(string input)
        {
            return Encode(input);
        }
    }
}
