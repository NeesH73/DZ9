using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal class Rectangle:Point
    {
        double width;
        double length;
        public void Area()
        {
            Console.WriteLine($"Площадь прямоугольника равна {width*length}");
        }
        public override void Status()
        {
            if (visible)
            {
                Console.WriteLine("Прямоугольник видим");
            }
            else
            {
                Console.WriteLine("Прямоугольник невидим");
            }
        }
        public override void Place()
        {
            Console.WriteLine($"Прямоугольник {color} цвета. Координаты: по вертикали ( {verticalCoordinate} ) , по горизонтали ( {horizontalCoordinate} ) . Видимость: {visible}, длина прямоугольника {length}, ширина прямоугольника {width}");

        }
        public Rectangle(double length, double width, string color, bool visible) : base(color, visible)
        {
            this.length = length;
            this.width = width;
        }

    }
}
