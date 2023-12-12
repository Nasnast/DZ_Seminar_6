/* Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные. */

namespace Home_02
{
    public static class Program
    {
        public static void Main(string[] array)
        {
            System.Console.WriteLine("введите текст латиницей с учетом регистра:");
            string str = System.Console.ReadLine();
            string bigLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string smallLetter = "abcdefghijklmnopqrstuvwxyz";

            char[] charArrey = StringToChar(str);
            char[] bigLetters = StringToChar(bigLetter);
            char[] smallLetters = StringToChar(smallLetter);
            char[] stroka = BigSmallLetter(charArrey, bigLetters, smallLetters);
            str = StringOutChar(stroka);

            System.Console.WriteLine(str);

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
        public static char[] BigSmallLetter(char[] stroka, char[] bigLetters, char[] smallLetters)
        {

            for (int i = 0; i < stroka.Length; i++)
            {
                for (int j = 0; j < bigLetters.Length; j++)
                {
                    if (stroka[i] == bigLetters[j])
                    {
                        stroka[i] = smallLetters[j];
                    }
                }
            }
            
            return stroka;
        }

        public static string StringOutChar(char[] array)
        {
            string result = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                result += array[i];

            }
            return result;

        }




    }

}



