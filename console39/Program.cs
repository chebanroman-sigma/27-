using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console39
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Input();

            Console.WriteLine(" Массив (с использованием for цикла):");
            Outputfor(array);

            Console.WriteLine("  Массив (с использованием Reverse()):");
            Outputreverse(array);
        }

      
        public static int[] Input()
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемент массива [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

     
       static public void Outputfor(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    
       static public void Outputreverse(int[] array)
        {
            int[] reversedArray = (int[])array.Clone();
            Array.Reverse(reversedArray);

            foreach (int element in reversedArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}