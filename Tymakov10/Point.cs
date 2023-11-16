using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal class Point: Figure
    {
        public override void Status()
        {
            if (visible)
            {
                Console.WriteLine("Точка видима");
            }
            else
            {
                Console.WriteLine("Точка невидима");
            }
        }

        public override void Place()
        {
            Console.WriteLine($"Точка {color} цвета. Координаты: по вертикали ( {verticalCoordinate} ) , по горизонтали ( {horizontalCoordinate} ) . Видимость: {visible}");
        }
        public Point(string color, bool visible)
        {
            this.color = color;
            this.visible = visible;
            horizontalCoordinate = 0;
            verticalCoordinate = 0;
        }
    }
}
