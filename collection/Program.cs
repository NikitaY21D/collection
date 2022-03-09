using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Random r = new Random();
                int[] array = new int[15];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(-30, 30);
                    Console.Write(array[i] + " ");
                }
                for (var i = 1; i < array.Length; i++)
                {
                    for (var j = 0; j < array.Length - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                    }
                }
                for (var i = 1; i < array.Length; i++)
                {
                    for (var j = 0; j < array.Length - i; j++)
                    {
                        if (array[j] >= 0 && array[j + 1] >= 0 && array[j] < array[j + 1])
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < array.Length; Console.Write(array[i++] + " ")) ;
            
        }
    }
}
