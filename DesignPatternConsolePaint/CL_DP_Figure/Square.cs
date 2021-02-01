using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Square : Figure
    {
        private Point point;

        public double Height
        {
            get; private set;
        }

        public double Width
        {
            get; private set;
        }

        public Square(int x, int y) : base(x, y)
        {
            //base.Draw();
            this.point = new Point(x, y);
        }
        public Square(Point _point) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.Height = 1; // Default value
            this.Width = 1; // Default value
            //base.Draw();
        }

        public Square(Point _point, double _height, double _width) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.Height = _height;
            this.Width = _width;
            //base.Draw();
        }


        public override void Draw()
        {
            // Code to create and draw a rectangle...
            Console.WriteLine($"Création d'une rectangle aux coordonnées { this.point.x } et { this.point.y } d'une hauteur de { this.Height } et d'une largeur de { this.Width }");
        }
    }
}
