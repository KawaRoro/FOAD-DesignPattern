﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y)
        {
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a rectangle...
            Console.WriteLine("Création d'un rectangle");
        }
    }
}
