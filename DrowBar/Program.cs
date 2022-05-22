using System;

namespace UlElement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startTheProgram = true;

            while (startTheProgram)
            {
                int valueHelthBar;
                int valueManaBar;
                Console.Write("Введите на сколько % заполнена шкалы Healthbar ( не больше 100): ");
                valueHelthBar = int.Parse(Console.ReadLine()) / 2;
                Console.Write("Введите на сколько % заполнена шкалы ManaBar ( не больше 100): ");
                valueManaBar = int.Parse(Console.ReadLine()) / 2;


                if (valueHelthBar <= 50 && valueManaBar <= 50)
                {
                    CreateBar(valueHelthBar, ConsoleColor.Red);
                    Console.WriteLine();
                    CreateBar(valueManaBar, ConsoleColor.Blue);
                    startTheProgram = false;
                }

                else
                {
                    Console.WriteLine("Процент указан не верно! Попробуйте заного!");
                }
            }
        }

        static string DrowFor(int indexI, int value, char simvol, ref string bar)
        {
            for (int i = indexI; i < value; i++)
            {
                bar += simvol;
            }

            return bar;
        }
        static void CreateBar(int value, ConsoleColor color)
        {
            int maxValue = 50;
            string bar = "";

            DrowFor(0, value, '#', ref bar);

            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            bar = "";

            DrowFor(value, maxValue, ' ', ref bar);

            Console.Write(bar);
            Console.ResetColor();
            Console.WriteLine("]");
        }
    }
}
//Задача:
//Разработайте функцию, которая рисует некий бар(Healthbar, Manabar)в определённой позиции. Она также принимает некий закрашенный процент.
//При 40% бар выглядит так:
//[####_____]
