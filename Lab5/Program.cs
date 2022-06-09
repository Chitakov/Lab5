using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double pr = 1;
            int i;
            Console.WriteLine("Введите элементы массива:");
            double[] array = new double[n];
            //ввод массива
            for (i = 0; i < array.Length; i++)
                array[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            //вывод массива
            PrintArray("Исходный массив:", array);
            //обработка
            for (i = 0; i < n; i++)
                if (array[i] > C) pr *= array[i];
            //вывод результата
            if (pr != 1) Console.WriteLine("Произведение элементов массива, которые больше {0} = {1}", C, pr);
            else Console.WriteLine("Элементов, которые больше {0} нет", C);
            Console.ReadLine();
        }

        //функция для вывода элементов массива
        public static void PrintArray(string header, double[] a)
        {
            Console.WriteLine(header);
            for (int i = 0; i < a.Length; ++i)
                Console.Write("\t" + a[i]);
            Console.WriteLine();
        }
    }
}
