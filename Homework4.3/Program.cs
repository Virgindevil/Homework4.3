using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" Введите верхний диапазон загадываемого числа:");           
            int rand = random.Next(0, int.Parse(Console.ReadLine()) + 1);
            Console.WriteLine("\n Число загадано! Если устанете, просто введите пустую строку! \n");     
            do
            { 
                Console.Write(" Введите ваше число: ");
                string check = Console.ReadLine();                
                if (check != "")
                {
                    number = int.Parse(check);
                    if (number < rand)
                    {
                        Console.WriteLine(" Загаданное число больше! \n");
                    }
                    else if (number > rand)
                    {
                        Console.WriteLine(" Загаданное число меньше! \n");
                    }
                }
                else
                {
                    Console.WriteLine($" Хорошо! Вот загаданное число: {rand} ");
                    Console.ReadKey();
                    break;
                }
            } while (number != rand);
            Console.WriteLine($"\n Вы угадали! Загаданное число: {rand} \n");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
