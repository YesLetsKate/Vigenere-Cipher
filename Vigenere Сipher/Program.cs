// See https://aka.ms/new-console-template for more information
using Vigenere_Сipher;

Console.Write("Текст:  ");
string text =  Console.ReadLine();
Console.Write("Ключ:  ");
string key = Console.ReadLine();
VigenereCipher vigenereCipher = new VigenereCipher();
string cipher = vigenereCipher.Encrypt(text, key);
Console.Write("Шифр:  ");
Console.WriteLine(cipher);

string opentxt = vigenereCipher.Decrypt(cipher, key);
Console.Write("Открытый текст:  ");
Console.WriteLine(opentxt);
