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

        public Figures(int x, int y) : base(x, y)
        {
            containerFigures = new List<Figure>();
            this.Draw();
        }

        public List<Figure> GetFigures()
        {
            return this.containerFigures;
        }

        public override void Draw()
        {
            Console.WriteLine("-----------Init Container Figures-----------");
        }
    }
}
