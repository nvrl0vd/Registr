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
            
            Console.WriteLine();

            Console.Write("Введите Фамилию: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string SurName = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите имя: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string FirstName = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите Отчетство: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string LastName = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите свой e-mail: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string Mail = Console.ReadLine();
            Console.ResetColor();
        BackToSx:

            Console.Write("Выберите пол(М/Ж): ");
            Console.ForegroundColor = ConsoleColor.Red;
            Sx = Console.ReadLine();
            Console.ResetColor();

            switch (Sx)
            {

                case "М":
                    Sx = "Мужской";
                    break;
                case "Ж":
                    Sx = "Женский";
                    break;
                default:
                    Console.WriteLine("Третьего не дано.");
                    goto BackToSx;

            }
      
            Console.Write("Введите свой login: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string Lgin  = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите свой пароль: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string Pswrd = Console.ReadLine();
            Console.ResetColor();
        BackToCm:

            Console.Write("Вывести данные? (Введите Да/Нет) ");
            Console.ForegroundColor = ConsoleColor.Red;
            Command = Console.ReadLine();
            Console.ResetColor();




            switch (Command)
            {
                case "Да":
                    Console.WriteLine($"Ваше имя: {SurName} {FirstName}, Ваш пол: {Sx}, Ваш e-mail: {Mail}, Ваш логин: {Lgin}");
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
