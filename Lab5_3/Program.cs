using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, count = 0;
            double avr_row;
            Console.WriteLine("Введите количество строк в массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве:");
            int m = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[n, m];
            Console.WriteLine("Введите C:");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите элементы массива");
            //ввод массива
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    array[i, j] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            //вывод массива
            PrintArray("Исходный массив", array, n, m);
            //обработка
            for (i = 0; i < n; i++)
            {
                avr_row = 0;
                for (j = 0; j < m; j++)
                {
                    avr_row += array[i, j];
                }
                avr_row /= m;
                if (avr_row < C)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество строк, среднее арифметическое элементов которых меньше {0}  =  {1}", C, count);
            Console.Read();
        }
        //функция для вывода элементов массива
        public static void PrintArray(string header, double[,]a, int n1, int m1)
        {
            Console.WriteLine(header);
            for (int i = 0; i < n1; ++i)
            {
                for (int j = 0; j < m1; ++j)
                    Console.Write("\t" + a[i, j]);
                Console.WriteLine();
            }
        }
    }
}
