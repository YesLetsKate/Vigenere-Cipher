using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_Сipher
{
    internal class VigenereCipher
    {
        static string Ralf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int n = Ralf.Length;
        public VigenereCipher() { }
        public string Encrypt(string text,string key)
        {
            string cipher = "";
            int i = 0;
            int j = 0;
            while (true)
            {
                int index = Ralf.IndexOf(text[i]);
                int keyindex = Ralf.IndexOf(key[j]);
                int newindex = Modulo(index + keyindex,n);
                cipher = cipher + Ralf[newindex];
                i++;
                j = Modulo(j + 1,key.Length);
                try { char k = text[i]; }
                catch { break; }
            }
            return cipher;
        }
        public string Decrypt(string text, string key)
        {
            string opentext = "";
            int i = 0;
            int j = 0;
            while (true)
            {
                int index = Ralf.IndexOf(text[i]);
                int keyindex = Ralf.IndexOf(key[j]);
                int newindex = Modulo(index - keyindex, n);
                opentext = opentext + Ralf[newindex];
                i++;
                j = Modulo(j + 1, key.Length);
                try { char k = text[i]; }
                catch { break; }
            }
            return opentext;
        }
        private int Modulo(int a, int n)
        {
            if (a >= n || a < 0)
            {
                if (a < 0)
                {
                    a = a % n;
                    a = a + n;
                }
                else a = a % n;
            }
            return a;
        }
    }
}
