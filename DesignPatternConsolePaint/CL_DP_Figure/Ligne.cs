using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Ligne : Figure
    {
        private Point point;
        private Point point2;

        public Ligne(int x, int y) : base(x, y)
        {
            this.point = new Point(x, y);
        }
        public Ligne(Point _point, Point _point2) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.point2 = new Point(_point2.x, _point2.y);
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a ligne...
            Console.WriteLine($"Création d'une ligne aux coordonnées { this.point.x } et { this.point.y } jusqu'à  { this.point2.x } et { this.point2.y }");
        }
    }
}