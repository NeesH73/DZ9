using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки шифрования строк.");
            ICipher AC = new ACipher();
            ICipher BC = new BCipher();
            string letters = "ABC";
            string enac=AC.Encode(letters);
            string deac=AC.Decode(letters);
            Console.WriteLine("Начальная строка: " + letters);
            Console.WriteLine("Строка после кодирования: " + enac);
            Console.WriteLine("Cтрока после декодирования: " + deac);

            string enbc=BC.Encode(letters);
            string debc=BC.Decode(letters);
            Console.WriteLine("Начальная строка: " + letters);
            Console.WriteLine("Строка после кодирования: " + enbc);
            Console.WriteLine("Cтрока после декодирования: " + debc);


            Console.WriteLine("Домашнее задание 10.1. Создать класс Figure для работы с геометрическими фигурами.");
            Point point = new Point("Желтый", true);
            Circle circle = new Circle(5, "Черный", false);
            Rectangle rectangle = new Rectangle(9, 7, "Красный", true);
            point.Place();
            circle.Place();
            rectangle.Place();
            Console.WriteLine();

            point.ChangColor("Белый");
            circle.ChangColor("Розовый");
            rectangle.ChangColor("Фиолетовый");

            point.Status();
            circle.Status();
            rectangle.Status();
            Console.WriteLine();

            point.MoveHorizontal();
            point.MoveVertical();
            circle.MoveHorizontal();
            circle.MoveVertical();
            rectangle.MoveHorizontal();
            rectangle.MoveVertical();

            circle.Area();
            rectangle.Area();
            Console.WriteLine();

            point.Place();
            circle.Place();
            rectangle.Place();
            Console.WriteLine();


        }
    }
}
