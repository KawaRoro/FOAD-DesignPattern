using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Figures : Figure
    {
        public List<Figure> containerFigures { get; set; }

        public Figures(int x, int y) : base(x, y) // , int Height, int Width
        {
            var containerFigures = new List<Figure>();
        }

        public override void Draw()
        {
            Console.WriteLine("-----------Init Container Figures-----------");
        }
    }
}
