/* Задача 3: Задайте произвольную строку. Выясните, 
является ли она палиндромом */

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Home_03
{
    public static class Program
    {
        public static void Main(string[] array)
        {
            System.Console.WriteLine("введите текст:");
            string str = Convert.ToString(System.Console.ReadLine());
            char[] stroka = StringToChar(str);
            Array.Reverse(stroka);
            string newstr = new string(stroka);          
            System.Console.WriteLine(stroka);
            Palindrom(str, newstr);


        }

        public static char[] StringToChar(string str)
        {
            int size = str.Length;
            char[] chars = new char[size];

            for (int i = 0; i < size; i++)
            {
                chars[i] = str[i];

            }
            return chars;
        }
        public static void Palindrom(string str, string newstr)
        {
            if(str == newstr) System.Console.WriteLine("yes");
            else System.Console.WriteLine("no");
        }


    }

}




