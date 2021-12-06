using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    class Program
    {
        // Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
        static void Main(string[] args)
        {
            Console.WriteLine("Если не возникает сообщения об ошибке, то полученная матрица - магический квадрат.");
            Console.WriteLine();
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Console.WriteLine("Заполните масcив размера {0} на {0}", n);            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());                    
                }                
            }
            Console.WriteLine("Получен следующий масcив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            int magicConst = n * (n * n + 1) / 2;
            for (int i = 0; i < n; i++)
            {
                int sumString = 0;
                int sumColumn = 0;
                for (int j = 0; j < n; j++)
                {
                    sumString += array[i, j];
                    sumColumn += array[j, i];
                }                
                if (sumString != magicConst && sumColumn != magicConst)
                {
                    Console.WriteLine("Ошибка! Это не магический квадрат.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
