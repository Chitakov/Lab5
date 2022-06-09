using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            int index_fpos = -1;
            double temp;
            Console.WriteLine("Введите элементы массива");
            double[] array = new double[n];
            //ввод массива
            for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            //вывод массива
            PrintArray("Исходный массив:", array);
            
            //обработка
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    index_fpos = i;
                    break;
                }
            }

            if (index_fpos != -1)
            {
                for (int i = 0; i < index_fpos - 1; i++)
                {
                    for (int j = i + 1; j < index_fpos; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

            //вывод результата
            PrintArray("Искомый массив:", array);
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
