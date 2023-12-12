/* Задача 4*(не обязательная): Задайте строку, состоящую 
из слов, разделенных пробелами. Сформировать строку, 
в которой слова расположены в обратном порядке. В 
полученной строке слова должны быть также разделены 
пробелами. */

namespace Home_04
{
    public static class Program
    {
        public static void Main(string[] array)
        {
            System.Console.WriteLine("введите текст:");
            string input = System.Console.ReadLine();
            string[] stroka = input.Split();
            // int i = 0;
            // foreach (string str in stroka)
            // {
            //     i++;
            //     System.Console.WriteLine($"Слово {str}");
            // }
            // System.Console.WriteLine(i);

            Array.Reverse(stroka);

            for (int j = 0; j < stroka.Length; j++)
            {
                System.Console.Write(stroka[j] + " ");
            }

        }

    }

}



