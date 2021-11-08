using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public void Main(string[] args)
        {
            string Sx = null;
            string Command = null;

            string[] Data = new string[7];

            Console.Write("Введите Фамилию: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Data[0] = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите имя: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Data[1] = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите Отчетство: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Data[2] = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите свой e-mail: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Data[3] = Console.ReadLine();
            Console.ResetColor();
        BackToSx:

            Console.Write("Выберите пол(М/Ж): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Data[4] = Console.ReadLine();
            Console.ResetColor();

            switch (Data[4])
            {

                case "М":
                    Data[4] = "Мужской";
                    break;
                case "Ж":
                    Data[4] = "Женский";
                    break;
                default:
                    Console.WriteLine("Третьего не дано.");
                    goto BackToSx;

            }
      
            Console.Write("Введите свой login: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Data[5] = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите свой пароль: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Data[6] = Console.ReadLine();
            Console.ResetColor();
        BackToCm:

            Console.Write("Вывести данные? (Введите Да/Нет) ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Command = Console.ReadLine();
            Console.ResetColor();




            switch (Command)
            {
                case "Да":
                    Console.WriteLine($"Ваше имя: {Data[0]} {Data[1]} {Data[2]} , Ваш пол: {Data[4]}, Ваш e-mail: {Data[3]}, Ваш логин: {Data[5]}");
                    break;
                case "Нет":
                    Console.WriteLine("Ок :(");
                    break;
                default:
                    Console.WriteLine("Такого выбора не давалось.");
                    goto BackToCm;





               

            }

            Console.ReadKey();






        }
    }
}
