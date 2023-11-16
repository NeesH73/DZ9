using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal class Circle: Point
    {
        double radius;
        public void Area()
        {
            Console.WriteLine($"Площадь круга равна {Math.PI * radius*radius}");
        }
        public override void Status()
        {
            if (visible)
            {
                Console.WriteLine("Круг видим");
            }
            else
            {
                Console.WriteLine("Круг невидим");
            }
        }
        public override void Place()
        {
            Console.WriteLine($"Круг {color} цвета. Координаты: по вертикали ( {verticalCoordinate} ) , по горизонтали ( {horizontalCoordinate} ) . Видимость: {visible}, радиуса {radius}");
        }
        public Circle(double radius, string color, bool visible) : base(color, visible)
        {
            this.radius = radius;
        }
    }
}
