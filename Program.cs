﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_4._1
{
    internal class Program
    {
        static void Main()
        {
            //Task1
            int[] array = new int[9];
            Random rand = new Random();


            Console.WriteLine("Вихідний масив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10); 
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();



            int result = 0;
            int firstElement = array[0];
            for (int i = 1; i < array.Length; i++) 
            {
                if (array[i] < firstElement)
                {
                    result += array[i];
                }
            }

            Console.WriteLine($"Сума елементів, менших за перший елемент ({firstElement}), дорівнює: {result}");
        }
    }

}
    

