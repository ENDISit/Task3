using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int minNum = 5;
            int maxNum = 10;
            Console.Write("Ввидите число 5 или 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            
            if (num == minNum)
            {
                Console.WriteLine("Число 5 равняется 5.");
            }
            else if (num == maxNum)
            {
                Console.WriteLine("Число 10 равняется 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

            Console.ReadKey();
        }
    }
}