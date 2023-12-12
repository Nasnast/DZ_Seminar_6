/* Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
 */

using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Home_01
{
    public static class Program
    {
        public static void Main(string[] array)
        {

            System.Console.WriteLine("строки (rows): ");
            int rows = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("столбцы (cols): ");
            int cols = Convert.ToInt32(Console.ReadLine());
            char[,] charsArr = TwoCharsArray(rows, cols);
            PrintTwoArray(charsArr);
            string result = StringOutChar(charsArr);
            System.Console.WriteLine("строка из символов этого массива:");
            System.Console.WriteLine(string.Join(", ", result));
            
        }

        public static char[,] TwoCharsArray(int rows, int cols)
        {

            System.Console.WriteLine("значения массива: ");
            char[,] charsArray = new char[rows, cols];
            Random rand = new();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    charsArray[i, j] = (char)rand.Next('a', 'z' + 1);
                }



            }
            
            return charsArray;
        }

        public static void PrintTwoArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(array[i, j] + "\t");
                }
                System.Console.WriteLine();
            }

        }

        public static string StringOutChar(char[,] array)
        {
            string result = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j];
                }
            }
            return result;

        }




    }

}







