using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EncryptionClassLibrary
{
    public class EncryptionClass
    {
        /// <summary>
        /// зашифровывает строку
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns>возращает зашифрованный текст</returns>
        /// <exception cref="Exception"></exception>
        public static string Encryption(string str, string key)
        {
            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(key))
                throw new Exception();

            str = str.ToLower();
            key = key.ToLower();

            if(!Regex.Match(str, "[а-я ]").Success)
                throw new Exception();

            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            int lenght_key = key.Length;

            foreach (char chars in alphabet)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (str[i] == chars)
                        {
                            str += Convert.ToString(char.GetNumericValue(alphabet[j + lenght_key]));
                        }
                    }
                }
            }


            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < alphabet.Length; j++)
            //    {
            //        if (str[i] =)
            //        {
            //            str[i] = alphabet[j + lenght_key];
            //        }
            //    }
            //}

            return "";
        }
    }
}
