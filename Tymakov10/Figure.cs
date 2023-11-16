using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    abstract class Figure
    {
        protected double horizontalCoordinate;
        protected double verticalCoordinate;
        protected string color;
        protected bool visible;
        public (double, double) FigureCoordinates
        {
            get { return (horizontalCoordinate, verticalCoordinate); }
        }
        public string Color
        {
            get { return color; }
        }
        public void MoveHorizontal()
        {
            horizontalCoordinate++;
        }

        public void MoveVertical()
        {
            verticalCoordinate++;
        }

        public void ChangColor(string newColor)
        {
            color = newColor;
        }
        public abstract void Status();

        public abstract void Place();

    }
}
