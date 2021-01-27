using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Ligne : Figure
    {
        public Ligne(int x, int y) : base(x, y)
        {
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a ligne...
            Console.WriteLine("Création d'une ligne");
        }
    }
}