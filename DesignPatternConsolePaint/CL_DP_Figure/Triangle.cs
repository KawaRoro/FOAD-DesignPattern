using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Triangle : Figure
    {
        private Point point;
        private Point point2;
        private Point point3;

        // This function could be removed
        public Triangle(int x, int y) : base(x,y)
        {
            this.point = new Point(x, y);
            this.point2 = new Point(1, 1); // Default value
            this.point3 = new Point(2, 2); // Default value
            //base.Draw();
        }

        public Triangle(Point _point) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.point2 = new Point(2, 2);
            this.point3 = new Point(3, 3);
            //base.Draw();
        }

        // Unique function to create a triangle
        public Triangle(Point _point, Point _point2, Point _point3) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.point2 = new Point(_point2.x, _point2.y);
            this.point3 = new Point(_point3.x, _point3.y);
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a triangle...
            Console.WriteLine($"Création d'un triangle aux coordonnées :{ this.point.x } et { this.point.y } Point 2:{ this.point2.x } et { this.point2.y } Point 3:{ this.point3.x } et { this.point3.y }");
        }
    }
}
