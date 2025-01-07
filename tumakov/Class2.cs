using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    public class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] == 'Z')
                        chars[i] = 'A';
                    else if (chars[i] == 'z')
                        chars[i] = 'a';
                    else
                        chars[i]++;
                }
            }
            return new string(chars);
        }

        public string Decode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] == 'A')
                        chars[i] = 'Z';
                    else if (chars[i] == 'a')
                        chars[i] = 'z';
                    else
                        chars[i]--;
                }
            }
            return new string(chars);
        }
    }
}
